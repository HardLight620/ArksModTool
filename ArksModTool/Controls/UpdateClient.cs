using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArksModTool
{
    public class UpdateClient : Component
    {
        public event DownloadProgressChangedEventHandler DownloadProgressChanged;

        public string UpdateServer { get; set; }
        public string UpdateFile { get; set; }
        public string TimeStampFile { get; set; }

        [Browsable(false)]
        public bool IsBusy { get { return m_client.IsBusy; } }

        private WebClient m_client = null;
        private SynchronizationContext m_syncContext = null;

        public UpdateClient()
        {
            m_client = new WebClient();
            m_client.DownloadProgressChanged += Client_DownloadProgressChanged;

            m_syncContext = SynchronizationContext.Current;
        }

        public void CancelAsync()
        {
            m_client.CancelAsync();
        }

        public Task<bool> CheckForUpdate()
        {
            string url = null;
            try { url = Path.Combine(this.UpdateServer, this.TimeStampFile); }
            catch (ArgumentException ex) { return Task.Run<bool>(new Func<bool>(() => { throw ex; })); }

            Task<string> downloadTask = m_client.DownloadStringTaskAsync(url);
            Task<bool> checkTask = downloadTask.ContinueWith(task => CheckUpdateResult(task));

            return checkTask;
        }

        public Task<string> DownloadUpdate(string fileName)
        {
            string url = Path.Combine(this.UpdateServer, this.UpdateFile);
            string path = Path.GetFullPath(fileName);

            Task downloadTask = m_client.DownloadFileTaskAsync(url, path);
            Task<string> resultTask = downloadTask.ContinueWith(task => ReturnDownloadResult(task, path));

            return resultTask;
        }

        private bool CheckUpdateResult(Task<string> downloadTask)
        {
            if (downloadTask.IsFaulted)
                throw downloadTask.Exception.GetBaseException();

            DateTime newStamp;
            if (!DateTime.TryParse(downloadTask.Result, out newStamp))
                throw new FormatException("Received malformed update info.");

            return newStamp > Program.BuildTime;
        }

        private string ReturnDownloadResult(Task downloadTask, string fileName)
        {
            if (downloadTask.IsFaulted)
                throw downloadTask.Exception.GetBaseException();

            return fileName;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (DownloadProgressChanged != null)
                m_syncContext.Send(@this => DownloadProgressChanged.Invoke(@this, e), this);

        }
    }
}
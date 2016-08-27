using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

internal static class ApplicationEx
{
    /// <summary>
    /// Safely clears the exit state after Application.Exit has been called allowing message boxes to function properly again.
    /// </summary>
    public static void ClearExitState()
    {
        bool done = false;
        while (!done)
        {
            // Application.Idle gets cleared each run.
            Application.Idle += (o, e) =>
                {
                    Task.Run(() => Application.Exit());
                    done = true;
                };

            Application.Run();
        }
    }
}
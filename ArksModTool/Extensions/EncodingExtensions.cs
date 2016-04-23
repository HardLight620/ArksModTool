using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Text
{
    internal static class EncodingExtensions
    {
        public static void WriteString(this Encoding encoding, IntPtr ptr, string str)
        {
            int byteCount = encoding.GetByteCount(str);

            Marshal.Copy(encoding.GetBytes(str), 0, ptr, byteCount);
        }

        public static void WriteString(this Encoding encoding, IntPtr ptr, int ofs, string str)
        {
            WriteString(encoding, IntPtr.Add(ptr, ofs), str);
        }
    }
}

using System;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WindowDetectionBusinessLayer.Repository;

namespace WindowDetectionBusinessLayer.Services
{
    public class WindowDetection : DisposeRepository, IWindowDetection
    {
        [DllImport("user32", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private extern static bool EnumThreadWindows(int threadId, EnumWindowsProc callback, IntPtr lParam);

        [DllImport("user32", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool EnumChildWindows(IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32", SetLastError = true, CharSet = CharSet.Auto)]
        private extern static int GetWindowText(IntPtr hWnd, StringBuilder text, int maxCount);
        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
        public bool isWindowOpened(Process process, string title)
        {
            IntPtr hWnd = FindWindowInProcess(process, s => s.Contains(title));
            if (hWnd != IntPtr.Zero)
                return true;
            else
                return false;
        }
        public IntPtr FindWindowInProcess(Process process, Func<string, bool> compareTitle)
        {
            IntPtr windowHandle = IntPtr.Zero;
            foreach (ProcessThread t in process.Threads)
            {
                windowHandle = FindWindowInThread(t.Id, compareTitle);
                if (windowHandle != IntPtr.Zero)
                    break;
            }
            return windowHandle;
        }

        public IntPtr FindWindowInThread(int threadId, Func<string, bool> compareTitle)
        {
            IntPtr windowHandle = IntPtr.Zero;
            EnumThreadWindows(threadId, (hWnd, lParam) =>
            {
                StringBuilder text = new StringBuilder(200);
                GetWindowText(hWnd, text, 200);
                if (compareTitle(text.ToString()))
                {
                    windowHandle = hWnd;
                    return false;
                }
                return true;
            }, IntPtr.Zero);

            return windowHandle;
        }
    }
}

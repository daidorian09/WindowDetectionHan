using System;
using System.Diagnostics;

namespace WindowDetectionBusinessLayer
{
    interface IWindowDetection
    {
        bool isWindowOpened(Process process, string title);
        IntPtr FindWindowInProcess(Process process, Func<string, bool> compareTitle);
        IntPtr FindWindowInThread(int threadId, Func<string, bool> compareTitle);
    }
}

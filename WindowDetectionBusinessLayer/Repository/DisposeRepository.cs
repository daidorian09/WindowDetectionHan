using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace WindowDetectionBusinessLayer.Repository
{
    public abstract class DisposeRepository : IDisposable
    {
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
                handle.Dispose();
            disposed = true;
        }
    }
}

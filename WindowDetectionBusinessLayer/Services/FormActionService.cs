using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using WindowDetectionBusinessLayer.Repository;

namespace WindowDetectionBusinessLayer.Services
{
    public class FormActionService : DisposeRepository, IFormAction
    {
        public void DisposeForm()
        {
            if (System.Windows.Forms.Application.MessageLoop)
                System.Windows.Forms.Application.Exit();
        }

        public Process[] GetProcesses()
        {
            return Process.GetProcesses();
        }

        public int GetTextLength(string text)
        {
            return text.Length;
        }

        public bool isTextValid(string text)
        {
            return !string.IsNullOrEmpty(text) == true ? true : false;
        }
    }
}

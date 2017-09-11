using System.Diagnostics;

namespace WindowDetectionBusinessLayer.Repository
{
    interface IFormAction
    {
        Process[] GetProcesses();
        int GetTextLength(string text);
        bool isTextValid(string text);
        void DisposeForm();
    }
}

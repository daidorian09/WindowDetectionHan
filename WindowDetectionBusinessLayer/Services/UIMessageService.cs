using System;
using System.Windows.Forms;
using WindowDetectionBusinessLayer.Repository;

namespace WindowDetectionBusinessLayer.Services
{
    public class UIMessageService : DisposeRepository, IUIMessage
    {
        public void DisplayAppOnExit()
        {
            MessageBox.Show(new Form() { TopMost = true }, $"App is now exiting", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DisplayInvalidProcessName()
        {
            MessageBox.Show(new Form() { TopMost = true }, $"Process is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DisplayInvalidTextError()
        {
            MessageBox.Show(new Form() { TopMost = true }, $"Text is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DisplayWindowFound()
        {
            MessageBox.Show(new Form() { TopMost = true }, $"Window is found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DisplayWindowNotFound()
        {
            MessageBox.Show(new Form() { TopMost = true }, $"Window is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

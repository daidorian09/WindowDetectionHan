<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowDetectionBusinessLayer.Services;

namespace WindowDetectionApp
{
    public partial class WindowDetectionForm : Form
    {
        private readonly FormActionService _formActionService = new FormActionService();
        private readonly WindowDetection _windowDetectionService = new WindowDetection();
        private readonly UIMessageService _uiMessageService = new UIMessageService();

        private Process[] processes = null;
        private Process myProcess = null;
        private string windowName = string.Empty;
        public WindowDetectionForm()
        {
            InitializeComponent();
        }
        private void MakeButtonVisible(Button button)
        {
            button.Visible = true;
        }
        private void MakeButtonInvisible(Button button)
        {
            button.Visible = false;
        }

        private void SetTextEmpty()
        {
            txtProcessName.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(_formActionService.isTextValid(txtSearch.Text) && _formActionService.GetTextLength(txtSearch.Text) > 3)
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnDetect.PerformClick();                   
            }
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            try
            {
                if(_formActionService.isTextValid(txtSearch.Text.Trim()) && _formActionService.isTextValid(txtProcessName.Text.Trim()))
                    InitWindowDetection();
                else
                    _uiMessageService.DisplayInvalidTextError();
            }
            catch (Exception)
            {
                _uiMessageService.DisplayInvalidTextError();
            }
        }
        private void InitWindowDetection()
        {
            AssignMyProcess();
            windowName = txtSearch.Text.Trim();
            if (_windowDetectionService.isWindowOpened(myProcess, windowName))
                DisplayWindowFoundMessage();
            else
                DisplayWindowNotFoundMessageAndClearText();
        }
        private void DisplayWindowFoundMessage()
        {
            _uiMessageService.DisplayWindowFound();
            SetTextEmpty();
            MakeButtonVisible(btnExit);
            DialogResult dr = MessageBox.Show("Proceed to Press Yes or Exit to Press No Buttons ",
                      "Window Detection Dialog", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    SetTextEmpty();
                    break;
                case DialogResult.No:
                    DisposeServices();
                    _formActionService.DisposeForm();
                    break;
            }
        }
        private void DisposeServices()
        {
            _uiMessageService.Dispose();
            _windowDetectionService.Dispose();
            _formActionService.Dispose();
        }

        private void DisplayWindowNotFoundMessageAndClearText()
        {
            _uiMessageService.DisplayWindowNotFound();
            SetTextEmpty();
        }
        private void AssignMyProcess()
        {
            string processName = txtProcessName.Text.Trim();
            processes = _formActionService.GetProcesses();
            foreach (var item in processes)
            {
                if (item.ProcessName.Equals(processName))
                    myProcess = item;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _uiMessageService.DisplayAppOnExit();
            DisposeServices();
            _formActionService.DisposeForm();
        }
    }
}

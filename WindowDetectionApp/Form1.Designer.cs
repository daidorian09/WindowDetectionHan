namespace WindowDetectionApp
{
    partial class WindowDetectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowDetectionForm));
            this.btnDetect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblWindow = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDetect
            // 
            this.btnDetect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetect.BackgroundImage")));
            this.btnDetect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetect.Location = new System.Drawing.Point(12, 190);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(169, 124);
            this.btnDetect.TabIndex = 1;
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(12, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 124);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 150);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblWindow
            // 
            this.lblWindow.AutoSize = true;
            this.lblWindow.Font = new System.Drawing.Font("Myriad Hebrew", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindow.Location = new System.Drawing.Point(22, 97);
            this.lblWindow.Name = "lblWindow";
            this.lblWindow.Size = new System.Drawing.Size(139, 24);
            this.lblWindow.TabIndex = 4;
            this.lblWindow.Text = "Window Search";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Myriad Hebrew", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(22, 18);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(127, 24);
            this.lblProcess.TabIndex = 6;
            this.lblProcess.Text = "Process Name";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(12, 54);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(169, 22);
            this.txtProcessName.TabIndex = 5;
            // 
            // WindowDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(194, 491);
            this.Controls.Add(this.lblWindow);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtProcessName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WindowDetectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Detection Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblWindow;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.TextBox txtProcessName;
    }
}


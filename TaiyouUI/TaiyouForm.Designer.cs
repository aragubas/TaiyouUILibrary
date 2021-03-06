/*
   Copyright 2021 Aragubas/Paulo Otávio de Lima

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License. 
  
 */

namespace TaiyouUI
{
    partial class TaiyouForm
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
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.WindowButtonsPanel = new System.Windows.Forms.Panel();
            this.FormMinimizeButton = new System.Windows.Forms.Button();
            this.FormMaximizeButton = new System.Windows.Forms.Button();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.FormTitlebar = new TaiyouUI.MoveWindowLabel();
            this.FormControls = new System.Windows.Forms.Panel();
            this.TitlebarPanel.SuspendLayout();
            this.WindowButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitlebarPanel.Controls.Add(this.WindowButtonsPanel);
            this.TitlebarPanel.Controls.Add(this.FormTitlebar);
            this.TitlebarPanel.Location = new System.Drawing.Point(7, 1);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(654, 26);
            this.TitlebarPanel.TabIndex = 5;
            // 
            // WindowButtonsPanel
            // 
            this.WindowButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowButtonsPanel.Controls.Add(this.FormMinimizeButton);
            this.WindowButtonsPanel.Controls.Add(this.FormMaximizeButton);
            this.WindowButtonsPanel.Controls.Add(this.FormCloseButton);
            this.WindowButtonsPanel.Location = new System.Drawing.Point(551, 0);
            this.WindowButtonsPanel.Name = "WindowButtonsPanel";
            this.WindowButtonsPanel.Size = new System.Drawing.Size(97, 20);
            this.WindowButtonsPanel.TabIndex = 3;
            // 
            // FormMinimizeButton
            // 
            this.FormMinimizeButton.BackColor = System.Drawing.Color.DimGray;
            this.FormMinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormMinimizeButton.FlatAppearance.BorderSize = 0;
            this.FormMinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.FormMinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormMinimizeButton.Font = new System.Drawing.Font("Arial", 7.5F);
            this.FormMinimizeButton.ForeColor = System.Drawing.Color.White;
            this.FormMinimizeButton.Location = new System.Drawing.Point(3, 0);
            this.FormMinimizeButton.Name = "FormMinimizeButton";
            this.FormMinimizeButton.Size = new System.Drawing.Size(25, 20);
            this.FormMinimizeButton.TabIndex = 0;
            this.FormMinimizeButton.TabStop = false;
            this.FormMinimizeButton.Text = "─";
            this.FormMinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FormMinimizeButton.UseVisualStyleBackColor = false;
            this.FormMinimizeButton.Click += new System.EventHandler(this.FormMinimizeButton_Click);
            // 
            // FormMaximizeButton
            // 
            this.FormMaximizeButton.BackColor = System.Drawing.Color.Gray;
            this.FormMaximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormMaximizeButton.FlatAppearance.BorderSize = 0;
            this.FormMaximizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.FormMaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormMaximizeButton.Font = new System.Drawing.Font("Arial", 7.5F);
            this.FormMaximizeButton.ForeColor = System.Drawing.Color.White;
            this.FormMaximizeButton.Location = new System.Drawing.Point(28, 0);
            this.FormMaximizeButton.Name = "FormMaximizeButton";
            this.FormMaximizeButton.Size = new System.Drawing.Size(25, 20);
            this.FormMaximizeButton.TabIndex = 0;
            this.FormMaximizeButton.TabStop = false;
            this.FormMaximizeButton.Text = "↨";
            this.FormMaximizeButton.UseVisualStyleBackColor = false;
            this.FormMaximizeButton.Click += new System.EventHandler(this.FormMaximizeButton_Click);
            // 
            // FormCloseButton
            // 
            this.FormCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FormCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormCloseButton.FlatAppearance.BorderSize = 0;
            this.FormCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.FormCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCloseButton.Font = new System.Drawing.Font("Arial", 7.5F);
            this.FormCloseButton.ForeColor = System.Drawing.Color.White;
            this.FormCloseButton.Location = new System.Drawing.Point(53, 0);
            this.FormCloseButton.Name = "FormCloseButton";
            this.FormCloseButton.Size = new System.Drawing.Size(44, 20);
            this.FormCloseButton.TabIndex = 0;
            this.FormCloseButton.TabStop = false;
            this.FormCloseButton.Text = "X";
            this.FormCloseButton.UseVisualStyleBackColor = false;
            this.FormCloseButton.Click += new System.EventHandler(this.FormCloseButton_Click);
            // 
            // FormTitlebar
            // 
            this.FormTitlebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTitlebar.Font = new System.Drawing.Font("Arial", 10F);
            this.FormTitlebar.Location = new System.Drawing.Point(0, 0);
            this.FormTitlebar.Name = "FormTitlebar";
            this.FormTitlebar.Size = new System.Drawing.Size(654, 26);
            this.FormTitlebar.TabIndex = 0;
            this.FormTitlebar.Text = "Untitled Window";
            this.FormTitlebar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormControls
            // 
            this.FormControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormControls.Location = new System.Drawing.Point(3, 29);
            this.FormControls.Name = "FormControls";
            this.FormControls.Size = new System.Drawing.Size(657, 391);
            this.FormControls.TabIndex = 0;
            this.FormControls.Validated += new System.EventHandler(this.FormControls_Validated);
            // 
            // TabNotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(663, 423);
            this.Controls.Add(this.TitlebarPanel);
            this.Controls.Add(this.FormControls);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabNotepadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Untitled Window";
            this.Activated += new System.EventHandler(this.TabNotepadForm_Activated);
            this.Load += new System.EventHandler(this.TabNotepadForm_Load);
            this.ResizeBegin += new System.EventHandler(this.TabNotepadForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.TabNotepadForm_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TabNotepadForm_Paint);
            this.TitlebarPanel.ResumeLayout(false);
            this.WindowButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel TitlebarPanel;
        public System.Windows.Forms.Button FormMaximizeButton;
        public System.Windows.Forms.Button FormCloseButton;
        public MoveWindowLabel FormTitlebar;
        public System.Windows.Forms.Panel FormControls;
        private System.Windows.Forms.Panel WindowButtonsPanel;
        public System.Windows.Forms.Button FormMinimizeButton;

    }
}
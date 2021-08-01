﻿
namespace WorldStat.Core.Forms
{
    partial class CreateDbForm
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
            this.labelDate = new System.Windows.Forms.Label();
            this.coloredProgressBar = new Wc32Api.Widgets.WcProgressBar();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.labelDate.Location = new System.Drawing.Point(12, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(402, 46);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Синхронизация за";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coloredProgressBar
            // 
            this.coloredProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.coloredProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.coloredProgressBar.Location = new System.Drawing.Point(12, 70);
            this.coloredProgressBar.Name = "coloredProgressBar";
            this.coloredProgressBar.Size = new System.Drawing.Size(404, 35);
            this.coloredProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.coloredProgressBar.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.labelInfo.Location = new System.Drawing.Point(12, 108);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(404, 38);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "label1";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(428, 167);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.coloredProgressBar);
            this.Controls.Add(this.labelDate);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadReportForm_FormClosing);
            this.Load += new System.EventHandler(this.LoadReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelDate;
        private Wc32Api.Widgets.WcProgressBar coloredProgressBar;
        private System.Windows.Forms.Label labelInfo;
    }
}
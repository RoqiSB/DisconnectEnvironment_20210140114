﻿namespace Disconnect_Environment
{
    partial class DataMaster
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataProdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMahasiswaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataStatusMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataProdiToolStripMenuItem,
            this.dataMahasiswaMenuItem,
            this.dataStatusMahasiswaToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.dataToolStripMenuItem.Text = "Data Master";
            // 
            // dataProdiToolStripMenuItem
            // 
            this.dataProdiToolStripMenuItem.Name = "dataProdiToolStripMenuItem";
            this.dataProdiToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.dataProdiToolStripMenuItem.Text = "Data Prodi";
            this.dataProdiToolStripMenuItem.Click += new System.EventHandler(this.dataProdiToolStripMenuItem_Click);
            // 
            // dataMahasiswaMenuItem
            // 
            this.dataMahasiswaMenuItem.Name = "dataMahasiswaMenuItem";
            this.dataMahasiswaMenuItem.Size = new System.Drawing.Size(244, 26);
            this.dataMahasiswaMenuItem.Text = "Data Mahasiswa";
            this.dataMahasiswaMenuItem.Click += new System.EventHandler(this.dataMahasiswaMenuItem_Click);
            // 
            // dataStatusMahasiswaToolStripMenuItem
            // 
            this.dataStatusMahasiswaToolStripMenuItem.Name = "dataStatusMahasiswaToolStripMenuItem";
            this.dataStatusMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.dataStatusMahasiswaToolStripMenuItem.Text = "Data Status Mahasiswa";
            this.dataStatusMahasiswaToolStripMenuItem.Click += new System.EventHandler(this.dataStatusMahasiswaToolStripMenuItem_Click);
            // 
            // DataMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DataMaster";
            this.Text = "Data Master";
            this.Load += new System.EventHandler(this.Data_Master_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataProdiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMahasiswaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataStatusMahasiswaToolStripMenuItem;
    }
}


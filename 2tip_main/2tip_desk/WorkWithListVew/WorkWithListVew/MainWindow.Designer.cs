﻿
namespace WorkWithListVew
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewGift = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbGifts = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAddNewGift);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.lbGifts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 600);
            this.panel1.TabIndex = 0;
            // 
            // btnAddNewGift
            // 
            this.btnAddNewGift.Location = new System.Drawing.Point(218, 89);
            this.btnAddNewGift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewGift.Name = "btnAddNewGift";
            this.btnAddNewGift.Size = new System.Drawing.Size(215, 36);
            this.btnAddNewGift.TabIndex = 2;
            this.btnAddNewGift.Text = "Dodaj Prezent";
            this.btnAddNewGift.UseVisualStyleBackColor = true;
            this.btnAddNewGift.Click += new System.EventHandler(this.btnAddNewGift_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(218, 27);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(215, 36);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Wczytaj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbGifts
            // 
            this.lbGifts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbGifts.FormattingEnabled = true;
            this.lbGifts.ItemHeight = 20;
            this.lbGifts.Location = new System.Drawing.Point(0, 0);
            this.lbGifts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbGifts.Name = "lbGifts";
            this.lbGifts.Size = new System.Drawing.Size(211, 600);
            this.lbGifts.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edytuj Prezent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Okno główne";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lbGifts;
        private System.Windows.Forms.Button btnAddNewGift;
        private System.Windows.Forms.Button button1;
    }
}


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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNewGift = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbGifts = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
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
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(217, 234);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(215, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Usuń Prezent";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(218, 165);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(215, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edytuj Prezent";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddNewGift
            // 
            this.btnAddNewGift.Enabled = false;
            this.btnAddNewGift.Location = new System.Drawing.Point(218, 96);
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
            this.lbGifts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbGifts_MouseDoubleClick);
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
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}


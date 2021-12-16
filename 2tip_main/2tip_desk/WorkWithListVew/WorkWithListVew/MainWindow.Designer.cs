
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbGifts = new System.Windows.Forms.ListBox();
            this.btnAddNewGift = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnAddNewGift);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.lbGifts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(191, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(188, 27);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Wczytaj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbGifts
            // 
            this.lbGifts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbGifts.FormattingEnabled = true;
            this.lbGifts.ItemHeight = 15;
            this.lbGifts.Location = new System.Drawing.Point(0, 0);
            this.lbGifts.Name = "lbGifts";
            this.lbGifts.Size = new System.Drawing.Size(185, 450);
            this.lbGifts.TabIndex = 0;
            // 
            // btnAddNewGift
            // 
            this.btnAddNewGift.Location = new System.Drawing.Point(191, 67);
            this.btnAddNewGift.Name = "btnAddNewGift";
            this.btnAddNewGift.Size = new System.Drawing.Size(188, 27);
            this.btnAddNewGift.TabIndex = 2;
            this.btnAddNewGift.Text = "Dodaj Prezent";
            this.btnAddNewGift.UseVisualStyleBackColor = true;
            this.btnAddNewGift.Click += new System.EventHandler(this.btnAddNewGift_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
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
    }
}


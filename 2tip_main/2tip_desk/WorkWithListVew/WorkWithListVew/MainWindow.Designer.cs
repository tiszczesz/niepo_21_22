
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNewGift = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbGifts = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvGifts = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.panel3);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(217, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 295);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Usuń Prezent";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edytuj Prezent";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 35);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Dodaj Prezent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lvGifts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(451, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 600);
            this.panel2.TabIndex = 1;
            // 
            // lvGifts
            // 
            this.lvGifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lvGifts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvGifts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGifts.FullRowSelect = true;
            this.lvGifts.GridLines = true;
            this.lvGifts.HideSelection = false;
            this.lvGifts.Location = new System.Drawing.Point(0, 0);
            this.lvGifts.Name = "lvGifts";
            this.lvGifts.Size = new System.Drawing.Size(773, 600);
            this.lvGifts.TabIndex = 0;
            this.lvGifts.UseCompatibleStateImageBehavior = false;
            this.lvGifts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lp";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cena";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Opis";
            this.columnHeader3.Width = 160;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Okno główne";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lbGifts;
        private System.Windows.Forms.Button btnAddNewGift;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvGifts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


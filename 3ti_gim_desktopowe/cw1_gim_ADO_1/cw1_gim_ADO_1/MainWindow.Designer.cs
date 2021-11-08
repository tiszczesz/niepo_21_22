
namespace cw1_gim_ADO_1
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.listAnimals = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbSpecies = new System.Windows.Forms.TextBox();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.btnLoad);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 371);
            this.panelMain.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(4, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(191, 48);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Załaduj Dane";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // listAnimals
            // 
            this.listAnimals.Dock = System.Windows.Forms.DockStyle.Left;
            this.listAnimals.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listAnimals.FormattingEnabled = true;
            this.listAnimals.HorizontalScrollbar = true;
            this.listAnimals.ItemHeight = 25;
            this.listAnimals.Location = new System.Drawing.Point(200, 0);
            this.listAnimals.Name = "listAnimals";
            this.listAnimals.Size = new System.Drawing.Size(292, 371);
            this.listAnimals.TabIndex = 1;
            this.listAnimals.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listAnimals_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gatunek:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(543, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(327, 23);
            this.tbName.TabIndex = 5;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(543, 67);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(327, 23);
            this.tbDescription.TabIndex = 6;
            // 
            // tbSpecies
            // 
            this.tbSpecies.Location = new System.Drawing.Point(543, 115);
            this.tbSpecies.Name = "tbSpecies";
            this.tbSpecies.Size = new System.Drawing.Size(327, 23);
            this.tbSpecies.TabIndex = 7;
            // 
            // picAnimal
            // 
            this.picAnimal.Location = new System.Drawing.Point(891, 13);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(396, 346);
            this.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnimal.TabIndex = 8;
            this.picAnimal.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 371);
            this.Controls.Add(this.picAnimal);
            this.Controls.Add(this.tbSpecies);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAnimals);
            this.Controls.Add(this.panelMain);
            this.Name = "MainWindow";
            this.Text = "Okno główne";
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox listAnimals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbSpecies;
        private System.Windows.Forms.PictureBox picAnimal;
    }
}


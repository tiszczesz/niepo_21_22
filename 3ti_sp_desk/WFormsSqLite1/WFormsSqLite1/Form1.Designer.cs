namespace WFormsSqLite1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddCake = new System.Windows.Forms.Button();
            this.comboBoxBsakery = new System.Windows.Forms.ComboBox();
            this.bakeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCakes = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCakes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonAddCake);
            this.panel1.Controls.Add(this.comboBoxBsakery);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 703);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Usuń ciastko";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddCake
            // 
            this.buttonAddCake.Location = new System.Drawing.Point(100, 322);
            this.buttonAddCake.Name = "buttonAddCake";
            this.buttonAddCake.Size = new System.Drawing.Size(161, 23);
            this.buttonAddCake.TabIndex = 8;
            this.buttonAddCake.Text = "Dodaj ciastko";
            this.buttonAddCake.UseVisualStyleBackColor = true;
            this.buttonAddCake.Click += new System.EventHandler(this.buttonAddCake_Click);
            // 
            // comboBoxBsakery
            // 
            this.comboBoxBsakery.DataSource = this.bakeryBindingSource;
            this.comboBoxBsakery.DisplayMember = "Name";
            this.comboBoxBsakery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBsakery.FormattingEnabled = true;
            this.comboBoxBsakery.Location = new System.Drawing.Point(102, 273);
            this.comboBoxBsakery.Name = "comboBoxBsakery";
            this.comboBoxBsakery.Size = new System.Drawing.Size(159, 23);
            this.comboBoxBsakery.TabIndex = 7;
            this.comboBoxBsakery.ValueMember = "BakeryId";
            // 
            // bakeryBindingSource
            // 
            this.bakeryBindingSource.DataSource = typeof(WFormsSqLite1.Models.Bakery);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(100, 150);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(161, 94);
            this.textBoxDescription.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(100, 98);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(161, 23);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 46);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 23);
            this.textBoxName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Piekarnia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCakes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(284, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 703);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewCakes
            // 
            this.dataGridViewCakes.AllowUserToAddRows = false;
            this.dataGridViewCakes.AllowUserToDeleteRows = false;
            this.dataGridViewCakes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCakes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCakes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCakes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCakes.MultiSelect = false;
            this.dataGridViewCakes.Name = "dataGridViewCakes";
            this.dataGridViewCakes.ReadOnly = true;
            this.dataGridViewCakes.RowTemplate.Height = 25;
            this.dataGridViewCakes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCakes.Size = new System.Drawing.Size(811, 703);
            this.dataGridViewCakes.TabIndex = 0;
            this.dataGridViewCakes.DoubleClick += new System.EventHandler(this.dataGridViewCakes_DoubleClick);
            this.dataGridViewCakes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCakes_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 102);
            this.button2.TabIndex = 10;
            this.button2.Text = "Zarzadzaj piekarniami";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCakes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewCakes;
        private ComboBox comboBoxBsakery;
        private BindingSource bakeryBindingSource;
        private TextBox textBoxDescription;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonAddCake;
        private Button button1;
        private Button button2;
    }
}
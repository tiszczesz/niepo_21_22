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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCakes = new System.Windows.Forms.DataGridView();
            this.cakesWithBakeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDbContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakesWithBakeryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDbContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 703);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCakes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 703);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewCakes
            // 
            this.dataGridViewCakes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCakes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCakes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCakes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCakes.MultiSelect = false;
            this.dataGridViewCakes.Name = "dataGridViewCakes";
            this.dataGridViewCakes.RowTemplate.Height = 25;
            this.dataGridViewCakes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCakes.Size = new System.Drawing.Size(895, 703);
            this.dataGridViewCakes.TabIndex = 0;
            this.dataGridViewCakes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCakes_MouseDoubleClick);
            // 
            // cakesWithBakeryBindingSource
            // 
            this.cakesWithBakeryBindingSource.DataSource = typeof(WFormsSqLite1.ViewModel.CakesWithBakery);
            // 
            // appDbContextBindingSource
            // 
            this.appDbContextBindingSource.DataSource = typeof(WFormsSqLite1.Data.AppDbContext);
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakesWithBakeryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDbContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewCakes;
        private BindingSource appDbContextBindingSource;
        private BindingSource cakesWithBakeryBindingSource;
    }
}
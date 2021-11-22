
namespace WinFormsFramework_gim
{
    partial class DetailsWindow
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
            this.components = new System.ComponentModel.Container();
            this.animalsDBDataSet = new WinFormsFramework_gim.AnimalsDBDataSet();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsTableAdapter = new WinFormsFramework_gim.AnimalsDBDataSetTableAdapters.AnimalsTableAdapter();
            this.tableAdapterManager = new WinFormsFramework_gim.AnimalsDBDataSetTableAdapters.TableAdapterManager();
            this.speciesTableAdapter = new WinFormsFramework_gim.AnimalsDBDataSetTableAdapters.SpeciesTableAdapter();
            this.speciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.animalsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // animalsDBDataSet
            // 
            this.animalsDBDataSet.DataSetName = "AnimalsDBDataSet";
            this.animalsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "Animals";
            this.animalsBindingSource.DataSource = this.animalsDBDataSet;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalsTableAdapter = this.animalsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SpeciesTableAdapter = this.speciesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WinFormsFramework_gim.AnimalsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // speciesTableAdapter
            // 
            this.speciesTableAdapter.ClearBeforeFill = true;
            // 
            // speciesBindingSource
            // 
            this.speciesBindingSource.DataMember = "Species";
            this.speciesBindingSource.DataSource = this.animalsDBDataSet;
            // 
            // DetailsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DetailsWindow";
            this.Text = "DetailsWindow";
            this.Load += new System.EventHandler(this.DetailsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AnimalsDBDataSet animalsDBDataSet;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private AnimalsDBDataSetTableAdapters.AnimalsTableAdapter animalsTableAdapter;
        private AnimalsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AnimalsDBDataSetTableAdapters.SpeciesTableAdapter speciesTableAdapter;
        private System.Windows.Forms.BindingSource speciesBindingSource;
    }
}
namespace FileManager
{
    partial class MostrarFicheros
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Procesar = new System.Windows.Forms.Button();
            this.Filtro = new System.Windows.Forms.TextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.chequeaSubcarpetas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chequeaSubcarpetas);
            this.splitContainer1.Panel1.Controls.Add(this.Procesar);
            this.splitContainer1.Panel1.Controls.Add(this.Filtro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // Procesar
            // 
            this.Procesar.Location = new System.Drawing.Point(0, 0);
            this.Procesar.Name = "Procesar";
            this.Procesar.Size = new System.Drawing.Size(75, 23);
            this.Procesar.TabIndex = 1;
            this.Procesar.Text = "Procesar";
            this.Procesar.UseVisualStyleBackColor = true;
            this.Procesar.Click += new System.EventHandler(this.Procesar_Click);
            // 
            // Filtro
            // 
            this.Filtro.Location = new System.Drawing.Point(12, 51);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(239, 20);
            this.Filtro.TabIndex = 0;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToOrderColumns = true;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.Size = new System.Drawing.Size(530, 450);
            this.GridView.TabIndex = 0;
            // 
            // chequeaSubcarpetas
            // 
            this.chequeaSubcarpetas.AutoSize = true;
            this.chequeaSubcarpetas.Checked = true;
            this.chequeaSubcarpetas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chequeaSubcarpetas.Location = new System.Drawing.Point(12, 77);
            this.chequeaSubcarpetas.Name = "chequeaSubcarpetas";
            this.chequeaSubcarpetas.Size = new System.Drawing.Size(86, 17);
            this.chequeaSubcarpetas.TabIndex = 2;
            this.chequeaSubcarpetas.Text = "Subcarpetas";
            this.chequeaSubcarpetas.UseVisualStyleBackColor = true;
            // 
            // MostrarFicheros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MostrarFicheros";
            this.Text = "MostrarFicheros";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button Procesar;
        private System.Windows.Forms.TextBox Filtro;
        private System.Windows.Forms.CheckBox chequeaSubcarpetas;
    }
}
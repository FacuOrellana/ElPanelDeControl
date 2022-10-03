namespace ElPanelDeControl.Formularios.Vistas
{
    partial class HistorialLecturasVista
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvLecturas = new System.Windows.Forms.DataGridView();
            this.lecturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CalderaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvLecturas, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 397);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvLecturas
            // 
            this.dgvLecturas.AutoGenerateColumns = false;
            this.dgvLecturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CalderaId,
            this.fechaDataGridViewTextBoxColumn,
            this.Temperatura,
            this.nivelDataGridViewTextBoxColumn});
            this.dgvLecturas.DataSource = this.lecturaBindingSource;
            this.dgvLecturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLecturas.Location = new System.Drawing.Point(3, 3);
            this.dgvLecturas.Name = "dgvLecturas";
            this.dgvLecturas.Size = new System.Drawing.Size(544, 391);
            this.dgvLecturas.TabIndex = 0;
            // 
            // lecturaBindingSource
            // 
            this.lecturaBindingSource.DataSource = typeof(ElPanelDeControl.Dominio.Entidades.Lectura);
            // 
            // CalderaId
            // 
            this.CalderaId.DataPropertyName = "CalderaId";
            this.CalderaId.HeaderText = "Caldera";
            this.CalderaId.Name = "CalderaId";
            this.CalderaId.Width = 68;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fechaDataGridViewTextBoxColumn.Width = 130;
            // 
            // Temperatura
            // 
            this.Temperatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Temperatura.DataPropertyName = "Temperatura";
            this.Temperatura.HeaderText = "Temperatura";
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.ReadOnly = true;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.Width = 56;
            // 
            // HistorialLecturasVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 397);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HistorialLecturasVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Historico de Lecturas";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvLecturas;
        private System.Windows.Forms.BindingSource lecturaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn calderaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalderaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
    }
}
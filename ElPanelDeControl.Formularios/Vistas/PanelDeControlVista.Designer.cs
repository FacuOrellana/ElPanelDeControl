namespace ElPanelDeControl.Formularios.Vistas
{
    partial class PanelDeControlVista
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
            this.lblcalderaN = new System.Windows.Forms.Label();
            this.lblNumeroCaldera = new System.Windows.Forms.Label();
            this.lblTActual = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnVerLecturas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcalderaN
            // 
            this.lblcalderaN.AutoSize = true;
            this.lblcalderaN.Location = new System.Drawing.Point(13, 13);
            this.lblcalderaN.Name = "lblcalderaN";
            this.lblcalderaN.Size = new System.Drawing.Size(61, 13);
            this.lblcalderaN.TabIndex = 0;
            this.lblcalderaN.Text = "Caldera N°:";
            // 
            // lblNumeroCaldera
            // 
            this.lblNumeroCaldera.AutoSize = true;
            this.lblNumeroCaldera.Location = new System.Drawing.Point(80, 13);
            this.lblNumeroCaldera.Name = "lblNumeroCaldera";
            this.lblNumeroCaldera.Size = new System.Drawing.Size(19, 13);
            this.lblNumeroCaldera.TabIndex = 1;
            this.lblNumeroCaldera.Text = "00";
            // 
            // lblTActual
            // 
            this.lblTActual.AutoSize = true;
            this.lblTActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTActual.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTActual.Location = new System.Drawing.Point(140, 63);
            this.lblTActual.Name = "lblTActual";
            this.lblTActual.Size = new System.Drawing.Size(203, 22);
            this.lblTActual.TabIndex = 2;
            this.lblTActual.Text = "Temperatura Actual [C°]";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTemperatura.Location = new System.Drawing.Point(201, 110);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(80, 37);
            this.lblTemperatura.TabIndex = 3;
            this.lblTemperatura.Text = "00.0";
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.Blue;
            this.ColorPanel.Location = new System.Drawing.Point(144, 160);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(199, 49);
            this.ColorPanel.TabIndex = 4;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(34, 263);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(86, 33);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnVerLecturas
            // 
            this.btnVerLecturas.Location = new System.Drawing.Point(208, 263);
            this.btnVerLecturas.Name = "btnVerLecturas";
            this.btnVerLecturas.Size = new System.Drawing.Size(91, 33);
            this.btnVerLecturas.TabIndex = 6;
            this.btnVerLecturas.Text = "Ver Lecturas";
            this.btnVerLecturas.UseVisualStyleBackColor = true;
            this.btnVerLecturas.Click += new System.EventHandler(this.VerLecturas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(376, 263);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 33);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PanelDeControlVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 308);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerLecturas);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblTActual);
            this.Controls.Add(this.lblNumeroCaldera);
            this.Controls.Add(this.lblcalderaN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelDeControlVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcalderaN;
        private System.Windows.Forms.Label lblNumeroCaldera;
        private System.Windows.Forms.Label lblTActual;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnVerLecturas;
        private System.Windows.Forms.Button btnSalir;
    }
}

namespace PPAI_DSI_Grupo5.Presentacion.Transacciones
{
    partial class RegistrarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarTurno));
            this.lblFuncion = new System.Windows.Forms.Label();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.dgrEventos = new System.Windows.Forms.DataGridView();
            this.nroContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F);
            this.lblFuncion.Location = new System.Drawing.Point(42, 121);
            this.lblFuncion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(192, 31);
            this.lblFuncion.TabIndex = 29;
            this.lblFuncion.Text = "Tipo de recurso:";
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.Location = new System.Drawing.Point(282, 128);
            this.cmbFuncion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(281, 24);
            this.cmbFuncion.TabIndex = 28;
            // 
            // dgrEventos
            // 
            this.dgrEventos.AllowUserToAddRows = false;
            this.dgrEventos.AllowUserToDeleteRows = false;
            this.dgrEventos.AllowUserToOrderColumns = true;
            this.dgrEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroContrato,
            this.codigoCombo,
            this.calle,
            this.nroCalle,
            this.Modelo,
            this.Estado});
            this.dgrEventos.Location = new System.Drawing.Point(48, 214);
            this.dgrEventos.Margin = new System.Windows.Forms.Padding(4);
            this.dgrEventos.Name = "dgrEventos";
            this.dgrEventos.ReadOnly = true;
            this.dgrEventos.RowHeadersWidth = 51;
            this.dgrEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrEventos.Size = new System.Drawing.Size(923, 338);
            this.dgrEventos.TabIndex = 27;
            // 
            // nroContrato
            // 
            this.nroContrato.DataPropertyName = "nroContrato";
            this.nroContrato.HeaderText = "Recurso";
            this.nroContrato.MinimumWidth = 6;
            this.nroContrato.Name = "nroContrato";
            this.nroContrato.ReadOnly = true;
            this.nroContrato.Width = 170;
            // 
            // codigoCombo
            // 
            this.codigoCombo.DataPropertyName = "codigoCombo";
            this.codigoCombo.HeaderText = "Centro de Investigación";
            this.codigoCombo.MinimumWidth = 6;
            this.codigoCombo.Name = "codigoCombo";
            this.codigoCombo.ReadOnly = true;
            this.codigoCombo.Width = 220;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Núm. Inventario";
            this.calle.MinimumWidth = 6;
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Width = 80;
            // 
            // nroCalle
            // 
            this.nroCalle.DataPropertyName = "nroCalle";
            this.nroCalle.HeaderText = "Marca";
            this.nroCalle.MinimumWidth = 6;
            this.nroCalle.Name = "nroCalle";
            this.nroCalle.ReadOnly = true;
            this.nroCalle.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 150;
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(46, 168);
            this.lblEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(410, 31);
            this.lblEvento.TabIndex = 26;
            this.lblEvento.Text = "Seleccióne un recursos Tecnológico:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft YaHei Light", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(40, 42);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(611, 45);
            this.lblTurno.TabIndex = 25;
            this.lblTurno.Text = "Reservar turno de recurso tecnológico";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(771, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // RegistrarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1021, 608);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.cmbFuncion);
            this.Controls.Add(this.dgrEventos);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.lblTurno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarTurno";
            this.Text = "Secretaría de Ciencia y Técnica - Registrar nuevo turno";
            ((System.ComponentModel.ISupportInitialize)(this.dgrEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.DataGridView dgrEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
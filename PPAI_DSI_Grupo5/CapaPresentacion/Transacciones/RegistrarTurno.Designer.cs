
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
            this.cmbTipoRecurso = new System.Windows.Forms.ComboBox();
            this.dgrRecursos = new System.Windows.Forms.DataGridView();
            this.lblSeleccioneRecurso = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.dateTimePickerTurno = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F);
            this.lblFuncion.Location = new System.Drawing.Point(42, 117);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(154, 25);
            this.lblFuncion.TabIndex = 29;
            this.lblFuncion.Text = "Tipo de recurso:";
            // 
            // cmbTipoRecurso
            // 
            this.cmbTipoRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRecurso.FormattingEnabled = true;
            this.cmbTipoRecurso.Location = new System.Drawing.Point(222, 123);
            this.cmbTipoRecurso.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoRecurso.Name = "cmbTipoRecurso";
            this.cmbTipoRecurso.Size = new System.Drawing.Size(212, 21);
            this.cmbTipoRecurso.TabIndex = 28;
            this.cmbTipoRecurso.SelectedIndexChanged += new System.EventHandler(this.cmbTipoRecurso_SelectedIndexChanged);
            // 
            // dgrRecursos
            // 
            this.dgrRecursos.AllowUserToAddRows = false;
            this.dgrRecursos.AllowUserToDeleteRows = false;
            this.dgrRecursos.AllowUserToResizeColumns = false;
            this.dgrRecursos.AllowUserToResizeRows = false;
            this.dgrRecursos.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgrRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calle,
            this.codigoCombo,
            this.nroCalle,
            this.Modelo,
            this.Estado});
            this.dgrRecursos.Location = new System.Drawing.Point(46, 206);
            this.dgrRecursos.Name = "dgrRecursos";
            this.dgrRecursos.ReadOnly = true;
            this.dgrRecursos.RowHeadersVisible = false;
            this.dgrRecursos.RowHeadersWidth = 51;
            this.dgrRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrRecursos.Size = new System.Drawing.Size(814, 355);
            this.dgrRecursos.TabIndex = 27;
            // 
            // lblSeleccioneRecurso
            // 
            this.lblSeleccioneRecurso.AutoSize = true;
            this.lblSeleccioneRecurso.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneRecurso.Location = new System.Drawing.Point(45, 169);
            this.lblSeleccioneRecurso.Name = "lblSeleccioneRecurso";
            this.lblSeleccioneRecurso.Size = new System.Drawing.Size(324, 25);
            this.lblSeleccioneRecurso.TabIndex = 26;
            this.lblSeleccioneRecurso.Text = "Seleccióne un recursos Tecnológico:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft YaHei Light", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(40, 44);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(482, 35);
            this.lblTurno.TabIndex = 25;
            this.lblTurno.Text = "Reservar turno de recurso tecnológico";
            // 
            // dateTimePickerTurno
            // 
            this.dateTimePickerTurno.Enabled = false;
            this.dateTimePickerTurno.Location = new System.Drawing.Point(659, 77);
            this.dateTimePickerTurno.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTurno.Name = "dateTimePickerTurno";
            this.dateTimePickerTurno.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerTurno.TabIndex = 30;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(717, 581);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(143, 38);
            this.btnReservar.TabIndex = 31;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(46, 581);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 38);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // calle
            // 
            this.calle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Núm. Inventario";
            this.calle.MinimumWidth = 6;
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // codigoCombo
            // 
            this.codigoCombo.DataPropertyName = "codigoCombo";
            this.codigoCombo.HeaderText = "Centro de Investigación";
            this.codigoCombo.MinimumWidth = 6;
            this.codigoCombo.Name = "codigoCombo";
            this.codigoCombo.ReadOnly = true;
            this.codigoCombo.Width = 240;
            // 
            // nroCalle
            // 
            this.nroCalle.DataPropertyName = "nroCalle";
            this.nroCalle.HeaderText = "Marca";
            this.nroCalle.MinimumWidth = 6;
            this.nroCalle.Name = "nroCalle";
            this.nroCalle.ReadOnly = true;
            this.nroCalle.Width = 140;
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
            // RegistrarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(908, 645);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dateTimePickerTurno);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.cmbTipoRecurso);
            this.Controls.Add(this.dgrRecursos);
            this.Controls.Add(this.lblSeleccioneRecurso);
            this.Controls.Add(this.lblTurno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RegistrarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaría de Ciencia y Técnica - Registrar nuevo turno";
            ((System.ComponentModel.ISupportInitialize)(this.dgrRecursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.ComboBox cmbTipoRecurso;
        private System.Windows.Forms.DataGridView dgrRecursos;
        private System.Windows.Forms.Label lblSeleccioneRecurso;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.DateTimePicker dateTimePickerTurno;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
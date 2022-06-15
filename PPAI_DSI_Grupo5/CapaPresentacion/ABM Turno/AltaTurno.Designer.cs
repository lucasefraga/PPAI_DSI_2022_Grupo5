
namespace PPAI_DSI_Grupo5.Presentacion.ABM_Turno
{
    partial class AltaTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaTurno));
            this.lblTurno = new System.Windows.Forms.Label();
            this.txtTipoRecurso = new System.Windows.Forms.TextBox();
            this.lblTipoRecurso = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtRecurso = new System.Windows.Forms.TextBox();
            this.lblRecurso = new System.Windows.Forms.Label();
            this.txtCentro = new System.Windows.Forms.TextBox();
            this.lblCentroPertenencia = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblFechaIngresoEmp = new System.Windows.Forms.Label();
            this.lblNumInventario = new System.Windows.Forms.Label();
            this.txtNumInv = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxWP = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calendario = new Pabo.Calendar.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft YaHei Light", 22F, System.Drawing.FontStyle.Italic);
            this.lblTurno.Location = new System.Drawing.Point(25, 22);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(195, 39);
            this.lblTurno.TabIndex = 19;
            this.lblTurno.Text = "Nuevo Turno";
            // 
            // txtTipoRecurso
            // 
            this.txtTipoRecurso.Enabled = false;
            this.txtTipoRecurso.Location = new System.Drawing.Point(330, 30);
            this.txtTipoRecurso.Margin = new System.Windows.Forms.Padding(6);
            this.txtTipoRecurso.Name = "txtTipoRecurso";
            this.txtTipoRecurso.Size = new System.Drawing.Size(397, 21);
            this.txtTipoRecurso.TabIndex = 1;
            // 
            // lblTipoRecurso
            // 
            this.lblTipoRecurso.AutoSize = true;
            this.lblTipoRecurso.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRecurso.Location = new System.Drawing.Point(85, 30);
            this.lblTipoRecurso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTipoRecurso.Name = "lblTipoRecurso";
            this.lblTipoRecurso.Size = new System.Drawing.Size(109, 20);
            this.lblTipoRecurso.TabIndex = 5;
            this.lblTipoRecurso.Text = "Tipo Recurso:";
            // 
            // btnAlta
            // 
            this.btnAlta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlta.Location = new System.Drawing.Point(1104, 628);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(6);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(191, 47);
            this.btnAlta.TabIndex = 8;
            this.btnAlta.Text = "Confirmar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(775, 628);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(191, 47);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtRecurso
            // 
            this.txtRecurso.Enabled = false;
            this.txtRecurso.Location = new System.Drawing.Point(330, 80);
            this.txtRecurso.Margin = new System.Windows.Forms.Padding(6);
            this.txtRecurso.Name = "txtRecurso";
            this.txtRecurso.Size = new System.Drawing.Size(397, 21);
            this.txtRecurso.TabIndex = 2;
            // 
            // lblRecurso
            // 
            this.lblRecurso.AutoSize = true;
            this.lblRecurso.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecurso.Location = new System.Drawing.Point(85, 80);
            this.lblRecurso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRecurso.Name = "lblRecurso";
            this.lblRecurso.Size = new System.Drawing.Size(72, 20);
            this.lblRecurso.TabIndex = 11;
            this.lblRecurso.Text = "Recurso:";
            // 
            // txtCentro
            // 
            this.txtCentro.Enabled = false;
            this.txtCentro.Location = new System.Drawing.Point(330, 135);
            this.txtCentro.Margin = new System.Windows.Forms.Padding(6);
            this.txtCentro.Name = "txtCentro";
            this.txtCentro.Size = new System.Drawing.Size(397, 21);
            this.txtCentro.TabIndex = 3;
            // 
            // lblCentroPertenencia
            // 
            this.lblCentroPertenencia.AutoSize = true;
            this.lblCentroPertenencia.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroPertenencia.Location = new System.Drawing.Point(83, 135);
            this.lblCentroPertenencia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCentroPertenencia.Name = "lblCentroPertenencia";
            this.lblCentroPertenencia.Size = new System.Drawing.Size(176, 20);
            this.lblCentroPertenencia.TabIndex = 13;
            this.lblCentroPertenencia.Text = "Centro de Pertenencia:";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(332, 243);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(6);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(397, 21);
            this.txtMarca.TabIndex = 6;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(85, 243);
            this.lblNroDoc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(58, 20);
            this.lblNroDoc.TabIndex = 15;
            this.lblNroDoc.Text = "Marca:";
            // 
            // lblFechaIngresoEmp
            // 
            this.lblFechaIngresoEmp.AutoSize = true;
            this.lblFechaIngresoEmp.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngresoEmp.Location = new System.Drawing.Point(87, 394);
            this.lblFechaIngresoEmp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaIngresoEmp.Name = "lblFechaIngresoEmp";
            this.lblFechaIngresoEmp.Size = new System.Drawing.Size(155, 20);
            this.lblFechaIngresoEmp.TabIndex = 18;
            this.lblFechaIngresoEmp.Text = "Fecha Selecciónada:";
            // 
            // lblNumInventario
            // 
            this.lblNumInventario.AutoSize = true;
            this.lblNumInventario.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInventario.Location = new System.Drawing.Point(85, 190);
            this.lblNumInventario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumInventario.Name = "lblNumInventario";
            this.lblNumInventario.Size = new System.Drawing.Size(173, 20);
            this.lblNumInventario.TabIndex = 20;
            this.lblNumInventario.Text = "Número de Inventario:";
            // 
            // txtNumInv
            // 
            this.txtNumInv.Enabled = false;
            this.txtNumInv.Location = new System.Drawing.Point(330, 190);
            this.txtNumInv.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumInv.Name = "txtNumInv";
            this.txtNumInv.Size = new System.Drawing.Size(397, 21);
            this.txtNumInv.TabIndex = 24;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(332, 299);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(6);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(397, 21);
            this.txtModelo.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Modelo:";
            // 
            // textEstado
            // 
            this.textEstado.Enabled = false;
            this.textEstado.Location = new System.Drawing.Point(332, 352);
            this.textEstado.Margin = new System.Windows.Forms.Padding(6);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(397, 21);
            this.textEstado.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Estado:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxEmail);
            this.panel2.Controls.Add(this.checkBoxWP);
            this.panel2.Location = new System.Drawing.Point(331, 586);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 33);
            this.panel2.TabIndex = 31;
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(15, 6);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(52, 20);
            this.checkBoxEmail.TabIndex = 29;
            this.checkBoxEmail.Text = "Email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // checkBoxWP
            // 
            this.checkBoxWP.AutoSize = true;
            this.checkBoxWP.Location = new System.Drawing.Point(181, 5);
            this.checkBoxWP.Name = "checkBoxWP";
            this.checkBoxWP.Size = new System.Drawing.Size(81, 20);
            this.checkBoxWP.TabIndex = 30;
            this.checkBoxWP.Text = "Whatsapp ";
            this.checkBoxWP.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 591);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Medio de notificación:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.calendario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvTurnos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textEstado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Controls.Add(this.txtNumInv);
            this.panel1.Controls.Add(this.lblNumInventario);
            this.panel1.Controls.Add(this.lblFechaIngresoEmp);
            this.panel1.Controls.Add(this.lblNroDoc);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.lblCentroPertenencia);
            this.panel1.Controls.Add(this.txtCentro);
            this.panel1.Controls.Add(this.lblRecurso);
            this.panel1.Controls.Add(this.txtRecurso);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Controls.Add(this.lblTipoRecurso);
            this.panel1.Controls.Add(this.txtTipoRecurso);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(33, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 703);
            this.panel1.TabIndex = 20;
            // 
            // calendario
            // 
            this.calendario.ActiveMonth.Month = 6;
            this.calendario.ActiveMonth.Year = 2022;
            this.calendario.Culture = new System.Globalization.CultureInfo("en-US");
            this.calendario.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.calendario.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.calendario.Header.TextColor = System.Drawing.Color.White;
            this.calendario.ImageList = null;
            this.calendario.Location = new System.Drawing.Point(332, 383);
            this.calendario.MaxDate = new System.DateTime(2032, 6, 15, 10, 45, 41, 105);
            this.calendario.MinDate = new System.DateTime(2012, 6, 15, 10, 45, 41, 105);
            this.calendario.Month.BackgroundImage = null;
            this.calendario.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(276, 184);
            this.calendario.TabIndex = 37;
            this.calendario.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.DayClick += new Pabo.Calendar.DayClickEventHandler(this.calendar_DayClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(771, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Turnos Disponibles:";
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AllowUserToAddRows = false;
            this.dgvTurnos.AllowUserToDeleteRows = false;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.HoraInicio,
            this.HoraFin,
            this.Estado});
            this.dgvTurnos.Location = new System.Drawing.Point(775, 80);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ReadOnly = true;
            this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnos.Size = new System.Drawing.Size(520, 487);
            this.dgvTurnos.TabIndex = 35;
            this.dgvTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 120;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Width = 110;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Width = 110;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 130;
            // 
            // AltaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1388, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTurno);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "AltaTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.TextBox txtTipoRecurso;
        private System.Windows.Forms.Label lblTipoRecurso;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtRecurso;
        private System.Windows.Forms.Label lblRecurso;
        private System.Windows.Forms.TextBox txtCentro;
        private System.Windows.Forms.Label lblCentroPertenencia;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblFechaIngresoEmp;
        private System.Windows.Forms.Label lblNumInventario;
        private System.Windows.Forms.TextBox txtNumInv;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.CheckBox checkBoxWP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private Pabo.Calendar.MonthCalendar calendario;
    }
}
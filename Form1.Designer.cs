﻿namespace pryMarconiPRUEBAiefiSemestre2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabRegistro = new System.Windows.Forms.TabControl();
            this.Socios = new System.Windows.Forms.TabPage();
            this.numIngreso = new System.Windows.Forms.NumericUpDown();
            this.numPuntaje = new System.Windows.Forms.NumericUpDown();
            this.lblNombreSocio = new System.Windows.Forms.Label();
            this.btnRegistrarSocio = new System.Windows.Forms.Button();
            this.mrcSexo = new System.Windows.Forms.GroupBox();
            this.optMasculino = new System.Windows.Forms.RadioButton();
            this.optFemenino = new System.Windows.Forms.RadioButton();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.Paises = new System.Windows.Forms.TabPage();
            this.btnRegistrarPais = new System.Windows.Forms.Button();
            this.lblNombrePais = new System.Windows.Forms.Label();
            this.txtNombrePais = new System.Windows.Forms.TextBox();
            this.tabRegistro.SuspendLayout();
            this.Socios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPuntaje)).BeginInit();
            this.mrcSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.Paises.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.Socios);
            this.tabRegistro.Controls.Add(this.Paises);
            this.tabRegistro.Location = new System.Drawing.Point(12, 12);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.SelectedIndex = 0;
            this.tabRegistro.Size = new System.Drawing.Size(357, 215);
            this.tabRegistro.TabIndex = 1;
            // 
            // Socios
            // 
            this.Socios.Controls.Add(this.numIngreso);
            this.Socios.Controls.Add(this.numPuntaje);
            this.Socios.Controls.Add(this.lblNombreSocio);
            this.Socios.Controls.Add(this.btnRegistrarSocio);
            this.Socios.Controls.Add(this.mrcSexo);
            this.Socios.Controls.Add(this.lblPuntaje);
            this.Socios.Controls.Add(this.txtNombreSocio);
            this.Socios.Controls.Add(this.cmbPais);
            this.Socios.Controls.Add(this.lblIngreso);
            this.Socios.Controls.Add(this.numEdad);
            this.Socios.Controls.Add(this.lblEdad);
            this.Socios.Controls.Add(this.txtApellido);
            this.Socios.Controls.Add(this.lblPais);
            this.Socios.Controls.Add(this.lblApellido);
            this.Socios.Location = new System.Drawing.Point(4, 22);
            this.Socios.Name = "Socios";
            this.Socios.Padding = new System.Windows.Forms.Padding(3);
            this.Socios.Size = new System.Drawing.Size(349, 189);
            this.Socios.TabIndex = 0;
            this.Socios.Text = "Socios";
            this.Socios.UseVisualStyleBackColor = true;
            // 
            // numIngreso
            // 
            this.numIngreso.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIngreso.Location = new System.Drawing.Point(68, 127);
            this.numIngreso.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numIngreso.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIngreso.Name = "numIngreso";
            this.numIngreso.Size = new System.Drawing.Size(100, 20);
            this.numIngreso.TabIndex = 4;
            this.numIngreso.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numPuntaje
            // 
            this.numPuntaje.DecimalPlaces = 1;
            this.numPuntaje.Location = new System.Drawing.Point(68, 158);
            this.numPuntaje.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numPuntaje.Minimum = new decimal(new int[] {
            1295,
            0,
            0,
            65536});
            this.numPuntaje.Name = "numPuntaje";
            this.numPuntaje.Size = new System.Drawing.Size(63, 20);
            this.numPuntaje.TabIndex = 5;
            this.numPuntaje.Value = new decimal(new int[] {
            1295,
            0,
            0,
            65536});
            // 
            // lblNombreSocio
            // 
            this.lblNombreSocio.AutoSize = true;
            this.lblNombreSocio.Location = new System.Drawing.Point(18, 12);
            this.lblNombreSocio.Name = "lblNombreSocio";
            this.lblNombreSocio.Size = new System.Drawing.Size(44, 13);
            this.lblNombreSocio.TabIndex = 7;
            this.lblNombreSocio.Text = "Nombre";
            // 
            // btnRegistrarSocio
            // 
            this.btnRegistrarSocio.Location = new System.Drawing.Point(201, 76);
            this.btnRegistrarSocio.Name = "btnRegistrarSocio";
            this.btnRegistrarSocio.Size = new System.Drawing.Size(130, 102);
            this.btnRegistrarSocio.TabIndex = 6;
            this.btnRegistrarSocio.Text = "Registrar";
            this.btnRegistrarSocio.UseVisualStyleBackColor = true;
            this.btnRegistrarSocio.Click += new System.EventHandler(this.btnRegistrarSocio_Click);
            // 
            // mrcSexo
            // 
            this.mrcSexo.Controls.Add(this.optMasculino);
            this.mrcSexo.Controls.Add(this.optFemenino);
            this.mrcSexo.Location = new System.Drawing.Point(21, 76);
            this.mrcSexo.Name = "mrcSexo";
            this.mrcSexo.Size = new System.Drawing.Size(162, 48);
            this.mrcSexo.TabIndex = 16;
            this.mrcSexo.TabStop = false;
            this.mrcSexo.Text = "Sexo";
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Checked = true;
            this.optMasculino.Location = new System.Drawing.Point(6, 19);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(73, 17);
            this.optMasculino.TabIndex = 0;
            this.optMasculino.TabStop = true;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseVisualStyleBackColor = true;
            // 
            // optFemenino
            // 
            this.optFemenino.AutoSize = true;
            this.optFemenino.Location = new System.Drawing.Point(85, 19);
            this.optFemenino.Name = "optFemenino";
            this.optFemenino.Size = new System.Drawing.Size(71, 17);
            this.optFemenino.TabIndex = 1;
            this.optFemenino.Text = "Femenino";
            this.optFemenino.UseVisualStyleBackColor = true;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(19, 158);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(43, 13);
            this.lblPuntaje.TabIndex = 15;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(66, 12);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSocio.TabIndex = 0;
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(231, 38);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(100, 21);
            this.cmbPais.TabIndex = 2;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(20, 127);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblIngreso.TabIndex = 13;
            this.lblIngreso.Text = "Ingreso";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(66, 41);
            this.numEdad.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numEdad.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(47, 20);
            this.numEdad.TabIndex = 3;
            this.numEdad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(18, 41);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 11;
            this.lblEdad.Text = "Edad";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(231, 12);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(181, 41);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 10;
            this.lblPais.Text = "País";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(181, 15);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // Paises
            // 
            this.Paises.Controls.Add(this.btnRegistrarPais);
            this.Paises.Controls.Add(this.lblNombrePais);
            this.Paises.Controls.Add(this.txtNombrePais);
            this.Paises.Location = new System.Drawing.Point(4, 22);
            this.Paises.Name = "Paises";
            this.Paises.Padding = new System.Windows.Forms.Padding(3);
            this.Paises.Size = new System.Drawing.Size(353, 257);
            this.Paises.TabIndex = 1;
            this.Paises.Text = "Países";
            this.Paises.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPais
            // 
            this.btnRegistrarPais.Location = new System.Drawing.Point(272, 228);
            this.btnRegistrarPais.Name = "btnRegistrarPais";
            this.btnRegistrarPais.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarPais.TabIndex = 1;
            this.btnRegistrarPais.Text = "Registrar";
            this.btnRegistrarPais.UseVisualStyleBackColor = true;
            this.btnRegistrarPais.Click += new System.EventHandler(this.btnRegistrarPais_Click);
            // 
            // lblNombrePais
            // 
            this.lblNombrePais.AutoSize = true;
            this.lblNombrePais.Location = new System.Drawing.Point(16, 15);
            this.lblNombrePais.Name = "lblNombrePais";
            this.lblNombrePais.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePais.TabIndex = 9;
            this.lblNombrePais.Text = "Nombre";
            // 
            // txtNombrePais
            // 
            this.txtNombrePais.Location = new System.Drawing.Point(66, 12);
            this.txtNombrePais.Name = "txtNombrePais";
            this.txtNombrePais.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePais.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 229);
            this.Controls.Add(this.tabRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabRegistro.ResumeLayout(false);
            this.Socios.ResumeLayout(false);
            this.Socios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPuntaje)).EndInit();
            this.mrcSexo.ResumeLayout(false);
            this.mrcSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.Paises.ResumeLayout(false);
            this.Paises.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRegistro;
        private System.Windows.Forms.TabPage Socios;
        private System.Windows.Forms.NumericUpDown numIngreso;
        private System.Windows.Forms.NumericUpDown numPuntaje;
        private System.Windows.Forms.Label lblNombreSocio;
        private System.Windows.Forms.Button btnRegistrarSocio;
        private System.Windows.Forms.GroupBox mrcSexo;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.RadioButton optFemenino;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TabPage Paises;
        private System.Windows.Forms.Button btnRegistrarPais;
        private System.Windows.Forms.Label lblNombrePais;
        private System.Windows.Forms.TextBox txtNombrePais;
    }
}


﻿namespace VerificentrosFormatos
{
    partial class ProcesamientoMasivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesamientoMasivo));
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkMicrobancas = new System.Windows.Forms.CheckBox();
            this.chkDinamometros = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTacometros = new System.Windows.Forms.CheckBox();
            this.chkOpacimetros = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesamiento de Formatos de forma mavisa";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.Red;
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(21, 267);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(137, 42);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar Todo";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(174, 267);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkMicrobancas
            // 
            this.chkMicrobancas.AutoSize = true;
            this.chkMicrobancas.Location = new System.Drawing.Point(58, 169);
            this.chkMicrobancas.Name = "chkMicrobancas";
            this.chkMicrobancas.Size = new System.Drawing.Size(110, 21);
            this.chkMicrobancas.TabIndex = 3;
            this.chkMicrobancas.Text = "Microbancas";
            this.chkMicrobancas.UseVisualStyleBackColor = true;
            // 
            // chkDinamometros
            // 
            this.chkDinamometros.AutoSize = true;
            this.chkDinamometros.Location = new System.Drawing.Point(58, 142);
            this.chkDinamometros.Name = "chkDinamometros";
            this.chkDinamometros.Size = new System.Drawing.Size(121, 21);
            this.chkDinamometros.TabIndex = 4;
            this.chkDinamometros.Text = "Dinamómetros";
            this.chkDinamometros.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTacometros);
            this.groupBox1.Controls.Add(this.chkOpacimetros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ddlTipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkDinamometros);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Controls.Add(this.chkMicrobancas);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Location = new System.Drawing.Point(136, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 337);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // chkTacometros
            // 
            this.chkTacometros.AutoSize = true;
            this.chkTacometros.Location = new System.Drawing.Point(58, 223);
            this.chkTacometros.Name = "chkTacometros";
            this.chkTacometros.Size = new System.Drawing.Size(105, 21);
            this.chkTacometros.TabIndex = 9;
            this.chkTacometros.Text = "Tacómetros";
            this.chkTacometros.UseVisualStyleBackColor = true;
            // 
            // chkOpacimetros
            // 
            this.chkOpacimetros.AutoSize = true;
            this.chkOpacimetros.Location = new System.Drawing.Point(58, 196);
            this.chkOpacimetros.Name = "chkOpacimetros";
            this.chkOpacimetros.Size = new System.Drawing.Size(110, 21);
            this.chkOpacimetros.TabIndex = 8;
            this.chkOpacimetros.Text = "Opacímetros";
            this.chkOpacimetros.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Formatos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo Exportación:";
            // 
            // ddlTipo
            // 
            this.ddlTipo.FormattingEnabled = true;
            this.ddlTipo.Location = new System.Drawing.Point(152, 72);
            this.ddlTipo.Name = "ddlTipo";
            this.ddlTipo.Size = new System.Drawing.Size(159, 24);
            this.ddlTipo.TabIndex = 5;
            // 
            // ProcesamientoMasivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 364);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcesamientoMasivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesamiento Masivo de Formatos";
            this.Load += new System.EventHandler(this.ProcesamientoMasivo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkMicrobancas;
        private System.Windows.Forms.CheckBox chkDinamometros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkOpacimetros;
        private System.Windows.Forms.CheckBox chkTacometros;
    }
}
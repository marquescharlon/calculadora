﻿namespace Calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtResultado.Location = new System.Drawing.Point(15, 11);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtResultado.MaxLength = 5;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(205, 53);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnSete
            // 
            this.btnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSete.Location = new System.Drawing.Point(15, 124);
            this.btnSete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(51, 51);
            this.btnSete.TabIndex = 1;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnOito
            // 
            this.btnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOito.Location = new System.Drawing.Point(66, 124);
            this.btnOito.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(51, 51);
            this.btnOito.TabIndex = 2;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNove.Location = new System.Drawing.Point(117, 124);
            this.btnNove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(51, 51);
            this.btnNove.TabIndex = 3;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuatro.Location = new System.Drawing.Point(15, 174);
            this.btnQuatro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(51, 51);
            this.btnQuatro.TabIndex = 4;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCinco.Location = new System.Drawing.Point(66, 174);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(51, 51);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSeis.Location = new System.Drawing.Point(117, 174);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(51, 51);
            this.btnSeis.TabIndex = 6;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnUm
            // 
            this.btnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUm.Location = new System.Drawing.Point(15, 226);
            this.btnUm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(51, 51);
            this.btnUm.TabIndex = 7;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnDois
            // 
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDois.Location = new System.Drawing.Point(66, 226);
            this.btnDois.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(51, 51);
            this.btnDois.TabIndex = 8;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTres.Location = new System.Drawing.Point(117, 226);
            this.btnTres.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(51, 51);
            this.btnTres.TabIndex = 9;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnZero.Location = new System.Drawing.Point(66, 277);
            this.btnZero.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(51, 51);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVirgula.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVirgula.Location = new System.Drawing.Point(15, 277);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(51, 51);
            this.btnVirgula.TabIndex = 11;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIgual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIgual.Location = new System.Drawing.Point(168, 277);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(51, 51);
            this.btnIgual.TabIndex = 12;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDivisao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDivisao.Location = new System.Drawing.Point(168, 124);
            this.btnDivisao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(51, 51);
            this.btnDivisao.TabIndex = 13;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMultiplicacao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMultiplicacao.Location = new System.Drawing.Point(168, 175);
            this.btnMultiplicacao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(51, 51);
            this.btnMultiplicacao.TabIndex = 14;
            this.btnMultiplicacao.Text = "X";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubtracao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubtracao.Location = new System.Drawing.Point(168, 226);
            this.btnSubtracao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(51, 51);
            this.btnSubtracao.TabIndex = 15;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdicao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdicao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicao.Location = new System.Drawing.Point(117, 277);
            this.btnAdicao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(51, 51);
            this.btnAdicao.TabIndex = 16;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = false;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(168, 72);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(51, 51);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblOperacao.Location = new System.Drawing.Point(16, 14);
            this.lblOperacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 46);
            this.lblOperacao.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 345);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.txtResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblOperacao;
    }
}


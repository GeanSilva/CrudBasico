namespace ProjetoTemplete
{
    partial class FrmCadastraCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texCodigo = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.radBtnSexoMasculino = new System.Windows.Forms.RadioButton();
            this.radBtnFemenino = new System.Windows.Forms.RadioButton();
            this.textValorCompra = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Limete de Compra";
            // 
            // texCodigo
            // 
            this.texCodigo.Location = new System.Drawing.Point(51, 8);
            this.texCodigo.Name = "texCodigo";
            this.texCodigo.ReadOnly = true;
            this.texCodigo.Size = new System.Drawing.Size(58, 20);
            this.texCodigo.TabIndex = 5;
            this.texCodigo.TabStop = false;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(51, 34);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(281, 20);
            this.textNome.TabIndex = 6;
            // 
            // radBtnSexoMasculino
            // 
            this.radBtnSexoMasculino.AutoSize = true;
            this.radBtnSexoMasculino.Checked = true;
            this.radBtnSexoMasculino.Location = new System.Drawing.Point(42, 97);
            this.radBtnSexoMasculino.Name = "radBtnSexoMasculino";
            this.radBtnSexoMasculino.Size = new System.Drawing.Size(34, 17);
            this.radBtnSexoMasculino.TabIndex = 8;
            this.radBtnSexoMasculino.TabStop = true;
            this.radBtnSexoMasculino.Text = "M";
            this.radBtnSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // radBtnFemenino
            // 
            this.radBtnFemenino.AutoSize = true;
            this.radBtnFemenino.Location = new System.Drawing.Point(82, 97);
            this.radBtnFemenino.Name = "radBtnFemenino";
            this.radBtnFemenino.Size = new System.Drawing.Size(31, 17);
            this.radBtnFemenino.TabIndex = 9;
            this.radBtnFemenino.Text = "F";
            this.radBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // textValorCompra
            // 
            this.textValorCompra.Location = new System.Drawing.Point(103, 123);
            this.textValorCompra.Mask = "0000,00";
            this.textValorCompra.Name = "textValorCompra";
            this.textValorCompra.Size = new System.Drawing.Size(49, 20);
            this.textValorCompra.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(253, 140);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtp_Data
            // 
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Data.Location = new System.Drawing.Point(115, 63);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(92, 20);
            this.dtp_Data.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(334, 140);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCadastraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 175);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.textValorCompra);
            this.Controls.Add(this.radBtnFemenino);
            this.Controls.Add(this.radBtnSexoMasculino);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.texCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastraCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texCodigo;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.RadioButton radBtnSexoMasculino;
        private System.Windows.Forms.RadioButton radBtnFemenino;
        private System.Windows.Forms.MaskedTextBox textValorCompra;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.Button btnCancelar;
    }
}
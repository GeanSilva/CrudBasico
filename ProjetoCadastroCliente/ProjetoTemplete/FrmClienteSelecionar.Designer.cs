namespace ProjetoTemplete
{
    partial class FrmClienteSelecionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.colCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLimete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.btnAtuliza = new System.Windows.Forms.Button();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.bnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código/Nome";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(81, 6);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(532, 20);
            this.textBox.TabIndex = 1;
            // 
            // Tabela
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Tabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCódigo,
            this.colNome,
            this.colDataNascimento,
            this.colSexo,
            this.colLimete});
            this.Tabela.Location = new System.Drawing.Point(4, 45);
            this.Tabela.MultiSelect = false;
            this.Tabela.Name = "Tabela";
            this.Tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela.Size = new System.Drawing.Size(703, 394);
            this.Tabela.TabIndex = 2;
            // 
            // colCódigo
            // 
            this.colCódigo.DataPropertyName = "IdCliente";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "#,##0";
            this.colCódigo.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCódigo.HeaderText = "Código";
            this.colCódigo.Name = "colCódigo";
            this.colCódigo.ReadOnly = true;
            this.colCódigo.Width = 65;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colNome.DefaultCellStyle = dataGridViewCellStyle8;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 294;
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.DataPropertyName = "DataNascimento";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "dd/MM/yyyy";
            dataGridViewCellStyle9.NullValue = null;
            this.colDataNascimento.DefaultCellStyle = dataGridViewCellStyle9;
            this.colDataNascimento.HeaderText = "Data de Nascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            this.colDataNascimento.ReadOnly = true;
            this.colDataNascimento.Width = 150;
            // 
            // colSexo
            // 
            this.colSexo.DataPropertyName = "Sexo";
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            this.colSexo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSexo.Width = 50;
            // 
            // colLimete
            // 
            this.colLimete.DataPropertyName = "LimeteCompra";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.colLimete.DefaultCellStyle = dataGridViewCellStyle10;
            this.colLimete.HeaderText = "Limete de Compra";
            this.colLimete.Name = "colLimete";
            this.colLimete.ReadOnly = true;
            this.colLimete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLimete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(619, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Bucar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(311, 445);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(75, 23);
            this.Alterar.TabIndex = 4;
            this.Alterar.Text = "Inserir";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // btnAtuliza
            // 
            this.btnAtuliza.Location = new System.Drawing.Point(392, 445);
            this.btnAtuliza.Name = "btnAtuliza";
            this.btnAtuliza.Size = new System.Drawing.Size(75, 23);
            this.btnAtuliza.TabIndex = 5;
            this.btnAtuliza.Text = "Alterar";
            this.btnAtuliza.UseVisualStyleBackColor = true;
            this.btnAtuliza.Click += new System.EventHandler(this.btnAtuliza_Click);
            // 
            // btnDeleta
            // 
            this.btnDeleta.Location = new System.Drawing.Point(473, 445);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(75, 23);
            this.btnDeleta.TabIndex = 6;
            this.btnDeleta.Text = "Deletar";
            this.btnDeleta.UseVisualStyleBackColor = true;
            this.btnDeleta.Click += new System.EventHandler(this.btnDeleta_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(554, 445);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 7;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // bnFechar
            // 
            this.bnFechar.Location = new System.Drawing.Point(635, 445);
            this.bnFechar.Name = "bnFechar";
            this.bnFechar.Size = new System.Drawing.Size(75, 23);
            this.bnFechar.TabIndex = 8;
            this.bnFechar.Text = "Fechar";
            this.bnFechar.UseVisualStyleBackColor = true;
            this.bnFechar.Click += new System.EventHandler(this.bnFechar_Click);
            // 
            // FrmClienteSelecionar
            // 
            this.ClientSize = new System.Drawing.Size(712, 471);
            this.Controls.Add(this.bnFechar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnDeleta);
            this.Controls.Add(this.btnAtuliza);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteSelecionar";
            this.Text = "Selecionar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCaixaTexto;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button btnAtuliza;
        private System.Windows.Forms.Button btnDeleta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button bnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimete;
    }
}
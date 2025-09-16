namespace InventoryAppSimples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEstoque = new DataGridView();
            txtProdutoId = new TextBox();
            txtProdutoNome = new TextBox();
            txtProdutoQuantidade = new TextBox();
            btnAdicionarProduto = new Button();
            btnRemoverProduto = new Button();
            btnConsultarEstoque = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // dgvEstoque
            // 
            dgvEstoque.AccessibleName = "Controle de Estoque";
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstoque.BackgroundColor = Color.SteelBlue;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.GridColor = SystemColors.InactiveCaptionText;
            dgvEstoque.Location = new Point(72, 67);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersWidth = 51;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoque.Size = new Size(495, 229);
            dgvEstoque.TabIndex = 0;
            // 
            // txtProdutoId
            // 
            txtProdutoId.Location = new Point(135, 407);
            txtProdutoId.Name = "txtProdutoId";
            txtProdutoId.Size = new Size(163, 27);
            txtProdutoId.TabIndex = 1;
            // 
            // txtProdutoNome
            // 
            txtProdutoNome.Location = new Point(135, 461);
            txtProdutoNome.Name = "txtProdutoNome";
            txtProdutoNome.Size = new Size(163, 27);
            txtProdutoNome.TabIndex = 2;
            // 
            // txtProdutoQuantidade
            // 
            txtProdutoQuantidade.Location = new Point(135, 516);
            txtProdutoQuantidade.Name = "txtProdutoQuantidade";
            txtProdutoQuantidade.Size = new Size(163, 27);
            txtProdutoQuantidade.TabIndex = 3;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.BackColor = Color.LightCyan;
            btnAdicionarProduto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarProduto.Location = new Point(402, 427);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(116, 29);
            btnAdicionarProduto.TabIndex = 4;
            btnAdicionarProduto.Text = "ADICIONAR";
            btnAdicionarProduto.UseVisualStyleBackColor = false;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // btnRemoverProduto
            // 
            btnRemoverProduto.BackColor = Color.LightCyan;
            btnRemoverProduto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoverProduto.Location = new Point(402, 487);
            btnRemoverProduto.Name = "btnRemoverProduto";
            btnRemoverProduto.Size = new Size(116, 29);
            btnRemoverProduto.TabIndex = 5;
            btnRemoverProduto.Text = "REMOVER";
            btnRemoverProduto.UseVisualStyleBackColor = false;
            btnRemoverProduto.Click += btnRemoverProduto_Click;
            // 
            // btnConsultarEstoque
            // 
            btnConsultarEstoque.BackColor = Color.LightCyan;
            btnConsultarEstoque.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultarEstoque.Location = new Point(203, 327);
            btnConsultarEstoque.Name = "btnConsultarEstoque";
            btnConsultarEstoque.Size = new Size(243, 29);
            btnConsultarEstoque.TabIndex = 6;
            btnConsultarEstoque.Text = "CONSULTAR ESTOQUE";
            btnConsultarEstoque.UseVisualStyleBackColor = false;
            btnConsultarEstoque.Click += btnConsultarEstoque_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 414);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 468);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 8;
            label2.Text = "NOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 519);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 9;
            label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 9);
            label4.Name = "label4";
            label4.Size = new Size(288, 31);
            label4.TabIndex = 10;
            label4.Text = "CONSULTOR DE ESTOQUE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(657, 614);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConsultarEstoque);
            Controls.Add(btnRemoverProduto);
            Controls.Add(btnAdicionarProduto);
            Controls.Add(txtProdutoNome);
            Controls.Add(txtProdutoId);
            Controls.Add(dgvEstoque);
            Controls.Add(txtProdutoQuantidade);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEstoque;
        private TextBox txtProdutoId;
        private TextBox txtProdutoNome;
        private TextBox txtProdutoQuantidade;
        private Button btnAdicionarProduto;
        private Button btnRemoverProduto;
        private Button btnConsultarEstoque;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

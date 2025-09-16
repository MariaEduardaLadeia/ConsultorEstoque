using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryLib;

namespace InventoryAppSimples
{
    public partial class Form1 : Form
    {
        private InventoryManager _inventoryManager; 

        public Form1()
        {
            InitializeComponent();
            _inventoryManager = new InventoryManager();
            ConfigurarDataGridView(); 
            AtualizarEstoqueDataGridView(); 
        }

        private void ConfigurarDataGridView()
        {
            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.Columns.Clear();

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "IdColumn";
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "Id";
            idColumn.Width = 50;
            idColumn.ReadOnly = true;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstoque.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nomeColumn = new DataGridViewTextBoxColumn();
            nomeColumn.Name = "NomeColumn";
            nomeColumn.HeaderText = "Nome do Produto";
            nomeColumn.DataPropertyName = "Nome";
            nomeColumn.Width = 180;
            nomeColumn.ReadOnly = true;
            nomeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEstoque.Columns.Add(nomeColumn);

            DataGridViewTextBoxColumn quantidadeColumn = new DataGridViewTextBoxColumn();
            quantidadeColumn.Name = "QuantidadeColumn";
            quantidadeColumn.HeaderText = "Qtd.";
            quantidadeColumn.DataPropertyName = "Quantidade";
            quantidadeColumn.Width = 80;
            quantidadeColumn.ReadOnly = true;
            quantidadeColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEstoque.Columns.Add(quantidadeColumn);
        }

        private void AtualizarEstoqueDataGridView()
        {
            try
            {
                List<Produto> estoqueAtual = _inventoryManager.ConsultarEstoque();
                dgvEstoque.DataSource = null; 
                dgvEstoque.DataSource = estoqueAtual; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar estoque: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCamposEntrada()
        {
            txtProdutoId.Text = string.Empty;
            txtProdutoNome.Text = string.Empty;
            txtProdutoQuantidade.Text = string.Empty;
        }

        private void btnConsultarEstoque_Click(object sender, EventArgs e)
        {
            AtualizarEstoqueDataGridView();
            if (_inventoryManager.ConsultarEstoque().Count == 0)
            {
                MessageBox.Show("O estoque está vazio no momento.", "Consulta de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtProdutoId.Text, out id); 

            if (string.IsNullOrWhiteSpace(txtProdutoNome.Text))
            {
                MessageBox.Show("O nome do produto não pode ser vazio.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtProdutoQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida. Por favor, insira um número inteiro positivo.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Produto produtoExistente = _inventoryManager.GetProdutoById(id);

                if (id > 0 && produtoExistente != null)
                {
                    produtoExistente.Nome = txtProdutoNome.Text; 
                    produtoExistente.Quantidade += quantidade;
                    MessageBox.Show($"Produto '{produtoExistente.Nome}' (ID: {produtoExistente.Id}) atualizado. Nova quantidade: {produtoExistente.Quantidade}.", "Produto Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (id > 0 && produtoExistente == null)
                {
                    
                    Produto novoProduto = new Produto(id, txtProdutoNome.Text, quantidade);
                    _inventoryManager.AdicionarProduto(novoProduto);
                    MessageBox.Show("Produto adicionado ao estoque!", "Produto Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    Produto novoProduto = new Produto(0, txtProdutoNome.Text, quantidade); 
                    _inventoryManager.AdicionarProduto(novoProduto);
                    MessageBox.Show("Produto adicionado ao estoque!", "Produto Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                AtualizarEstoqueDataGridView();
                LimparCamposEntrada();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Erro de validação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProdutoId.Text, out int idParaRemover) || idParaRemover <= 0)
            {
                MessageBox.Show("Por favor, insira um ID de produto válido para remover.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Produto produtoParaRemover = _inventoryManager.GetProdutoById(idParaRemover);

                if (produtoParaRemover == null)
                {
                    
                    MessageBox.Show("Esse produto não existe no estoque.", "Erro de Remoção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show($"Tem certeza que deseja remover o produto '{produtoParaRemover.Nome}' (ID: {idParaRemover})?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }

                bool removido = _inventoryManager.RemoverProduto(idParaRemover); 
                if (removido)
                {
                    AtualizarEstoqueDataGridView();
                    MessageBox.Show("Produto removido do estoque!", "Produto Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCamposEntrada();
                }
                
                else
                {
                    MessageBox.Show("Erro interno ao remover o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvEstoque.Rows[e.RowIndex];
                txtProdutoId.Text = row.Cells["IdColumn"].Value.ToString();
                txtProdutoNome.Text = row.Cells["NomeColumn"].Value.ToString();
                txtProdutoQuantidade.Text = row.Cells["QuantidadeColumn"].Value.ToString();
            }
        }
    }
}

using System.ComponentModel;

namespace gigi
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public BindingList<Cliente> Clientes { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }
        public BindingList<Venda> Vendas { get; set; }
        public BindingList<Compra> compras { get; set; }
        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            Clientes = new BindingList<Cliente>();
            fornecedores = new BindingList<Fornecedor>();
            Vendas = new BindingList<Venda>();
            compras = new BindingList<Compra>();
            this.dataGridView1.DataSource = produtos;
        }


        private void ButtonAdcionar_Click(object sender, EventArgs e)
        {

            criar_produto fcp = new criar_produto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();

                if (produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(x => x.Id);

                produto.Name = fcp.Name;
                produto.Fabricante = fcp.Nome_do_Fabricante;
                produto.PrecoVenda = fcp.precoVenda;
                produto.PrecoCompra = fcp.precoCompra;

                produtos.Add(produto);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonProduto_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = produtos; }

        private void buttonClientes_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = Clientes; }

        private void buttonVenda_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = Vendas; }

        private void buttonFornecedor_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = fornecedores; }

        private void buttonCompra_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = Vendas; }

        private void buttonAdicionarFornecedores_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoverVendas_Click(object sender, EventArgs e)
        {

        }
    }
}






     
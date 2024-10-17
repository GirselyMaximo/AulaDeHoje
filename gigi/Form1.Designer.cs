namespace gigi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ButtonAdcionar = new Button();
            buttonCancelar = new Button();
            dataGridView1 = new DataGridView();
            buttonProduto = new Button();
            buttonClientes = new Button();
            buttonVenda = new Button();
            buttonFornecedor = new Button();
            buttonCompra = new Button();
            buttonAdicionarCliente = new Button();
            buttonRemoverCliente = new Button();
            buttonRemoverVendas = new Button();
            buttonAdicionarVendas = new Button();
            buttonAdicionarFornecedores = new Button();
            buttonRemoverFornecedores = new Button();
            buttonAdicionarCompra = new Button();
            buttonRemoverCompra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ButtonAdcionar
            // 
            ButtonAdcionar.Location = new Point(30, 49);
            ButtonAdcionar.Name = "ButtonAdcionar";
            ButtonAdcionar.Size = new Size(131, 27);
            ButtonAdcionar.TabIndex = 0;
            ButtonAdcionar.Text = "Adicionar produto";
            ButtonAdcionar.UseVisualStyleBackColor = true;
            ButtonAdcionar.Click += ButtonAdcionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(30, 82);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(131, 28);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Remover produtos";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(801, 316);
            dataGridView1.TabIndex = 2;
            // 
            // buttonProduto
            // 
            buttonProduto.Image = (Image)resources.GetObject("buttonProduto.Image");
            buttonProduto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProduto.Location = new Point(30, 2);
            buttonProduto.Name = "buttonProduto";
            buttonProduto.Size = new Size(131, 37);
            buttonProduto.TabIndex = 3;
            buttonProduto.Text = "Produtos";
            buttonProduto.UseVisualStyleBackColor = true;
            buttonProduto.Click += buttonProduto_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.Image = (Image)resources.GetObject("buttonClientes.Image");
            buttonClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClientes.Location = new Point(187, 2);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(127, 37);
            buttonClientes.TabIndex = 4;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonVenda
            // 
            buttonVenda.Image = (Image)resources.GetObject("buttonVenda.Image");
            buttonVenda.ImageAlign = ContentAlignment.MiddleLeft;
            buttonVenda.Location = new Point(359, 2);
            buttonVenda.Name = "buttonVenda";
            buttonVenda.Size = new Size(126, 37);
            buttonVenda.TabIndex = 5;
            buttonVenda.Text = "Vendas";
            buttonVenda.UseVisualStyleBackColor = true;
            buttonVenda.Click += buttonVenda_Click;
            // 
            // buttonFornecedor
            // 
            buttonFornecedor.Image = (Image)resources.GetObject("buttonFornecedor.Image");
            buttonFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFornecedor.Location = new Point(524, 2);
            buttonFornecedor.Name = "buttonFornecedor";
            buttonFornecedor.Size = new Size(142, 37);
            buttonFornecedor.TabIndex = 6;
            buttonFornecedor.Text = "  Fornecedores";
            buttonFornecedor.UseVisualStyleBackColor = true;
            buttonFornecedor.Click += buttonFornecedor_Click;
            // 
            // buttonCompra
            // 
            buttonCompra.Image = (Image)resources.GetObject("buttonCompra.Image");
            buttonCompra.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCompra.Location = new Point(713, 2);
            buttonCompra.Name = "buttonCompra";
            buttonCompra.Size = new Size(118, 37);
            buttonCompra.TabIndex = 7;
            buttonCompra.Text = "  Compras";
            buttonCompra.UseVisualStyleBackColor = true;
            buttonCompra.Click += buttonCompra_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.Location = new Point(187, 48);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(127, 27);
            buttonAdicionarCliente.TabIndex = 8;
            buttonAdicionarCliente.Text = "Adicionar cliente";
            buttonAdicionarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.Location = new Point(187, 82);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(127, 28);
            buttonRemoverCliente.TabIndex = 9;
            buttonRemoverCliente.Text = "RemoverCliente";
            buttonRemoverCliente.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverVendas
            // 
            buttonRemoverVendas.Location = new Point(359, 82);
            buttonRemoverVendas.Name = "buttonRemoverVendas";
            buttonRemoverVendas.Size = new Size(126, 28);
            buttonRemoverVendas.TabIndex = 10;
            buttonRemoverVendas.Text = "Remover vendas";
            buttonRemoverVendas.UseVisualStyleBackColor = true;
            buttonRemoverVendas.Click += buttonRemoverVendas_Click;
            // 
            // buttonAdicionarVendas
            // 
            buttonAdicionarVendas.Location = new Point(359, 49);
            buttonAdicionarVendas.Name = "buttonAdicionarVendas";
            buttonAdicionarVendas.Size = new Size(126, 27);
            buttonAdicionarVendas.TabIndex = 11;
            buttonAdicionarVendas.Text = "Adicionar vendas";
            buttonAdicionarVendas.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarFornecedores
            // 
            buttonAdicionarFornecedores.Location = new Point(524, 48);
            buttonAdicionarFornecedores.Name = "buttonAdicionarFornecedores";
            buttonAdicionarFornecedores.Size = new Size(142, 27);
            buttonAdicionarFornecedores.TabIndex = 12;
            buttonAdicionarFornecedores.Text = "Adicionar Fornecedores";
            buttonAdicionarFornecedores.UseVisualStyleBackColor = true;
            buttonAdicionarFornecedores.Click += buttonAdicionarFornecedores_Click;
            // 
            // buttonRemoverFornecedores
            // 
            buttonRemoverFornecedores.Location = new Point(524, 82);
            buttonRemoverFornecedores.Name = "buttonRemoverFornecedores";
            buttonRemoverFornecedores.Size = new Size(142, 28);
            buttonRemoverFornecedores.TabIndex = 13;
            buttonRemoverFornecedores.Text = "Remover Fornecedores";
            buttonRemoverFornecedores.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarCompra
            // 
            buttonAdicionarCompra.Location = new Point(713, 48);
            buttonAdicionarCompra.Name = "buttonAdicionarCompra";
            buttonAdicionarCompra.Size = new Size(118, 26);
            buttonAdicionarCompra.TabIndex = 14;
            buttonAdicionarCompra.Text = "Adicionar compra";
            buttonAdicionarCompra.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverCompra
            // 
            buttonRemoverCompra.Location = new Point(713, 80);
            buttonRemoverCompra.Name = "buttonRemoverCompra";
            buttonRemoverCompra.Size = new Size(118, 28);
            buttonRemoverCompra.TabIndex = 15;
            buttonRemoverCompra.Text = "Remover compra";
            buttonRemoverCompra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(865, 444);
            Controls.Add(buttonRemoverCompra);
            Controls.Add(buttonAdicionarCompra);
            Controls.Add(buttonRemoverFornecedores);
            Controls.Add(buttonAdicionarFornecedores);
            Controls.Add(buttonAdicionarVendas);
            Controls.Add(buttonRemoverVendas);
            Controls.Add(buttonRemoverCliente);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(buttonCompra);
            Controls.Add(buttonFornecedor);
            Controls.Add(buttonVenda);
            Controls.Add(buttonClientes);
            Controls.Add(buttonProduto);
            Controls.Add(dataGridView1);
            Controls.Add(buttonCancelar);
            Controls.Add(ButtonAdcionar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonAdcionar;
        private Button buttonCancelar;
        private DataGridView dataGridView1;
        private Button buttonProduto;
        private Button buttonClientes;
        private Button buttonVenda;
        private Button buttonFornecedor;
        private Button buttonCompra;
        private Button buttonAdicionarCliente;
        private Button buttonRemoverCliente;
        private Button buttonRemoverVendas;
        private Button buttonAdicionarVendas;
        private Button buttonAdicionarFornecedores;
        private Button buttonRemoverFornecedores;
        private Button buttonAdicionarCompra;
        private Button buttonRemoverCompra;
    }
}

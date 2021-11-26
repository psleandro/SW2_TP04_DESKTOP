
namespace TP04_DESKTOP
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
            this.btnObterLivros = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLivrosPorId = new System.Windows.Forms.Button();
            this.btnIncluirLivro = new System.Windows.Forms.Button();
            this.btnAtualizaProduto = new System.Windows.Forms.Button();
            this.btnDeletarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObterLivros
            // 
            this.btnObterLivros.Location = new System.Drawing.Point(30, 404);
            this.btnObterLivros.Name = "btnObterLivros";
            this.btnObterLivros.Size = new System.Drawing.Size(105, 23);
            this.btnObterLivros.TabIndex = 0;
            this.btnObterLivros.Text = "Obter Livros";
            this.btnObterLivros.UseVisualStyleBackColor = true;
            this.btnObterLivros.Click += new System.EventHandler(this.btnObterLivros_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(30, 51);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowTemplate.Height = 25;
            this.dgvDados.Size = new System.Drawing.Size(738, 347);
            this.dgvDados.TabIndex = 2;
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(85, 16);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(683, 23);
            this.txtURI.TabIndex = 3;
            this.txtURI.Text = "https://localhost:44312/api/livros";
            this.txtURI.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "API URI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLivrosPorId
            // 
            this.btnLivrosPorId.Location = new System.Drawing.Point(157, 404);
            this.btnLivrosPorId.Name = "btnLivrosPorId";
            this.btnLivrosPorId.Size = new System.Drawing.Size(153, 23);
            this.btnLivrosPorId.TabIndex = 5;
            this.btnLivrosPorId.Text = " Obter Livros Por ID";
            this.btnLivrosPorId.UseVisualStyleBackColor = true;
            this.btnLivrosPorId.Click += new System.EventHandler(this.btnLivrosPorId_Click);
            // 
            // btnIncluirLivro
            // 
            this.btnIncluirLivro.Location = new System.Drawing.Point(326, 404);
            this.btnIncluirLivro.Name = "btnIncluirLivro";
            this.btnIncluirLivro.Size = new System.Drawing.Size(132, 23);
            this.btnIncluirLivro.TabIndex = 6;
            this.btnIncluirLivro.Text = "Incluir Livro";
            this.btnIncluirLivro.UseVisualStyleBackColor = true;
            this.btnIncluirLivro.Click += new System.EventHandler(this.btnIncluirLivro_Click);
            // 
            // btnAtualizaProduto
            // 
            this.btnAtualizaProduto.Location = new System.Drawing.Point(482, 404);
            this.btnAtualizaProduto.Name = "btnAtualizaProduto";
            this.btnAtualizaProduto.Size = new System.Drawing.Size(136, 23);
            this.btnAtualizaProduto.TabIndex = 7;
            this.btnAtualizaProduto.Text = "Atualizar Livro";
            this.btnAtualizaProduto.UseVisualStyleBackColor = true;
            this.btnAtualizaProduto.Click += new System.EventHandler(this.btnAtualizaProduto_Click);
            // 
            // btnDeletarProduto
            // 
            this.btnDeletarProduto.Location = new System.Drawing.Point(633, 404);
            this.btnDeletarProduto.Name = "btnDeletarProduto";
            this.btnDeletarProduto.Size = new System.Drawing.Size(135, 23);
            this.btnDeletarProduto.TabIndex = 8;
            this.btnDeletarProduto.Text = "Deletar Livro";
            this.btnDeletarProduto.UseVisualStyleBackColor = true;
            this.btnDeletarProduto.Click += new System.EventHandler(this.btnDeletarProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletarProduto);
            this.Controls.Add(this.btnAtualizaProduto);
            this.Controls.Add(this.btnIncluirLivro);
            this.Controls.Add(this.btnLivrosPorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnObterLivros);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObterLivros;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLivrosPorId;
        private System.Windows.Forms.Button btnIncluirLivro;
        private System.Windows.Forms.Button btnAtualizaProduto;
        private System.Windows.Forms.Button btnDeletarProduto;
    }
}


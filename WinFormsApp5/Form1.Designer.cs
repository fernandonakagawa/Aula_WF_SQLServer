
namespace WinFormsApp5
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
            this.btInserir = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btBuscarTelefone = new System.Windows.Forms.Button();
            this.lbTabela = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.lbModo = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbInserirBuscar = new System.Windows.Forms.GroupBox();
            this.gbEditarExcluir = new System.Windows.Forms.GroupBox();
            this.tbNomeEditar = new System.Windows.Forms.TextBox();
            this.tbTelefoneEditar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbInserirBuscar.SuspendLayout();
            this.gbEditarExcluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(22, 72);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 0;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(22, 43);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 23);
            this.tbNome.TabIndex = 1;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(162, 43);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 23);
            this.tbTelefone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(457, 46);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(331, 392);
            this.dgvClientes.TabIndex = 5;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(22, 116);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 49);
            this.btAtualizar.TabIndex = 6;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btBuscarTelefone
            // 
            this.btBuscarTelefone.Location = new System.Drawing.Point(162, 72);
            this.btBuscarTelefone.Name = "btBuscarTelefone";
            this.btBuscarTelefone.Size = new System.Drawing.Size(125, 23);
            this.btBuscarTelefone.TabIndex = 7;
            this.btBuscarTelefone.Text = "Buscar por Telefone";
            this.btBuscarTelefone.UseVisualStyleBackColor = true;
            this.btBuscarTelefone.Click += new System.EventHandler(this.btBuscarTelefone_Click);
            // 
            // lbTabela
            // 
            this.lbTabela.AutoSize = true;
            this.lbTabela.Location = new System.Drawing.Point(457, 13);
            this.lbTabela.Name = "lbTabela";
            this.lbTabela.Size = new System.Drawing.Size(40, 15);
            this.lbTabela.TabIndex = 8;
            this.lbTabela.Text = "Tabela";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(162, 78);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(22, 78);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 9;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // lbModo
            // 
            this.lbModo.AutoSize = true;
            this.lbModo.Location = new System.Drawing.Point(12, 79);
            this.lbModo.Name = "lbModo";
            this.lbModo.Size = new System.Drawing.Size(0, 15);
            this.lbModo.TabIndex = 11;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(22, 141);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 53);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbInserirBuscar
            // 
            this.gbInserirBuscar.Controls.Add(this.tbNome);
            this.gbInserirBuscar.Controls.Add(this.btInserir);
            this.gbInserirBuscar.Controls.Add(this.tbTelefone);
            this.gbInserirBuscar.Controls.Add(this.label1);
            this.gbInserirBuscar.Controls.Add(this.label2);
            this.gbInserirBuscar.Controls.Add(this.btAtualizar);
            this.gbInserirBuscar.Controls.Add(this.btBuscarTelefone);
            this.gbInserirBuscar.Location = new System.Drawing.Point(18, 46);
            this.gbInserirBuscar.Name = "gbInserirBuscar";
            this.gbInserirBuscar.Size = new System.Drawing.Size(433, 186);
            this.gbInserirBuscar.TabIndex = 13;
            this.gbInserirBuscar.TabStop = false;
            this.gbInserirBuscar.Text = "Modo Inserir ou Buscar";
            // 
            // gbEditarExcluir
            // 
            this.gbEditarExcluir.Controls.Add(this.tbNomeEditar);
            this.gbEditarExcluir.Controls.Add(this.tbTelefoneEditar);
            this.gbEditarExcluir.Controls.Add(this.label3);
            this.gbEditarExcluir.Controls.Add(this.label4);
            this.gbEditarExcluir.Controls.Add(this.btEditar);
            this.gbEditarExcluir.Controls.Add(this.btExcluir);
            this.gbEditarExcluir.Controls.Add(this.btCancelar);
            this.gbEditarExcluir.Enabled = false;
            this.gbEditarExcluir.Location = new System.Drawing.Point(18, 238);
            this.gbEditarExcluir.Name = "gbEditarExcluir";
            this.gbEditarExcluir.Size = new System.Drawing.Size(433, 200);
            this.gbEditarExcluir.TabIndex = 14;
            this.gbEditarExcluir.TabStop = false;
            this.gbEditarExcluir.Text = "Modo Editar ou Excluir";
            // 
            // tbNomeEditar
            // 
            this.tbNomeEditar.Location = new System.Drawing.Point(22, 37);
            this.tbNomeEditar.Name = "tbNomeEditar";
            this.tbNomeEditar.Size = new System.Drawing.Size(100, 23);
            this.tbNomeEditar.TabIndex = 13;
            // 
            // tbTelefoneEditar
            // 
            this.tbTelefoneEditar.Location = new System.Drawing.Point(162, 37);
            this.tbTelefoneEditar.Name = "tbTelefoneEditar";
            this.tbTelefoneEditar.Size = new System.Drawing.Size(100, 23);
            this.tbTelefoneEditar.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefone:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbEditarExcluir);
            this.Controls.Add(this.gbInserirBuscar);
            this.Controls.Add(this.lbModo);
            this.Controls.Add(this.lbTabela);
            this.Controls.Add(this.dgvClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbInserirBuscar.ResumeLayout(false);
            this.gbInserirBuscar.PerformLayout();
            this.gbEditarExcluir.ResumeLayout(false);
            this.gbEditarExcluir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btBuscarTelefone;
        private System.Windows.Forms.Label lbTabela;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label lbModo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox gbInserirBuscar;
        private System.Windows.Forms.GroupBox gbEditarExcluir;
        private System.Windows.Forms.TextBox tbNomeEditar;
        private System.Windows.Forms.TextBox tbTelefoneEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


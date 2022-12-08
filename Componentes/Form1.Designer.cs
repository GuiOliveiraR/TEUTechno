
namespace Componentes
{
    partial class frmFrutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFrutas));
            this.cbbListadas = new System.Windows.Forms.ComboBox();
            this.ltbFrutas = new System.Windows.Forms.ListBox();
            this.gpbFrutas = new System.Windows.Forms.GroupBox();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblMelancia = new System.Windows.Forms.Label();
            this.lblMaca = new System.Windows.Forms.Label();
            this.lblPera = new System.Windows.Forms.Label();
            this.lblBanana = new System.Windows.Forms.Label();
            this.txtSelecionada = new System.Windows.Forms.TextBox();
            this.lblFrutasSelecionadas = new System.Windows.Forms.Label();
            this.lblFrutaListadas2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFrutasListadas = new System.Windows.Forms.Label();
            this.txtSelecione = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbFrutas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbListadas
            // 
            this.cbbListadas.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbListadas.FormattingEnabled = true;
            this.cbbListadas.Location = new System.Drawing.Point(280, 369);
            this.cbbListadas.MaxLength = 50;
            this.cbbListadas.Name = "cbbListadas";
            this.cbbListadas.Size = new System.Drawing.Size(207, 28);
            this.cbbListadas.TabIndex = 6;
            // 
            // ltbFrutas
            // 
            this.ltbFrutas.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbFrutas.FormattingEnabled = true;
            this.ltbFrutas.ItemHeight = 20;
            this.ltbFrutas.Location = new System.Drawing.Point(259, 138);
            this.ltbFrutas.Name = "ltbFrutas";
            this.ltbFrutas.Size = new System.Drawing.Size(228, 164);
            this.ltbFrutas.TabIndex = 7;
            // 
            // gpbFrutas
            // 
            this.gpbFrutas.Controls.Add(this.lblSair);
            this.gpbFrutas.Controls.Add(this.lblMelancia);
            this.gpbFrutas.Controls.Add(this.lblMaca);
            this.gpbFrutas.Controls.Add(this.lblPera);
            this.gpbFrutas.Controls.Add(this.lblBanana);
            this.gpbFrutas.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFrutas.Location = new System.Drawing.Point(47, 106);
            this.gpbFrutas.Name = "gpbFrutas";
            this.gpbFrutas.Size = new System.Drawing.Size(118, 217);
            this.gpbFrutas.TabIndex = 2;
            this.gpbFrutas.TabStop = false;
            this.gpbFrutas.Text = "Frutas";
            this.gpbFrutas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(22, 161);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(56, 20);
            this.lblSair.TabIndex = 4;
            this.lblSair.Text = "5 - Sair";
            // 
            // lblMelancia
            // 
            this.lblMelancia.AutoSize = true;
            this.lblMelancia.Location = new System.Drawing.Point(22, 134);
            this.lblMelancia.Name = "lblMelancia";
            this.lblMelancia.Size = new System.Drawing.Size(90, 20);
            this.lblMelancia.TabIndex = 3;
            this.lblMelancia.Text = "4 - Melancia";
            // 
            // lblMaca
            // 
            this.lblMaca.AutoSize = true;
            this.lblMaca.Location = new System.Drawing.Point(22, 75);
            this.lblMaca.Name = "lblMaca";
            this.lblMaca.Size = new System.Drawing.Size(66, 20);
            this.lblMaca.TabIndex = 2;
            this.lblMaca.Text = "2 - Maça";
            this.lblMaca.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPera
            // 
            this.lblPera.AutoSize = true;
            this.lblPera.Location = new System.Drawing.Point(22, 105);
            this.lblPera.Name = "lblPera";
            this.lblPera.Size = new System.Drawing.Size(59, 20);
            this.lblPera.TabIndex = 1;
            this.lblPera.Text = "3 - Pera";
            // 
            // lblBanana
            // 
            this.lblBanana.AutoSize = true;
            this.lblBanana.Location = new System.Drawing.Point(22, 48);
            this.lblBanana.Name = "lblBanana";
            this.lblBanana.Size = new System.Drawing.Size(78, 20);
            this.lblBanana.TabIndex = 0;
            this.lblBanana.Text = "1 - Banana";
            this.lblBanana.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSelecionada
            // 
            this.txtSelecionada.Enabled = false;
            this.txtSelecionada.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionada.Location = new System.Drawing.Point(47, 369);
            this.txtSelecionada.MaxLength = 50;
            this.txtSelecionada.Name = "txtSelecionada";
            this.txtSelecionada.Size = new System.Drawing.Size(202, 28);
            this.txtSelecionada.TabIndex = 1;
            // 
            // lblFrutasSelecionadas
            // 
            this.lblFrutasSelecionadas.AutoSize = true;
            this.lblFrutasSelecionadas.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrutasSelecionadas.Location = new System.Drawing.Point(44, 348);
            this.lblFrutasSelecionadas.Name = "lblFrutasSelecionadas";
            this.lblFrutasSelecionadas.Size = new System.Drawing.Size(126, 20);
            this.lblFrutasSelecionadas.TabIndex = 5;
            this.lblFrutasSelecionadas.Text = "Fruta Selecionada";
            this.lblFrutasSelecionadas.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblFrutaListadas2
            // 
            this.lblFrutaListadas2.AutoSize = true;
            this.lblFrutaListadas2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrutaListadas2.Location = new System.Drawing.Point(277, 348);
            this.lblFrutaListadas2.Name = "lblFrutaListadas2";
            this.lblFrutaListadas2.Size = new System.Drawing.Size(101, 20);
            this.lblFrutaListadas2.TabIndex = 6;
            this.lblFrutaListadas2.Text = "Fruta Listadas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(42, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(430, 32);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Digite o número para selecionar a fruta:";
            this.lblTitulo.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblFrutasListadas
            // 
            this.lblFrutasListadas.AutoSize = true;
            this.lblFrutasListadas.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrutasListadas.Location = new System.Drawing.Point(256, 106);
            this.lblFrutasListadas.Name = "lblFrutasListadas";
            this.lblFrutasListadas.Size = new System.Drawing.Size(107, 20);
            this.lblFrutasListadas.TabIndex = 8;
            this.lblFrutasListadas.Text = "Frutas Listadas";
            // 
            // txtSelecione
            // 
            this.txtSelecione.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecione.Location = new System.Drawing.Point(47, 66);
            this.txtSelecione.MaxLength = 50;
            this.txtSelecione.Name = "txtSelecione";
            this.txtSelecione.Size = new System.Drawing.Size(440, 28);
            this.txtSelecione.TabIndex = 0;
            this.txtSelecione.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelecione_KeyDown);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(47, 430);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(87, 34);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSeleionar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(162, 430);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(87, 34);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(400, 430);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 34);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(280, 430);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 34);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmFrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 505);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtSelecione);
            this.Controls.Add(this.lblFrutasListadas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFrutaListadas2);
            this.Controls.Add(this.lblFrutasSelecionadas);
            this.Controls.Add(this.txtSelecionada);
            this.Controls.Add(this.gpbFrutas);
            this.Controls.Add(this.ltbFrutas);
            this.Controls.Add(this.cbbListadas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFrutas";
            this.Text = "Frutas";
            this.gpbFrutas.ResumeLayout(false);
            this.gpbFrutas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbListadas;
        private System.Windows.Forms.ListBox ltbFrutas;
        private System.Windows.Forms.GroupBox gpbFrutas;
        private System.Windows.Forms.Label lblBanana;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblMelancia;
        private System.Windows.Forms.Label lblMaca;
        private System.Windows.Forms.Label lblPera;
        private System.Windows.Forms.TextBox txtSelecionada;
        private System.Windows.Forms.Label lblFrutasSelecionadas;
        private System.Windows.Forms.Label lblFrutaListadas2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFrutasListadas;
        private System.Windows.Forms.TextBox txtSelecione;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}


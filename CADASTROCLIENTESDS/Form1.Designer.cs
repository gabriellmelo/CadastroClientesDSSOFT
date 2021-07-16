
namespace CadastroClientesDS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelcabecalho = new System.Windows.Forms.Panel();
            this.txtcabecalho = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelnome = new System.Windows.Forms.Label();
            this.labelsobrenome = new System.Windows.Forms.Label();
            this.labeldtnascimento = new System.Windows.Forms.Label();
            this.labelendereco = new System.Windows.Forms.Label();
            this.labelbairro = new System.Windows.Forms.Label();
            this.labeltelefone = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.textendereco = new System.Windows.Forms.TextBox();
            this.textnome = new System.Windows.Forms.TextBox();
            this.textsobrenome = new System.Windows.Forms.TextBox();
            this.textbairro = new System.Windows.Forms.TextBox();
            this.labelcidade = new System.Windows.Forms.Label();
            this.textcidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textnascimento = new System.Windows.Forms.TextBox();
            this.texttelefone = new System.Windows.Forms.TextBox();
            this.panelcabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcabecalho
            // 
            this.panelcabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.panelcabecalho.Controls.Add(this.pictureBox1);
            this.panelcabecalho.Controls.Add(this.txtcabecalho);
            this.panelcabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelcabecalho.Name = "panelcabecalho";
            this.panelcabecalho.Size = new System.Drawing.Size(557, 93);
            this.panelcabecalho.TabIndex = 0;
            // 
            // txtcabecalho
            // 
            this.txtcabecalho.AutoSize = true;
            this.txtcabecalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcabecalho.Location = new System.Drawing.Point(12, 32);
            this.txtcabecalho.Name = "txtcabecalho";
            this.txtcabecalho.Size = new System.Drawing.Size(373, 33);
            this.txtcabecalho.TabIndex = 0;
            this.txtcabecalho.Text = "CADASTRO DE CLIENTES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnome.Location = new System.Drawing.Point(15, 111);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(79, 25);
            this.labelnome.TabIndex = 1;
            this.labelnome.Text = "NOME";
            // 
            // labelsobrenome
            // 
            this.labelsobrenome.AutoSize = true;
            this.labelsobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsobrenome.Location = new System.Drawing.Point(15, 154);
            this.labelsobrenome.Name = "labelsobrenome";
            this.labelsobrenome.Size = new System.Drawing.Size(157, 25);
            this.labelsobrenome.TabIndex = 2;
            this.labelsobrenome.Text = "SOBRENOME";
            // 
            // labeldtnascimento
            // 
            this.labeldtnascimento.AutoSize = true;
            this.labeldtnascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldtnascimento.Location = new System.Drawing.Point(16, 208);
            this.labeldtnascimento.Name = "labeldtnascimento";
            this.labeldtnascimento.Size = new System.Drawing.Size(266, 25);
            this.labeldtnascimento.TabIndex = 3;
            this.labeldtnascimento.Text = "DATA DE NASCIMENTO";
            this.labeldtnascimento.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelendereco
            // 
            this.labelendereco.AutoSize = true;
            this.labelendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelendereco.Location = new System.Drawing.Point(15, 275);
            this.labelendereco.Name = "labelendereco";
            this.labelendereco.Size = new System.Drawing.Size(138, 25);
            this.labelendereco.TabIndex = 4;
            this.labelendereco.Text = "ENDEREÇO";
            this.labelendereco.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelbairro
            // 
            this.labelbairro.AutoSize = true;
            this.labelbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbairro.Location = new System.Drawing.Point(15, 347);
            this.labelbairro.Name = "labelbairro";
            this.labelbairro.Size = new System.Drawing.Size(97, 25);
            this.labelbairro.TabIndex = 5;
            this.labelbairro.Text = "BAIRRO";
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelefone.Location = new System.Drawing.Point(15, 443);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(131, 25);
            this.labeltelefone.TabIndex = 6;
            this.labeltelefone.Text = "TELEFONE";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviar.Location = new System.Drawing.Point(38, 545);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(183, 48);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "ENVIAR FORMULÁRIO";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // textendereco
            // 
            this.textendereco.Location = new System.Drawing.Point(170, 255);
            this.textendereco.Multiline = true;
            this.textendereco.Name = "textendereco";
            this.textendereco.Size = new System.Drawing.Size(328, 64);
            this.textendereco.TabIndex = 9;
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(170, 111);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(328, 20);
            this.textnome.TabIndex = 11;
            // 
            // textsobrenome
            // 
            this.textsobrenome.Location = new System.Drawing.Point(170, 159);
            this.textsobrenome.Name = "textsobrenome";
            this.textsobrenome.Size = new System.Drawing.Size(328, 20);
            this.textsobrenome.TabIndex = 12;
            // 
            // textbairro
            // 
            this.textbairro.Location = new System.Drawing.Point(170, 347);
            this.textbairro.Name = "textbairro";
            this.textbairro.Size = new System.Drawing.Size(328, 20);
            this.textbairro.TabIndex = 13;
            // 
            // labelcidade
            // 
            this.labelcidade.AutoSize = true;
            this.labelcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcidade.Location = new System.Drawing.Point(15, 395);
            this.labelcidade.Name = "labelcidade";
            this.labelcidade.Size = new System.Drawing.Size(96, 25);
            this.labelcidade.TabIndex = 15;
            this.labelcidade.Text = "CIDADE";
            // 
            // textcidade
            // 
            this.textcidade.Location = new System.Drawing.Point(170, 395);
            this.textcidade.Name = "textcidade";
            this.textcidade.Size = new System.Drawing.Size(328, 20);
            this.textcidade.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(302, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "CONTATE-NOS AGORA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textnascimento
            // 
            this.textnascimento.Location = new System.Drawing.Point(288, 213);
            this.textnascimento.Name = "textnascimento";
            this.textnascimento.Size = new System.Drawing.Size(210, 20);
            this.textnascimento.TabIndex = 18;
            // 
            // texttelefone
            // 
            this.texttelefone.Location = new System.Drawing.Point(170, 447);
            this.texttelefone.Name = "texttelefone";
            this.texttelefone.Size = new System.Drawing.Size(327, 20);
            this.texttelefone.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(557, 639);
            this.Controls.Add(this.texttelefone);
            this.Controls.Add(this.textnascimento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textcidade);
            this.Controls.Add(this.labelcidade);
            this.Controls.Add(this.textbairro);
            this.Controls.Add(this.textsobrenome);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.textendereco);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.labeltelefone);
            this.Controls.Add(this.labelbairro);
            this.Controls.Add(this.labelendereco);
            this.Controls.Add(this.labeldtnascimento);
            this.Controls.Add(this.labelsobrenome);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.panelcabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelcabecalho.ResumeLayout(false);
            this.panelcabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelcabecalho;
        private System.Windows.Forms.Label txtcabecalho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labelsobrenome;
        private System.Windows.Forms.Label labeldtnascimento;
        private System.Windows.Forms.Label labelendereco;
        private System.Windows.Forms.Label labelbairro;
        private System.Windows.Forms.Label labeltelefone;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox textendereco;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.TextBox textsobrenome;
        private System.Windows.Forms.TextBox textbairro;
        private System.Windows.Forms.Label labelcidade;
        private System.Windows.Forms.TextBox textcidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textnascimento;
        private System.Windows.Forms.TextBox texttelefone;
    }
}


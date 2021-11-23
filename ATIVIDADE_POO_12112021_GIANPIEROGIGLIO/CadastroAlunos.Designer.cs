using System.Windows.Forms;

namespace ATIVIDADE_POO_12112021_GIANPIEROGIGLIO
{
    partial class CadastroAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAlunos));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblLogr = new System.Windows.Forms.Label();
            this.txtLogr = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lvAlunos = new System.Windows.Forms.ListView();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.RA = new System.Windows.Forms.ColumnHeader();
            this.Telefone = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.datanasc = new System.Windows.Forms.ColumnHeader();
            this.CPF = new System.Windows.Forms.ColumnHeader();
            this.Logr = new System.Windows.Forms.ColumnHeader();
            this.Num = new System.Windows.Forms.ColumnHeader();
            this.Bairro = new System.Windows.Forms.ColumnHeader();
            this.DTnasc = new System.Windows.Forms.DateTimePicker();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblErr = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblatualizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(214, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(545, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(165, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(18, 42);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(25, 15);
            this.lblRA.TabIndex = 3;
            this.lblRA.Text = "RA:";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(53, 39);
            this.txtRA.Name = "txtRA";
            this.txtRA.ReadOnly = true;
            this.txtRA.Size = new System.Drawing.Size(106, 23);
            this.txtRA.TabIndex = 0;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(18, 71);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(54, 15);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Telefone:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(82, 68);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(137, 23);
            this.txtTel.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(229, 71);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(485, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(411, 100);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(31, 15);
            this.lblCPF.TabIndex = 9;
            this.lblCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(448, 97);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(311, 23);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // lblLogr
            // 
            this.lblLogr.AutoSize = true;
            this.lblLogr.Location = new System.Drawing.Point(18, 129);
            this.lblLogr.Name = "lblLogr";
            this.lblLogr.Size = new System.Drawing.Size(72, 15);
            this.lblLogr.TabIndex = 11;
            this.lblLogr.Text = "Logradouro:";
            // 
            // txtLogr
            // 
            this.txtLogr.Location = new System.Drawing.Point(96, 126);
            this.txtLogr.Name = "txtLogr";
            this.txtLogr.Size = new System.Drawing.Size(249, 23);
            this.txtLogr.TabIndex = 6;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(351, 129);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(54, 15);
            this.lblNum.TabIndex = 13;
            this.lblNum.Text = "Número:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(411, 126);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(62, 23);
            this.txtNum.TabIndex = 7;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(479, 129);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(41, 15);
            this.lblBairro.TabIndex = 15;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(526, 126);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(233, 23);
            this.txtBairro.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::ATIVIDADE_POO_12112021_GIANPIEROGIGLIO.Properties.Resources.save1;
            this.btnSave.Location = new System.Drawing.Point(724, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // lvAlunos
            // 
            this.lvAlunos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvAlunos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.RA,
            this.Telefone,
            this.Email,
            this.datanasc,
            this.CPF,
            this.Logr,
            this.Num,
            this.Bairro});
            this.lvAlunos.GridLines = true;
            this.lvAlunos.Location = new System.Drawing.Point(18, 155);
            this.lvAlunos.Name = "lvAlunos";
            this.lvAlunos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvAlunos.Size = new System.Drawing.Size(625, 82);
            this.lvAlunos.TabIndex = 17;
            this.lvAlunos.UseCompatibleStateImageBehavior = false;
            this.lvAlunos.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 200;
            // 
            // RA
            // 
            this.RA.Text = "RA";
            this.RA.Width = 100;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 100;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 100;
            // 
            // datanasc
            // 
            this.datanasc.Text = "Data Nasc";
            this.datanasc.Width = 100;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            // 
            // Logr
            // 
            this.Logr.Text = "Logradouro";
            // 
            // Num
            // 
            this.Num.Text = "Número";
            // 
            // Bairro
            // 
            this.Bairro.Text = "Bairro";
            // 
            // DTnasc
            // 
            this.DTnasc.Location = new System.Drawing.Point(141, 97);
            this.DTnasc.Name = "DTnasc";
            this.DTnasc.Size = new System.Drawing.Size(260, 23);
            this.DTnasc.TabIndex = 4;
            this.DTnasc.Value = new System.DateTime(2021, 11, 10, 0, 0, 0, 0);
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(18, 100);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(117, 15);
            this.lblDtNasc.TabIndex = 19;
            this.lblDtNasc.Text = "Data de Nascimento:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(678, 444);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(35, 35);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.MouseLeave += new System.EventHandler(this.btnLimpar_MouseLeave);
            this.btnLimpar.MouseHover += new System.EventHandler(this.btnLimpar_MouseHover);
            // 
            // lblErr
            // 
            this.lblErr.AllowDrop = true;
            this.lblErr.AutoSize = true;
            this.lblErr.Location = new System.Drawing.Point(18, 9);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(12, 15);
            this.lblErr.TabIndex = 21;
            this.lblErr.Text = "-";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.Color.Transparent;
            this.lblSave.Enabled = false;
            this.lblSave.Location = new System.Drawing.Point(722, 426);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(38, 15);
            this.lblSave.TabIndex = 22;
            this.lblSave.Text = "Salvar";
            this.lblSave.Visible = false;
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.Enabled = false;
            this.lblClear.Location = new System.Drawing.Point(673, 426);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(44, 15);
            this.lblClear.TabIndex = 24;
            this.lblClear.Text = "Limpar";
            this.lblClear.Visible = false;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(18, 254);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.RowTemplate.Height = 25;
            this.dgvAlunos.Size = new System.Drawing.Size(625, 225);
            this.dgvAlunos.TabIndex = 25;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = global::ATIVIDADE_POO_12112021_GIANPIEROGIGLIO.Properties.Resources.recarregar;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizar.Location = new System.Drawing.Point(649, 254);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(35, 35);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            this.btnAtualizar.MouseLeave += new System.EventHandler(this.btnAtualizar_MouseLeave);
            this.btnAtualizar.MouseHover += new System.EventHandler(this.btnAtualizar_MouseHover);
            // 
            // lblatualizar
            // 
            this.lblatualizar.AutoSize = true;
            this.lblatualizar.BackColor = System.Drawing.Color.Transparent;
            this.lblatualizar.Enabled = false;
            this.lblatualizar.Location = new System.Drawing.Point(641, 236);
            this.lblatualizar.Name = "lblatualizar";
            this.lblatualizar.Size = new System.Drawing.Size(53, 15);
            this.lblatualizar.TabIndex = 27;
            this.lblatualizar.Text = "Atualizar";
            this.lblatualizar.Visible = false;
            // 
            // CadastroAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 491);
            this.Controls.Add(this.lblatualizar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.DTnasc);
            this.Controls.Add(this.lvAlunos);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblLogr);
            this.Controls.Add(this.txtLogr);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "CadastroAlunos";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.CadastroAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private Label lblRA;
        private TextBox txtRA;
        private Label lblTel;
        private TextBox txtTel;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lblLogr;
        private TextBox txtLogr;
        private Label lblNum;
        private TextBox txtNum;
        private Label lblBairro;
        private TextBox txtBairro;
        private Button btnSave;
        private ListView lvAlunos;
        private ColumnHeader Nome;
        private ColumnHeader RA;
        private ColumnHeader Telefone;
        private DateTimePicker DTnasc;
        private ColumnHeader Email;
        private ColumnHeader datanasc;
        private ColumnHeader CPF;
        private ColumnHeader Logr;
        private ColumnHeader Num;
        private ColumnHeader Bairro;
        private Label lblDtNasc;
        private Button btnLimpar;
        private Label lblErr;
        private Label lblSave;
        private Label lblClear;
        private DataGridView dgvAlunos;
        private Button btnAtualizar;
        private Label lblatualizar;
    }
}
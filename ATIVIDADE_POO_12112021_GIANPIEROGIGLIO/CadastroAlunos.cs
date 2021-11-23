using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ATIVIDADE_POO_12112021_GIANPIEROGIGLIO
{
    public partial class CadastroAlunos : Form
    {
        Alunos aluno = new Alunos();
        List<Alunos> listalunos = new List<Alunos>();
        connectionBD conexao = new connectionBD();

        public CadastroAlunos()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                aluno.numero = int.Parse(txtNum.Text);
                aluno.nome = txtNome.Text;
                aluno.telefone = txtTel.Text;
                aluno.bairro = txtBairro.Text;
                aluno.cpf = txtCPF.Text;
                aluno.email = txtEmail.Text;
                aluno.logradouro = txtLogr.Text;
                aluno.dataNascimento = DateTime.Parse(DTnasc.Value.Date.ToString("yyyy/MM/dd"));
                this.listalunos.Add(aluno);

                ListViewItem lista = new ListViewItem(new[] {aluno.nome, aluno.RA.ToString(), aluno.telefone, aluno.email, aluno.dataNascimento.ToString("dd/MM/yyyy"), aluno.cpf.ToString(),aluno.logradouro, aluno.numero.ToString(), aluno.bairro});
                lvAlunos.Items.Add(lista);
                conexao.ConectarBanco();
                conexao.InserirDados(aluno);
            }catch (Exception ex)
            {
                lblErr.Text = ex.Message;
            }
        }

        private string RaGen()
        {
            char[] cpfArray = txtCPF.Text.ToCharArray();

            string RA = cpfArray[0].ToString();

            for (int index = 1; index < 5; index++)
            {
                RA += cpfArray[index].ToString();
            }

            RA += DTnasc.Value.Year.ToString();
            return RA;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                string RA = RaGen();
                aluno.RA = int.Parse(RA);
                txtRA.Text = aluno.RA.ToString();
            }
            catch (Exception ex)
            {
                lblErr.Text = ex.Message;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtLogr.Text = "";
            txtNome.Text = "";
            txtNum.Text = "";
            txtRA.Text = "";
            txtTel.Text = "";
            DTnasc.Value = DateTime.Now;
        }

        private void btnLimpar_MouseHover(object sender, EventArgs e)
        {
            lblClear.Visible = true;
            lblClear.Enabled = true;
        }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        {
            lblClear.Visible = false;
            lblClear.Enabled = false;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            lblSave.Enabled = true;
            lblSave.Visible = true;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            lblSave.Enabled = false;
            lblSave.Visible = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string sConn = conexao.ConectarBanco();
            if (sConn == "")
            {
                DataSet dataSet = conexao.BuscarDados();
                //atribui a resultado a propriedade DataSource do DataGrid
                dgvAlunos.DataSource = dataSet;
                dgvAlunos.DataMember = "alunos";
            }
        }

        private void btnAtualizar_MouseHover(object sender, EventArgs e)
        {
            lblatualizar.Enabled = true;
            lblatualizar.Visible = true;
        }

        private void btnAtualizar_MouseLeave(object sender, EventArgs e)
        {
            lblatualizar.Enabled=false;
            lblatualizar.Visible=false;
        }

        private void CadastroAlunos_Load(object sender, EventArgs e)
        {
            string sConn = conexao.ConectarBanco();
            if (sConn == "")
            {
                DataSet dataSet = conexao.BuscarDados();
                //atribui a resultado a propriedade DataSource do DataGrid
                dgvAlunos.DataSource = dataSet;
                dgvAlunos.DataMember = "alunos";
            }
        }
    }
}
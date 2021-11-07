using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();
            Grp_Codigo.Text = "Código";
            Grp_DadosPessoais.Text = "Dados pessoais";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros;";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Lbl_Genero.Text = "Genero";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Lbl_Cidade.Text = "Cidade";
            Chk_TemPai.Text = "Pai desconhecido";
        }

        private void Frm_CadastroCliente_UC_Load(object sender, EventArgs e)
        {

        }

        private void byteBankToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_NomePai_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grp_DadosPessoais_Enter(object sender, EventArgs e)
        {

        }

        private void Lbl_NomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void Grp_Codigo_Enter(object sender, EventArgs e)
        {

        }

        private void Grp_Outros_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_Telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;

            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }
    }
}

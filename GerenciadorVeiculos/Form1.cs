using System;
using System.Windows.Forms;

namespace GerenciadorVeiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTipo.SelectedIndex = 0;
            AtualizarRotulo();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarRotulo();
        }

        private void AtualizarRotulo()
        {
            if (cmbTipo.SelectedItem != null && cmbTipo.SelectedItem.ToString() == "Carro")
            {
                lblParametro.Text = "Quantidade de Portas:";
            }
            else
            {
                lblParametro.Text = "Cilindradas:";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string modelo = txtModelo.Text.Trim();
                decimal precoBase = Convert.ToDecimal(txtPrecoBase.Text);
                int parametro = Convert.ToInt32(txtParametro.Text);
                string tipo = cmbTipo.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(modelo))
                {
                    MessageBox.Show("Preencha o modelo do veículo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Veiculo veiculo = null;

                // Instanciação polimórfica utilizando as classes criadas por você
                if (tipo == "Carro")
                {
                    veiculo = new Carro(modelo, precoBase, parametro);
                }
                else
                {
                    veiculo = new Moto(modelo, precoBase, parametro);
                }

                VeiculoDAO dao = new VeiculoDAO();
                dao.Inserir(veiculo);

                MessageBox.Show("Veículo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha os campos numéricos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtModelo.Clear();
            txtPrecoBase.Clear();
            txtParametro.Clear();
            cmbTipo.SelectedIndex = 0;
            AtualizarRotulo();
            txtModelo.Focus();
        }
    }
}
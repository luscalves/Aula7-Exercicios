using ReaLTaiizor.Forms;

namespace Aula7
{
    public partial class Exercicio1 : MaterialForm
    {
        public Exercicio1()
        {
            InitializeComponent();

            if (e1 == null)
            {
                btnImprimir.Enabled = false;
                btnCalcula.Enabled = false;

            }
        }

        Empregado e1 = null;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (e1 == null)
            {
                e1 = new Empregado();
                e1.nome = txtNome.Text;
                e1.departamento = txtDepartamento.Text;
                e1.horasTrabalhadas = double.Parse(txtHoras.Text);
                e1.salarioPorHora = double.Parse(txtSalario.Text);

                btnImprimir.Enabled = true;
                btnCalcula.Enabled = true;
            }
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voce vai receber: " + e1.calculaSalarioMensal());
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(e1.mostraDados());
        }
    }
}

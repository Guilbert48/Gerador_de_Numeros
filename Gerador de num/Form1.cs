namespace Gerador_de_num
{
    public partial class Gerador : Form
    {
        public Gerador()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxRes.Text = "";

            int numeroGerado;
            if (textBoxQtd.Text != "")
            {
                int qtdNum = int.Parse(textBoxQtd.Text);
                Random random = new Random();

                for (int i = 0; i < qtdNum; i++)
                {
                    numeroGerado = random.Next(0, 9);
                    textBoxRes.Text += numeroGerado.ToString();
                }
            }
            else
            {
                MessageBox.Show("Por favor digite um valor", "Erro");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxRes.Text = "";
            textBoxQtd.Text = "";
            textBoxQtd.Focus();
        }
    }
}

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
            int numeroGerado;

            int qtdNum = int.Parse(textBoxQtd.Text);
            Random random = new Random();

            for(int i = 0; i < qtdNum; i++)
            {
               numeroGerado = random.Next(0, 9);
                textBoxRes.Text += numeroGerado.ToString();
            }

        }
    }
}

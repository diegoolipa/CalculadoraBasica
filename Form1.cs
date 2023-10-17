namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = "7";
            //txtResultado.Text = txtResultado.Text + "7";
            txtResultado.Text += "7";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "+";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            String dato = txtResultado.Text;
            int resultado = 0;

            string[] valores = dato.Split('+');

            foreach (string valor in valores)
            {
                int numero = int.Parse(valor);
                resultado += numero;
            }

            txtResultado.Text = resultado.ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
    }
}
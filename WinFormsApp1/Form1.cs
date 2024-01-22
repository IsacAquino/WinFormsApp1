namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            textBox1.Text = $"Número de clicks: {contador}";
        }
    }
}
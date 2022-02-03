namespace Semaforo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int numero = Convert.ToInt32(textBox1.Text);
            calculadora(numero);
            if (numero > 12)
            {
                string mensage = "Lo siento no se puede ejecutar la tarea porque no se aceptan numero mayores a 12";
                string titulo = "Oh paso algo...";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBox.Show(mensage, titulo, boton);
            }
        }
        private void calculadora(int x)
        {
            
            for(int i =1; i <= 12; i++)
            {
                if ((x >= 1) && (x <= 12))
                {
                    label1.Text += x + " x " + Convert.ToInt32(i) + " = " + Convert.ToInt32(x * i) + "\n";
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fom = new Form2();
            fom.Show();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
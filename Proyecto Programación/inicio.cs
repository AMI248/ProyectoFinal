namespace Proyecto_Programación
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Form form1 = new Opciones();
            this.Hide();  // Ocultamos el Formulario Actual
            form1.ShowDialog(); // Muestra el Formulario #2 Registros
            this.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
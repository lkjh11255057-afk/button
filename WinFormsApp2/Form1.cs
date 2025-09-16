namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "¬õ¿O";
            pictureBox1.BackColor = Color.Red;
            pictureBox1.BackgroundImage = Properties.Resources.images;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "ºñ¿O";
            pictureBox1.BackColor = Color.Green;
            pictureBox1.BackgroundImage = Properties.Resources.¤U¸ü;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "¶À¿O";
              pictureBox1.BackColor = Color.Yellow;
            pictureBox1.BackgroundImage = Properties.Resources._1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

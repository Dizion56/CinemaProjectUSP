using System;
using System.Windows.Forms;

namespace CinemaProjectUSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movies_Schedule_Form msf = new Movies_Schedule_Form();
            msf.Show();
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BuyTicketsForm btf = new BuyTicketsForm();
            btf.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostWatchedMoviesForm mwm = new MostWatchedMoviesForm();
            mwm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}

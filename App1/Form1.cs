namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buttona t?kland?");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Buttonun üzerine gelindi");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Buttonun üzerinden ayr?ld?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this => bulundu?umuz instanc? ifade eder..
            Random rnd = new Random();
            int dinamikGenislik = rnd.Next(132, this.Width);

            button1.Text = "T?kland?";
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Width = dinamikGenislik;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Aç?ld?");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            Random rnd = new Random();
            int red = rnd.Next(0, 255);
            int green = rnd.Next(0, 255);
            int blue = rnd.Next(0, 255);

            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
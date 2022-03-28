namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string[] ogrenciisimleri = new string[4];
        List<string> ogrenciIsimleri = new List<string>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ogrenciIsimleri.Add(txtIsim.Text);

            txtIsim.Clear(); // textini sil..
            txtIsim.Focus(); // txtIsim'e focuslan...
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lstOgrenciler.Items.Clear(); // listbox'i temizle...
            foreach (var item in ogrenciIsimleri)
                lstOgrenciler.Items.Add(item);
        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
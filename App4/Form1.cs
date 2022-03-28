namespace App4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            kullanicilar = new Dictionary<string, string>();
            kullanicilar.Add("Recep", "123");
            kullanicilar.Add("Emre", "1234");
            kullanicilar.Add("Kaan", "12345");
        }

        int hak = 3;
        Dictionary<string, string> kullanicilar;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {


            //SOLÝD PRENSÝBLERÝNDEN S'YÝ ARAÞTIRINIZ....


            #region MyRegion

            List<int> nums = new List<int>() { 1, 2, 3, 5, 8, 34, 60, 49, 22, 1 };
            var r = (from na in nums
                     where na < 10
                     select na).ToList();

            var re = nums.Where(c => c < 10).ToList();
            var ree = nums.First(c => c == 1);
            var reeeeee = nums.FirstOrDefault(c => c == 99);

            //var reee = nums.Single(c => c == 1);
            //First  => tek bir obje çekmek için kullanýlýr. eðer koleksiyonda o objeden birden fazla varsa ilkini verir...eðer aranan obje dizide koleksiyonda yoksa hata verir. Bu yüzden First yerine FirstOrDefault kullanýlýr
            // FirstOrDefault =>çekilen objenin ilki. eðer obje koleksiyonda yoksa default deðeri döner...
            //Single => tek bir obje çekmek için kullanýlýr.eðer koleksiyonda o objeden birden fazla varsa hata verir...

            #endregion
            // yöntem 1.
            var list = (from a in kullanicilar
                        where a.Key == txtKullaniciAdi.Text && a.Value == txtSifre.Text
                        select a).FirstOrDefault();

            // yöntem 2.
            // c# lambda ifadesi => isimsiz fonksiyonlardýr..linq ifadelerinin kýsatlýtmýþ versiyonlarýný yazmak için kulanýlýr..
            // var list2 = kullanicilar.Where(k => k.Key == txtKullaniciAdi.Text && k.Value == txtSifre.Text);
            var obj3 = kullanicilar.FirstOrDefault(k => k.Key == txtKullaniciAdi.Text && k.Value == txtSifre.Text);
            if (list.Key != null)
            {
                MessageBox.Show("Hoþ Geldin Admin");

                Form2 frm = new Form2();
                frm.Show(); // formu aç...
                this.Hide(); // mevcut formu gizle...
            }
            else
            {
                MessageBox.Show($"Hatalý bilgi. Kalan hakkýnýz {hak--}");
            }

            if (hak == 0)
                btnGirisYap.Enabled = false;
        }
    }
}
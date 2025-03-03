namespace Öğrenci_Sınav_Notu_Hesaplama_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            double ort, not1, not2, proje;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            not1 = Convert.ToInt16(textBox3.Text);
            not2 = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);
            ort = (not1 + not2 + proje) / 3;
            listBox1.Items.Add(ad + " " + soyad + " Ortalama " + ort);



        }
    }
}

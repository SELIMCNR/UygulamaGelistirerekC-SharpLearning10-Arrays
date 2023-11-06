namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Diziler indisler halinde ve 0.indisten baþlar
            string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Aslý", "Hakan", "Ayþe", "Demet" };
            label1.Text = kisiler[0];
            for (int i = 0; i < kisiler.Length; i++)
            {
                listBox1.Items.Add(kisiler[i]);
            }

            int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            label1.Text = sayilar[5].ToString();
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox1.Items.Add(i);
            }

            double[] sayiOndalik = { 10.0, 10.1, 10.2, 10.3, 10.4 };
            for (int i = 0; i < sayiOndalik.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    listBox1.Items.Add("Sayilar: " + sayilar[i]);
                }

            }
            char[] harfler = { 'A', 'B', 'C', 'D', 'E' };

            foreach (char c in harfler)
            {
                listBox1.Items.Add("Harfler : " + c);
            }

            int toplam = 0;
            int[] sinavlar = { 70, 65, 85, 100, 90 };
            foreach (int x in sinavlar)
            {
                listBox1.Items.Add(x);
                toplam = toplam + x;
            }
            label1.Text = toplam.ToString();
            int ortalama = toplam / sinavlar.Length;
            label2.Text = ortalama.ToString();
        }


    }
}
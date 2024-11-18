namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _ekranTemizlenecekMi;
        double _ilkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                label1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                label1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                label1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                label1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                label1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                label1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                label1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                label1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                label1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                label1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(label1.Text);
            double sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;

            }
            label1.Text = Convert.ToString(sonuc);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text=="0")
            {
                label1.Text = "0";
            }
            else if (_ekranTemizlenecekMi)
            {
                label1.Text = "0";
            }
            if (!label1.Text.Contains("."))
            {
                label1.Text += ".";
            }
            _ekranTemizlenecekMi = false;  
        }
    }
}
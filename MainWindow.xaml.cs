using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Rassokhin_PR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        float a, b;
        int count;
        bool znak = true;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void k0(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        private void k1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
        private void k2(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }
        private void k3(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }
        private void k4(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }
        private void k5(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }
        private void k6(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }
        private void k7(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }
        private void k8(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }
        private void k9(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        private void zap(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        private void plys(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }
        private void minys(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void ym(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void dele(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }
        private void povno(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
        private void kc(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
        private void nn(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

      






        
    }
}
    

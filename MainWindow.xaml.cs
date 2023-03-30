using Osztályok;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Tartaly> tartalyok = new List<Tartaly>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFelvesz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Tartaly ujTest;
                ujTest = new Tartaly(txtNev.Text, Convert.ToInt32(txtAel.Text), Convert.ToInt32(txtBel.Text), Convert.ToInt32(txtAel.Text));
                lbTartalyok.Items.Add(ujTest.Info());
                tartalyok.Add(ujTest);
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba");
            }

        }

        private void rdoKocka_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.IsEnabled = false;
            txtBel.IsEnabled = false;
            txtCel.IsEnabled = false;
            txtAel.Text = "10";
            txtBel.Text = "10";
            txtCel.Text = "10";


        }



        private void btntolt_Click(object sender, RoutedEventArgs e)
        {
           if (lbTartalyok.SelectedIndex>=0)
            {


                tartalyok[lbTartalyok.SelectedIndex].Tolt(Convert.ToDouble(txtMennyitTolt.Text));
                //MessageBox.Show(tartalyok[0].AktLiter.ToString());
                lbTartalyok.Items[lbTartalyok.SelectedIndex] = tartalyok[lbTartalyok.SelectedIndex].Info();
            }
        }

        private void btnDuplaz_Click(object sender, RoutedEventArgs e)
        {
            if (lbTartalyok.SelectedIndex>=0)
            {
                tartalyok[lbTartalyok.SelectedIndex].DuplazMeretet();
                lbTartalyok.Items[lbTartalyok.SelectedIndex] = tartalyok[lbTartalyok.SelectedIndex].Info();
            }

        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("szoveg.txt", append: true);
            for (int i = 0; i < lbTartalyok.Items.Count; i++)
            {

                string csvsor = $"{txtNev.Text};{txtAel.Text};{txtBel.Text};{txtCel.Text}";
                sw.WriteLine(csvsor);
            }
            sw.Close();
        }

        private void btnLeenged_Click(object sender, RoutedEventArgs e)
        {
            if (lbTartalyok.SelectedIndex>=0)
            {
                tartalyok[lbTartalyok.SelectedIndex].TeljesLeengedes();
                lbTartalyok.Items[lbTartalyok.SelectedIndex] = tartalyok[lbTartalyok.SelectedIndex].Info();
            }
 

        }

        private void rdoKocka_Unchecked(object sender, RoutedEventArgs e)
        {
            txtAel.IsEnabled = true;
            txtBel.IsEnabled = true;
            txtCel.IsEnabled = true;
            txtAel.Text = "";
            txtBel.Text = "";
            txtCel.Text = "";
        }
    }
}

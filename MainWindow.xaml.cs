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

namespace Kuntosali
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //double Paino;
        //double pituuus;
        //double painoindex;
        //double rasvaprosentti;
        private DataSet1 set = new DataSet1();
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void ButtonTallenna_Click(object sender, RoutedEventArgs e)
        //{
        //    float luku1 = float.Parse(this.textBoxPaino.Text);
        //    float luku2 = float.Parse(this.textBoxPituus.Text);
        //    float summa = luku1 / luku2 / luku2;
        //    this.textBoxTulos.Text = Math.Round( summa, 2, MidpointRounding.ToEven).ToString();
        //}

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonIndex_Click(object sender, RoutedEventArgs e)
        {

            float luku1 = float.Parse(this.textBoxPaino.Text);
            float luku2 = float.Parse(this.textBoxPituus.Text);
            float summa = luku1 / luku2 / luku2;
            this.textBoxTulos.Text = Math.Round(summa, 2, MidpointRounding.ToEven).ToString();
        }

        private void radioButtonLapsi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void radioButtonMies_Click(object sender, RoutedEventArgs e)
        {

        }

        private void radioButtonNainen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rasvaProsenttiLaske_Click(object sender, RoutedEventArgs e)
        {

            float index = float.Parse(this.textBoxPainoIndex.Text);
            int ika = int.Parse(this.textBoxIka.Text);
            float summa2 = index / ika;

            this.textboxRasvaProsentti.Text = Math.Round((1.20 * index) + (0.23 * ika) - (10.8 * 1) - 5.4, 2, MidpointRounding.ToEven).ToString();
        }

        private void radioButtonLapsi_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButtonMies_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButtonNainen_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void LaskeNainen_Click(object sender, RoutedEventArgs e)
        {

            float index = float.Parse(this.textBoxPainoIndex.Text);
            int ika = int.Parse(this.textBoxIka.Text);
            float summa2 = index / ika;

            this.textboxRasvaProsentti.Text = Math.Round((1.20 * index) + (0.23 * ika) - (10.8 * 0) - 5.4, 2, MidpointRounding.ToEven).ToString();

        }

        private void Lasketytto_Click(object sender, RoutedEventArgs e)
        {

            float index = float.Parse(this.textBoxPainoIndex.Text);
            int ika = int.Parse(this.textBoxIka.Text);
            float summa2 = index / ika;

            this.textboxRasvaProsentti.Text = Math.Round((1.51 * index) - (0.70 * ika) - (3.6 * 0) + 1.4, 2, MidpointRounding.ToEven).ToString();
        }

        private void LaskePoika_Click(object sender, RoutedEventArgs e)
        {

            float index = float.Parse(this.textBoxPainoIndex.Text);
            int ika = int.Parse(this.textBoxIka.Text);
            float summa2 = index / ika;

            this.textboxRasvaProsentti.Text = Math.Round((1.51 * index) - (0.70 * ika) - (3.6 * 1) + 1.4, 2, MidpointRounding.ToEven).ToString();
        }

      public void buttonTallenna_Click(object sender, RoutedEventArgs e)
        {


            DataSet1 ds = new DataSet1();
            
            DataSet1.KuntosaliRow rivi = ds.Kuntosali.NewKuntosaliRow();
            String strpaino = this.textBoxPaino.Text;
            String strpituus = this.textBoxPituus.Text;
            String strpainoindex = this.textBoxPainoIndex.Text;
            String strrasvaprosentti = this.textboxRasvaProsentti.Text;
            string strpaivamaara  = this.DatePickerpaivamaara.Text;
            // rivi.paivamaara = this.Text;
            
          //  rivi.Id = int.Parse
          //  rivi.paivamaara  = DateTime.Parse(strpaivamaara.Substring(0));
            rivi.paivamaara = this.DatePickerpaivamaara.SelectedDate.Value;
            rivi.etunimi = this.textBoxEtunimi.Text;
            rivi.sukunimi = this.textBoxSukunimi.Text;
            rivi.Paino   = double.Parse(strpaino.Substring(0));
            rivi.pituus =  double.Parse(strpituus.Substring(0));
            rivi.painoindex = double.Parse(strpainoindex.Substring(0));
            rivi.rasvaprosentti =  double.Parse(strrasvaprosentti.Substring(0));
            ds.Kuntosali.AddKuntosaliRow(rivi);
            DataSet1TableAdapters.KuntosaliTableAdapter adap =
           new DataSet1TableAdapters.KuntosaliTableAdapter();
           // adap.Fill(ds.Kuntosali);

             adap.Update(ds.Kuntosali);
        }

        private void textBoxPituus_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
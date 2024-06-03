using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using System;
namespace Harjoitus20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Opiskelija> OpiskelijaLista = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void opiskelijaPanel_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Opiskelija opiskelija in OpiskelijaLista)
            {
                opiskelijaPanel.Children.Add(new TextBlock() { Text = $"Etunimi: {opiskelija.Etunimi}, Sukunimi: {opiskelija.Sukunimi}, OpiskelijaID: {opiskelija.OpiskelijaID}, Sähköposti: {opiskelija.sähköposti}, Puhelinnumero: {opiskelija.puhelinnumero}" });
            }
        }

        private void lisääOpiskelija_Click(object sender, RoutedEventArgs e)
        {
            UserAddDialog addDialog = new UserAddDialog("Etunimi", "Sukunimi", "OpiskelijaID", "Sähköposti", "Puhelinnumero");
            addDialog.ShowDialog();
            if (addDialog.DialogResult == true)
            {
                OpiskelijaLista.Add(new Opiskelija(addDialog.Vastaus1, addDialog.Vastaus2, Convert.ToInt32(addDialog.Vastaus3), addDialog.Vastaus4, Convert.ToInt32(addDialog.Vastaus5)));
                opiskelijaPanel.Children.Add(new TextBlock() { Text = $"Etunimi: {addDialog.Vastaus1}, Sukunimi: {addDialog.Vastaus2}, OpiskelijaID: {addDialog.Vastaus3}, Sähköposti: {addDialog.Vastaus4}, Puhelinnumero: {addDialog.Vastaus5}" });
            }
        }

        private void poistaOpiskelija_Click(object sender, RoutedEventArgs e)
        {
            UserDeleteDialog rmDialog = new UserDeleteDialog("OpiskelijaID");
            rmDialog.ShowDialog();
            if (rmDialog.DialogResult == true)
            {
                for (int i = 0; i < OpiskelijaLista.Count(); i++)
                {
                    if (OpiskelijaLista[i].OpiskelijaID == Convert.ToInt32(rmDialog.Vastaus1))
                    {
                        OpiskelijaLista.Remove(OpiskelijaLista[i]);
                        break;
                    }
                }
                opiskelijaPanel.Children.Clear();
                foreach (Opiskelija opiskelija in OpiskelijaLista)
                {
                    opiskelijaPanel.Children.Add(new TextBlock() { Text = $"Etunimi: {opiskelija.Etunimi}, Sukunimi: {opiskelija.Sukunimi}, OpiskelijaID: {opiskelija.OpiskelijaID}, Sähköposti: {opiskelija.sähköposti}, Puhelinnumero: {opiskelija.puhelinnumero}" });
                }
            }
        }
        private void SerializeOpiskelijat()
        {
            string opiskelijaListaOutput = JsonConvert.SerializeObject(OpiskelijaLista);
            File.WriteAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "opiskelijat.txt"), opiskelijaListaOutput); 
            //MessageBox.Show("Tallennettu");
        }

        private void DeserializeOpiskelijat()
        {
            try 
            { 
                string opiskelijaListaInput = File.ReadAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "opiskelijat.txt")); 
                OpiskelijaLista = JsonConvert.DeserializeObject<List<Opiskelija>>(opiskelijaListaInput);
                foreach (Opiskelija opiskelija in OpiskelijaLista)
                {
                    opiskelijaPanel.Children.Add(new TextBlock() { Text = $"Etunimi: {opiskelija.Etunimi}, Sukunimi: {opiskelija.Sukunimi}, OpiskelijaID: {opiskelija.OpiskelijaID}, Sähköposti: {opiskelija.sähköposti}, Puhelinnumero: {opiskelija.puhelinnumero}" });
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            SerializeOpiskelijat();
        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            DeserializeOpiskelijat();
        }
    }
}
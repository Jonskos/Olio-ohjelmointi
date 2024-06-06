using Harjoitus26.View.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Harjoitus26
{
    internal static class TehtäväLista
    {
        private static ObservableCollection<Tehtävä> tehtäväLista = new ObservableCollection<Tehtävä>();
        private static StackPanel tehtäväPanel = ((MainWindow)System.Windows.Application.Current.MainWindow).tehtäväPanel;
        public static void Add(Tehtävä tehtävä)
        {
            try
            {
               tehtäväLista.Add(tehtävä);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Clear()
        {
            tehtäväLista?.Clear();
        }
        public static void Remove(string tehtäväNimi)
        {
            try
            {
                for (int i = 0; i < tehtäväLista.Count; i++)
                {
                    if (tehtäväLista[i].Nimi.ToString() == tehtäväNimi)
                    {
                        tehtäväLista.Remove(tehtäväLista[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //    foreach (Tehtävä tehtävä in tehtäväLista)
            //{
            //    if (tehtävä.Nimi.ToString() == tehtäväNimi)
            //    {
            //        tehtäväLista.Remove(tehtävä);
            //    }
            //}

        }
        public static ObservableCollection<Tehtävä> Get()
        {
            return tehtäväLista;
        }
    }
}

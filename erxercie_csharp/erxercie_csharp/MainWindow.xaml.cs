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
using Library.DataAcess;
using Library.DataAcess.Dao;
using Library.Metier;

namespace erxercie_csharp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
/*
            List<Artwork> artworkList = new List<Artwork>();
            artworkList.Add(new Artwork
            {
                Id = 1,
                Comment = "Comment",
                Title = "Titre",
            });
*/
            //DataGrid.ItemsSource = artworkList;

            MyDataContext myDataContext = new MyDataContext();
            //DataGrid.ItemsSource = myDataContext.Auteur.ToList();
            //var kwfbh = " ";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var loginText = login.Text;
            var mdpText = mdp.Text;
            this.Close();
        }
    }
}

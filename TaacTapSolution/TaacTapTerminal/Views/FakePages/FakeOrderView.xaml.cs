using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TaacTapTerminal.SampleData;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TaacTapTerminal.Views.FakePages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FakeOrderView : Page
    {
        public FakeOrderView()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;

        }
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            using (var database = new FakeDbContext())
            {
                DbContextOrders.ItemsSource = database.DbContextOrders.ToList();
                database.Database.EnsureCreated();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            using (var database = new FakeDbContext())
            {

                var order = new DbContextOrder
                {

                    Location = $"Table  {DateTime.Now}"

                };

                // Note how only two lines of code update and save changes to
                // the data source and how there’s no reference to ‘SQLite’
                database.DbContextOrders.Add(order);
                database.SaveChanges();

                //Update the ItemsSource of the ListView
                DbContextOrders.ItemsSource = database.DbContextOrders.ToList();


            }
        }
    }
}
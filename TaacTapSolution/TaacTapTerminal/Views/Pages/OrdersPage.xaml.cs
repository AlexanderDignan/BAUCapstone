using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TaacTapTerminal.Models;
using TaacTapTerminal.Models.LocalData;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TaacTapTerminal.Views.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProgressStationPage : Page
    {
        public ProgressStationPage()
        {
            this.InitializeComponent();
            Loaded += ProgressStationPage_Loaded;
        }
        private void ProgressStationPage_Loaded(object sender, RoutedEventArgs e)
        {
            using (var database = new LocalStorageDbContext())
            {
              
                Orders.ItemsSource = database.Orders.ToList();
                database.Database.EnsureCreated();
            }
        }


        private async void Add_Click(object sender, RoutedEventArgs e)
        {
            var messageBox = new MessageDialog("Is this order Correct?");
            messageBox.Title = "Verify Order";
            messageBox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            messageBox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await messageBox.ShowAsync();

            if ((int)res.Id == 0)
            {
                //this.Frame.Navigate(typeof(MainPage));
                using (var database = new LocalStorageDbContext())
                {
                    var order = new Order
                    {
                        OrderId = 1,
                        UserId = 1,
                        TableId = 1,
                        DateTimeCreated = DateTime.Now,
                        TotalPrice = 19.00,
                        //MenuItems = new HashSet<MenuItem> ()
                    };
                    

                    // Note how only two lines of code update and save changes to
                    // the data source and how there’s no reference to ‘SQLite’
                    database.Orders.Add(order);
                    database.SaveChanges();

                    //Update the ItemsSource of the ListView
                    Orders.ItemsSource = database.Orders.ToList();
                }
            } else
            {
                var errorBox = new MessageDialog("Explain what is wrong to the customer");
                errorBox.Title = "Invalid Order";
                errorBox.Commands.Add(new UICommand { Label = "OK", Id = 0 });
                var ress = await errorBox.ShowAsync();
            }
           

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void CheckItemClick(object sender, ItemClickEventArgs e)
        {
            Order output = e.ClickedItem as Order;
            double totalPrice = output.TotalPrice;
            var messageBox = new MessageDialog("Is this order Correct? \n"  +  "$" + totalPrice);
            messageBox.Title = "Verify Order";
            messageBox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            messageBox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await messageBox.ShowAsync();

            if ((int)res.Id == 0)
            {

                using (var database = new LocalStorageDbContext())
                {
                    database.Orders.Remove(output);
                    database.SaveChanges();

                    //Update the ItemsSource of the ListView
                    Orders.ItemsSource = database.Orders.ToList();
                }
            }
            else
            {
                var errorBox = new MessageDialog("Explain what is wrong to the customer");
                errorBox.Title = "Invalid Order";
                errorBox.Commands.Add(new UICommand { Label = "OK", Id = 0 });
                var ress = await errorBox.ShowAsync();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TaacTapTerminal.Models;
using TaacTapTerminal.ViewModels;
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

namespace TaacTapTerminal.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FakeViewxaml : Page
    {
        public FakeViewxaml()
        {
            this.InitializeComponent();
            FakeRestaurantViewModel = new FakeRestaurantViewModel("Office");
        }
        public FakeRestaurantViewModel FakeRestaurantViewModel { get; set; }
    }
}

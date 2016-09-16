using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.ViewModels 
{

    public class MainPageViewModel : ViewModelBase
    {
        private string _appName;
        private string _appNameColour;
       
        public MainPageViewModel()
        {
            
            AppName = "TaacTapApp";
            AppNameColour = "Gold";
            
        }
       
        public string AppName
        {
            get
            {
                return _appName;
            }
            set
            {
                Set(() => AppName, ref _appName, value);
            }
        }
        public string AppNameColour
        {
            get
            {
                return _appNameColour;
            }
             set
            {
                Set(() => AppNameColour, ref _appNameColour, value);
            }
        }
    
    }
}

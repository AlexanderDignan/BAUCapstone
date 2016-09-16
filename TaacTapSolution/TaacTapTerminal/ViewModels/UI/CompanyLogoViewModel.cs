using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.Models
{
    public class CompanyLogoViewModel : ViewModelBase
    {
        private string _logo;
        private string _width;
        private string _height;
        public CompanyLogoViewModel()
        {
            Width = "120";
            Height = "100";
            Logo = "/Images/tcLogobc_med.png";


        }
        public string Width
        {
            get
            {
                return _width;
            }
            set
            {
                Set(() => Width, ref _width, value);
            }
        }
        public string Height
        {
            get
            {
                return _height;
            }
            set
            {
                Set(() => Height, ref _height, value);
            }
        }

        public string Logo
        {
            get
            {
                return _logo;
            }
            set
            {
                Set(() => Logo, ref _logo, value);
            }
        }
    } 
}

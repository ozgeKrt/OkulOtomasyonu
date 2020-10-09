using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OkulOtomasyonu.Altyapi.PencereIslemleri
{
    public class UserControlIslemleri
    {
        public UserControlIslemleri()
        {
            
        }

        public static void UserControlCagirma(UserControl UserControl, Grid grid)
        {
            if (grid.Children.Count > 0)        //children grid içindeki nesne
            {
                grid.Children.Clear();
                grid.Children.Add(UserControl);
            }
            else
            {
                grid.Children.Add(UserControl);
            }
        }

    }
}

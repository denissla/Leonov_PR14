using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Leonov_PR14
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        Timer timer;
        int hours = 0, mins = 0, secs = 0, milliseconds = 0;

        private void btn_Start_Clicked(object sender, EventArgs e)
        {
           if(btnStartTimer.Text == "Старт")
            {
                timer = new Timer();
                timer.Interval = 1;   
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
                btnStartTimer.Text = "Стоп";
                lbl_data.Text = "";
            }
           else if (btnStartTimer.Text == "Стоп")
            {
                btnStartTimer.Text = "Старт";
                timer.Stop();
                timer = null;
                lbl_data.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            }
        
        }
        
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            milliseconds++;
            if (milliseconds >= 1000)
            {
              
                secs++;
                milliseconds = 0;
            }
            if (secs == 59)
            {
             
                mins++;
                secs = 0;

            }
            if (mins == 59)
            {
                hours++;
                mins = 0;
            }
            Device.BeginInvokeOnMainThread(() =>
            {
                lbl_result.Text = string.Format("{0:00}:{1:00}:{2:00}", hours, mins, secs);
            });
        }
        
    }
}
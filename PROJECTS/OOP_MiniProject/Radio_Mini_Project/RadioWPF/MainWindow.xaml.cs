using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
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
using RadioApp;

namespace RadioWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Radio radio;
        private MediaPlayer sound;
        private bool power;

        public MainWindow()
        {
            InitializeComponent();
            radio = new Radio();
            power = default;
            sound = new MediaPlayer();
        }


        private void PowerToggle(object sender, RoutedEventArgs e)
        {
            if (power is false)
            {
                power = true;
                radio.TurnOn();
                txtChannel.Content = "PICK A STATION...";
            }
            else
            {
                power = false;
                radio.TurnOff();
                sound.Pause();
                txtChannel.Content = radio.Play();

            }

        }

        private void StationClick(object sender, RoutedEventArgs e)
        {
            if (power is true)
            {
                var channel = Int32.Parse((e.Source as Button).Content.ToString());
                string ext = default;
                switch (channel)
                {
                    case 1:
                        try
                        {
                            sound.Open(new Uri("http://stream.live.vc.bbcmedia.co.uk/bbc_radio_one"));
                            sound.Play();
                            ext = "... BBC RADIO 1";

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case 2:
                        try
                        {
                            sound.Open(new Uri("http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1xtra_mf_p"));
                            sound.Play();
                            ext = "... BBC RADIO 1XTRA";
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case 3:
                        try
                        {
                            sound.Open(new Uri("http://media-ice.musicradio.com:80/ClassicFMMP3"));
                            sound.Play();
                            ext = "... CLASSIC FM";
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case 4:
                        try
                        {
                            sound.Open(new Uri("http://stream.live.vc.bbcmedia.co.uk/bbc_radio_three"));
                            sound.Play();
                            ext = "... BBC RADIO 3";
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                }
                radio.Channel = channel;
                txtChannel.Content = $"{radio.Play()}{ext}";

            }

        }
    }
}

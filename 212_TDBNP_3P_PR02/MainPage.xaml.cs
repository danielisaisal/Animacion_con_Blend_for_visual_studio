using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Playback;
using Windows.Media.Core;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace _212_TDBNP_3P_PR02
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MediaPlayer player = new MediaPlayer();

        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private async void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            sbInteraccion1.Begin();
            sbInteraccion2.Begin();
            sbInteraccion3.Begin();
            sbInteraccion4.Begin();
            sbInteraccion5.Begin();
            sbInteracion6.Begin();
            sbInteracion7.Begin();
            sbDormido.Begin();
            sbWalking.Begin();
            sbComer.Begin();

            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("UnderTale_Demo_Flowey.mp3");

            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();
        }
    }
}

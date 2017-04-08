using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BeatMaker
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        int count = 0;

 
        public MainPage()
        {
            this.InitializeComponent();

            
        }

        private void Button01_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (count == 0)
            {
                Drum.IsLooping = true;
                Drum.Play();
                count++;
            }
            else if (count == 1)
            {
                Drum.IsLooping = false;
                Drum.Pause();
                count--;   
            }

            
        }

        private void Button02_Tapped(object sender, TappedRoutedEventArgs e)
        {
            

            if (count == 0)
            {
                Techno.IsLooping = true;
                Techno.Play();
                count++;
            }
            else if (count == 1)
            {
                Techno.IsLooping = false;
                Techno.Pause();
                count--;

            }
        }

        private void Button03_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (count == 0)
            {
                BuildUp.IsLooping = true;
                BuildUp.Play();
                count++;
            }
            else if (count == 1)
            {
                BuildUp.IsLooping = false;
                BuildUp.Pause();
                count--;
            }
        }

        private void Button11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (count == 0)
            {
                TDrum.IsLooping = true;
                TDrum.Play();
                count++;
            }
            else if (count == 1)
            {
                TDrum.IsLooping = false;
                TDrum.Pause();
                count--;
            }
        }

        private void Button12_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (count == 0)
            {
                Guitar.IsLooping = true;
                Guitar.Play();
                count++;
            }
            else if (count == 1)
            {
                Guitar.IsLooping = false;
                Guitar.Pause();
                count--;
            }
        }

        private void Button13_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (count == 0)
            {
                SlowBeat.IsLooping = true;
                SlowBeat.Play();
                count++;
            }
            else if (count == 1)
            {
                SlowBeat.IsLooping = false;
                SlowBeat.Pause();
                count--;
            }

        }

        private void Button21_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (count == 0)
            {
                EDMLoop.IsLooping = true;
                EDMLoop.Play();
                count++;
            }
            else if (count == 1)
            {
                EDMLoop.IsLooping = false;
                EDMLoop.Pause();
                count--;
            }
        }
        private void Button22_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (count == 0)
            {
                EDMLoop2.IsLooping = true;
                EDMLoop2.Play();
                count++;
            }
            else if (count == 1)
            {
                EDMLoop2.IsLooping = false;
                EDMLoop2.Pause();
                count--;
            }

        }
        private void Button23_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (count == 0)
            {
                EDMLoop3.IsLooping = true;
                EDMLoop3.Play();
                count++;
            }
            else if (count == 1)
            {
                EDMLoop3.IsLooping = false;
                EDMLoop3.Pause();
                count--;
            }
        }

        //https://docs.microsoft.com/en-us/windows/uwp/files/quickstart-reading-and-writing-files

        private async void Save_Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Create sample file; replace if exists.
            Windows.Storage.StorageFolder storageFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile my_Saved_File = await storageFolder.CreateFileAsync("Song.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);

            using (IRandomAccessStream iRandomAccessStream = await my_Saved_File.OpenAsync(FileAccessMode.ReadWrite))
            {
                using (DataWriter writer = new DataWriter(iRandomAccessStream))
                {
                    writer.WriteString(Song_Name.Text);
                    await writer.StoreAsync(); 
                }

            }
        }

        private async void Load_Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile my_Saved_File = await storageFolder.GetFileAsync("Song.txt");


            var stream = await my_Saved_File.OpenAsync(Windows.Storage.FileAccessMode.Read);
            using (StreamReader reader = new StreamReader(stream.AsStream()))
            {
                Song_Name.Text = reader.ReadToEnd();
                
            }
        }

        private void Record_Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //To be Implemented
        }

    }
}

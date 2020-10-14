using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ReadWriteFileUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        StorageFile storageFile;
        StorageFolder storageFolder;
        string content = "Content";
        string file = "Lok.txt";

        public MainPage()
        {
            this.InitializeComponent();
            //Task.Run(() => CreateFileAsync());
            CreateFileAsync().GetAwaiter();
            WriteToFileAsync().GetAwaiter();
        }

        private async Task CreateFileAsync()
        {
            //StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
             storageFolder = KnownFolders.DocumentsLibrary;

             await storageFolder.CreateFileAsync(file,CreationCollisionOption.ReplaceExisting);

        }

        private async Task WriteToFileAsync()
        {
            StorageFile file = await storageFolder.GetFileAsync("Lok.txt");
            await FileIO.WriteTextAsync(storageFile, content);
        }
    }
}

using LibVLCSharp.Shared;
using System.Configuration;
using System.Windows;

namespace WpfCctvMonitorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly LibVLC libVLC;
        private readonly MediaPlayer mediaPlayer;

        public MainWindow()
        {
            InitializeComponent();


            Core.Initialize();

            libVLC = new LibVLC();
            mediaPlayer = new MediaPlayer(libVLC);
            VvwScreen.MediaPlayer = mediaPlayer;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // TODO : 나중에 지울것.. Video
            var media = new Media(libVLC, new Uri("https://cctvsec.ktict.co.kr:8082/mgmt026/mgmtcctv00005799D/main_stream.m3u8?nimblesessionid=22611035&wmsAuthSign=c2VydmVyX3RpbWU9Ny8xLzIwMjYgNDozMzo1OSBBTSZoYXNoX3ZhbHVlPTZIaE9QVEx0REg4WU1WaVlvZG8zRUE9PSZ2YWxpZG1pbnV0ZXM9MTIwJmlkPW1sdG0jbnRpY2xpdmUjODc0Ng==\r\n"));

            mediaPlayer.Play(media);

            Common.AppCommon.ItsOpenApiKey = ConfigurationManager.AppSettings["ItsOpenApiKey"];
            // MessageBox.Show(Common.AppCommon.ItsOpenApiKey);

        }

        private void BtnExpress_Click(object sender, RoutedEventArgs e)
        {
            Common.AppCommon.ApiType = "ex";
        }

        private void BtnNational_Click(object sender, RoutedEventArgs e)
        {
            Common.AppCommon.ApiType = "nt";

        }

        private void BtnFavorites_Click(object sender, RoutedEventArgs e)
        {
            Common.AppCommon.ApiType = "fav";
        }
    }
}
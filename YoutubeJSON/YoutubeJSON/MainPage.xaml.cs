using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using YoutubeJSON.Model;
using Video = YoutubeJSON.Model.Video;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace YoutubeJSON
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private YouTubeService youtubeService =
            new YouTubeService(new BaseClientService.Initializer
            {
                ApiKey = "AIzaSyBiHEgO0GmNolX-B1P1Y7NYS8qjM11fYa4",
                ApplicationName = "youtube"
            });
        List<Video> ListVideo = new List<Video>();
        private string TokenNextPage = null, TokenPrivPage = null;

        string path;
        SQLite.Net.SQLiteConnection conn;

      
        public void Retrieve_Click(object sender, RoutedEventArgs e)
        {
            var query = conn.Table<ListMark>();
            string id = "";
            string link = "";          

            foreach (var message in query)
            {
                id = id + " " + message.Id;
                link = link + " " + message.Link;
            }
            textBlock2.Text = "ID: " + id + "\nName: " + link;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var s = conn.Insert(new Mark()
            {
                 ,///link video
            });
        }


        public MainPage()
        {
            this.InitializeComponent();
            GetVideo();


            path =
           Path.Combine
           (Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");

            conn =
            new SQLite.Net.SQLiteConnection
            (new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);

            conn.CreateTable<ListMark>();

        }

        private async void GetVideo(string PageToken = null)
        {
            try
            {

                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    var Request = youtubeService.Search.List("snippet");
                    Request.ChannelId = "UCGP3J6s7muWHozZilf4Nacw";
                    Request.MaxResults = 5;
                    Request.Type = "video";
                    Request.Order = SearchResource.ListRequest.OrderEnum.Date;
                    Request.PageToken = PageToken;
                    var Result = await Request.ExecuteAsync();
                    if (Result.NextPageToken != null)
                        TokenNextPage = Result.NextPageToken;
                    if (Result.PrevPageToken != null)
                        TokenPrivPage = Result.PrevPageToken;

                    foreach (var item in Result.Items)
                    {
                        ListVideo.Add(new Video
                        {
                           
                            title = item.Snippet.Title,
                            id = item.Id.VideoId,
                            image = item.Snippet.Thumbnails.Default__.Url,
                            description = item.Snippet.Description
                        }); ;
                    }
                    lv.ItemsSource = null;
                    lv.ItemsSource = ListVideo;
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Check your internet connection");
                    await msg.ShowAsync();
                }
            }
            catch { }
        }

        private void lv_ItemClick(object sender, ItemClickEventArgs e)
        {
            Video video = e.ClickedItem as Video;
            Frame.Navigate(typeof(VideoPage), video);
        }






    }
}

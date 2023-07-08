using InfoManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace InfoManager.ViewModel
{
    public class FirstPageViewModel
    {
        public ObservableCollection<AlbumModel> AlbumList { get; set; } = new ObservableCollection<AlbumModel>();
        public ObservableCollection<SongModel> NewList { get; set; } = new ObservableCollection<SongModel>();
        public ObservableCollection<SongModel> HotList { get; set; } = new ObservableCollection<SongModel>();
        public ObservableCollection<SongModel> TopList { get; set; } = new ObservableCollection<SongModel>();
        public FirstPageViewModel()
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString("https://music.migu.cn/v3");
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            HtmlNodeCollection htmlNodes = htmlDocument.DocumentNode.SelectNodes("//div[@class='thumb']");

            if(htmlNodes != null && htmlNodes.Count > 0)
            {
                for(int i=0; i<10; i++)
                {
                    var node = htmlNodes[i].ChildNodes[1];
                    var a = node.ChildNodes[1];
                    var img = a.ChildNodes[1];
                    var src = img.Attributes["data-src"].Value;

                    var id = node.ChildNodes[3].Attributes["data-id"].Value;

                    node = htmlNodes[i].ChildNodes[3];
                    var name = node.ChildNodes[1].InnerText;

                    AlbumList.Add(new AlbumModel
                    {
                        Id = id,
                        Cover = "https:" + src,
                        Title = name
                    });
                }

                string html_kugo = webClient.DownloadString("https://www.kugou.com/");
                HtmlDocument htmlDocument_kugo = new HtmlDocument();
                htmlDocument_kugo.LoadHtml(html_kugo);
                htmlNodes = htmlDocument_kugo.DocumentNode.SelectNodes("//img[@width='62']");
                for (int i = 0; i < 5; i++)
                {

                }
                //for (int i = 0; i < 65; i++)
                //{
                //    var node_NewListNum = htmlNodes[i].SelectNodes("//div[@class='item-num']");
                //    if(node_NewListNum != null && node_NewListNum.Count > 0)
                //    {
                //        var img_NewList = htmlNodes[i].ChildNodes[1].ChildNodes[1].Attributes["src"];

                //    }
                //}
            }
            //HtmlNodeCollection htmlNodes_NewList = htmlDocument.DocumentNode.SelectNodes("//div[@class='container wrapper-contain']");
            //for(int i = 1; i <= 30; i++)
            //{
            //    var node_NewListImg = htmlNodes_NewList[0].ChildNodes[1].ChildNodes[1].ChildNodes[i].ChildNodes[1].ChildNodes[1].ChildNodes[1].Attributes["src"].Value;
            //}

        }
    }
}

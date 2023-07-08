using InfoManager.Common;
using InfoManager.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace InfoManager.ViewModel
{
    public class MainViewModel
    {
        public CommandBase CloseWindowComnand { get; set; }
        public ObservableCollection<SongSheetModel> Slist { get; set; } = new ObservableCollection<SongSheetModel>();
        public MainViewModel()
        {
            Slist.Add(new SongSheetModel { Header = "默认歌单" });
            Slist.Add(new SongSheetModel { Header = "本地音乐" });
            Slist.Add(new SongSheetModel { Header = "在线音乐" });
            this.CloseWindowComnand = new CommandBase();
            this.CloseWindowComnand.DoExecute = new Action<object>((o) =>
            {
                (o as Window).Close();
            });
            this.CloseWindowComnand.DoCanExecute = new Func<object, bool>((o) => { return true; });           
        }
    }
}

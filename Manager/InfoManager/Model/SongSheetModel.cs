using System.Collections.Generic;


namespace InfoManager.Model
{
    public class SongSheetModel
    {
        public string Header { get; set; }
        public string Icon { get; set; }
        public List<SongModel> Songs = new List<SongModel>();
    }
}

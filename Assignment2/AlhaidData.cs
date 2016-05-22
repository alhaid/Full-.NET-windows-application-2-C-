using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class AlhaidData : EntertainData
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string MusOrMov { get; set; }
        public string Type { get; set; }
        public static List<AlhaidData> dataList = new List<AlhaidData>();
        public static Boolean load = true;

        public AlhaidData(string musORmov, string type, string title, string rating)
        {
            this.MusOrMov = musORmov;
            this.Type = type;
            this.Title = title;
            this.Rating = rating;
        }
        public AlhaidData(){}

        public override string MusicOrMovie()
        {
            return MusOrMov + ": " + Title + " has rating of " + Rating;
        }

        public override string EntertainGenre()
        {
            return Type + " created by Alhaid-Shop: " + Title + " has rating of " + Rating;
        }

        public override string ToString()
        {
            return MusOrMov + ": " + Title + " (" + Type + ") " + "has rating of " + Rating;
        }

    }
}

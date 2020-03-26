using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestRecordMusic.Controllers
{
    public class MusicForDR
    {
        
            // instance field
            private string _title;
            private string _artist;
            public int _id = 0;
            public double _duration;
            public int _yearOfPublication;

        // propetories
        public int YearOfPublication //over år 0
        {
            get { return _yearOfPublication; }
            set
            {
                if (value > 0) _yearOfPublication = value;
                else throw new ArgumentOutOfRangeException();
            }
        }


        public int Duration // 
        {
            get { return Duration; }
            set
            {
                if (value > 5) _duration = value;
                else throw new ArgumentOutOfRangeException();
            }
        }


        public string Artist //min 3 tegn - NOT NULL
        {
            get { return _artist; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.Length >= 3) _artist = value;
                else throw new ArgumentException("Længden skal være mere end 2 tegn");
            }
        }


        public string Title //min 1 tegn - NOT NULL
        {
            get { return _title; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.Length >= 1) _title = value;
                else throw new ArgumentException("Længden skal være mindst et tegn");
            }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}

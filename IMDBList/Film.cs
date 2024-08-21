using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBList
{
    public class Film
    {
        public double ImdbScore { get; set; }
        public string FilmName { get; set; }

        public Film(string name,double imdb)
        {
            FilmName=name;
            ImdbScore=imdb;
        }
    }
}

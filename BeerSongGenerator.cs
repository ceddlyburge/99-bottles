using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BeerSong
{
    public class BeerSongGenerator
    {
        List<string> lines;

        public BeerSongGenerator()
        {
            lines = new List<string>();
        }


        // I would like to test this method in isolation, not sure how yet
        internal string BeerSong() =>
            lines.Aggregate((aggregate, next) => $"{aggregate}\n{next}") + "\n";

        void Add(string line) =>
            lines.Add(line);

    }
}

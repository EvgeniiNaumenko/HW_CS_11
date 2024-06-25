using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11_19_06_2024
{
    internal class Film
    {
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; } 
        public int Year { get; set; }
        public Film (string title, string studio, string genre, int duration,int year)
        {
            Title = title;
            Studio = studio;
            Genre = genre;
            Duration = duration;
            Year = year;
        }
        public override string ToString()
        {
            return $"Title: {Title}\nStudio: {Studio}\nGenre: {Genre}\nDuration: {Duration}\nYear: {Year}";
        }
        ~Film()
        {
            Console.WriteLine($"Film '{Title}' removed.");
        }

    }
}

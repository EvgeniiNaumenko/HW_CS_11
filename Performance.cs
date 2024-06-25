using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11_19_06_2024
{
    internal class Performance: IDisposable
    {
        public string Name {  get; set; }
        public string TheaterName { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public List<String> CastList;

        public Performance() 
        {
            Name = "NoName";
            TheaterName = "NoName";
            Genre = "NoGenre";
            CastList = new List<string>();
        }
        public Performance(string name, string theaterName, string genre, int duration)
        {
            Name = name;
            TheaterName = theaterName;
            Genre = genre;
            Duration = duration;
            CastList = new List<string>();
        }
        public void AddCast (string name)
        {
            CastList.Add(name);
        }
        public void RemoveCast (string name)
        {
            CastList.Remove(name);
        }
        public void Dispose()
        {
            CastList.Clear();
            Console.WriteLine("Type clear");
        }
        ~Performance()
        {
            Console.WriteLine($"Performance '{Name}' removed.");
        }
        public override string ToString()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"TheaterName: {TheaterName}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Duration: {Duration}");
            Console.WriteLine("Cast list:");
            foreach ( var cast in CastList )
            {
                Console.WriteLine(cast);
            }
            return "";
        }
    }
}

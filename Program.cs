using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface3

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..Music.. ");

            Phone m1 = new Phone("I wanna grow old with you", "Westlife", 2015, 500);
            m1.ShowInfo();
            Console.WriteLine();

            m1.changeTitle("I wanna grow old with you");
            m1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Swich On Call");
            m1.switchs(true);
            Console.WriteLine();
            Console.WriteLine("Music Play On Call");
            m1.play(true);
            Console.WriteLine();
            Console.WriteLine("Set Volume Call with Loudness 7");
            m1.setVolume(7);
            Phone m2 = new Phone("November Rain", "Guns N' Roses", 2015, 500);
            Phone m3 = new Phone("We don't talk anymore", "Charlie Puth", 2015, 500);
            Phone m4 = new Phone("Sugar", "Maroon 5", 2015, 500);
            Phone list = new Phone();
            list.AddMusicFile(m2, m1, m3, m4);
            Console.WriteLine();
            Console.WriteLine("Next Music Info");
            list.playNext();
            Console.WriteLine();
            Console.WriteLine("Previous Music Info");
            list.playPrevious();
            Console.WriteLine();
            Console.WriteLine("Music List");


            list.ShowAllMusicFile();

        }
    }
}
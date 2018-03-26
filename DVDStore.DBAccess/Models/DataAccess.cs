using DVDStore.DataBase.Models;
using System.Linq;

namespace DVDStore.DBAccess.Models
{
    public class DataAccess 
    {
        // get all DVDs 
        public IQueryable GetAllDVDS()
        {
            using (var context = new DVDDB())
            {
                var result = from d in context.DVDs
                             select d;

                foreach (var r in result)
                {
                    System.Console.WriteLine(r.ID + " " + r.Title + " " + r.Rating + " " + r.TimeLength);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();

                return result;

            }
        }

        // get all DVDs by genre
        public IQueryable GetAllDVDByGenre(string genre)
        {
            using (var context = new DVDDB())
            {
                var result = from d in context.DVDs
                             where d.Genre == genre
                             select d;

                foreach (var r in result)
                {
                    System.Console.WriteLine(r.ID + " " + r.Title + " " + r.Rating + " " + r.TimeLength);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();

                return result;

            }
        }

        // get all DVDs by rating
        public IQueryable GetAllDVDByRating(string rating)
        {
            using (var context = new DVDDB())
            {
                var result = from d in context.DVDs
                             where d.Rating == rating
                             select d;

                foreach (var r in result)
                {
                    System.Console.WriteLine(r.ID + " " + r.Title + " " + r.Rating + " " + r.TimeLength);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();

                return result;
            }
        }

        // get all DVDs by title
        public IQueryable GetAllDVDByTitle(string title)
        {
            using (var context = new DVDDB())
            {
                var result = from d in context.DVDs
                             where d.Title == title
                             select d;

                foreach (var r in result)
                {
                    System.Console.WriteLine(r.ID + " " + r.Title + " " + r.Rating + " " + r.TimeLength);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();

                return result;
            }
        }

        // get all Actors 
        public IQueryable GetAllActors()
        {
            using (var context = new DVDDB())
            {
                var result = from a in context.Actors
                             select a;

                foreach (var r in result)
                {
                    System.Console.WriteLine(r.ID + " " + r.FirstName + " " + r.LastName);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();

                return result;
            }
        }

    }
}

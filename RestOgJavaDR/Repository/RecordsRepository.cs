
using RestOgJavaDR.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestOgJavaDR.Repository
{
    public class RecordsRepository : IRecordsRepository
    {
        private static int _nextId = 1;
        private static List<Records> data = new List<Records>()
        {
            new Records(){Id =_nextId++,title = "starlight", artist ="Karsten", duration = 120, publicationYear = 2001},
            new Records(){Id =_nextId++,title = "DiscoNight", artist ="Bob", duration = 150, publicationYear = 2022},
        };

        public List<Records> GetAll(string? namefilter = null, string? artist = null, string? _sortBy = null)
        {

            List<Records> records = new List<Records>(data);
            if (artist != null)
            {
                records = records.FindAll(record => record.artist != null && record.artist.StartsWith(artist));
            }
            if (namefilter != null)
            {
                records = records.FindAll(record => record.title.Contains(namefilter, StringComparison.InvariantCultureIgnoreCase)); 
            }
            if (_sortBy != null)
            {
                switch (_sortBy.ToLower())
                {
                    case "title":
                        records = records.OrderBy(record => record.title).ToList();
                        break;
                    case "artist":
                        records = records.OrderBy(record => record.artist).ToList();
                        break;

                }
            }
            return records;
        } 

       
    }
}

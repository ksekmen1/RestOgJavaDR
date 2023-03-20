using RestOgJavaDR.Model;

namespace RestOgJavaDR.Repository
{
    public class RecordsRepository
    {
        private static List<Records> data = new List<Records>()
        {
            new Records(){title = "starlight", artist ="Karsten", duration = 120, publicationYear = 2001},
            new Records(){title = "DiscoNight", artist ="Bob", duration = 150, publicationYear = 2022},
        };

        public List<Records> GetAll()
        {
            return new List<Records>(data);
        }
    }
}

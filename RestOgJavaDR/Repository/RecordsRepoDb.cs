using RestOgJavaDR.Models;
using RestOgJavaDR.Repository;


namespace RestOgJavaDR.Repository
{
    public class RecordsRepoDb : IRecordsRepository
    {
        private KRDBContext _context;
        
        public RecordsRepoDb(KRDBContext context)
        {
            _context = context;
        }

        public List<Records> GetAll(string? namefilter = null)
        {
            return _context.Records.Where(record => 
            namefilter == null || record.title.Contains(namefilter, StringComparison.InvariantCultureIgnoreCase)

            ).ToList();
        }
    }
}

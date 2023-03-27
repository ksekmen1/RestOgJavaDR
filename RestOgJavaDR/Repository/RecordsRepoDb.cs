using RestOgJavaDR.Models;
using RestOgJavaDR.Repository;

namespace RestOgJavaDR.Repository
{
    public class RecordsRepoDb
    {
        private KRDBContext _context;
        
        public RecordsRepoDb(KRDBContext context)
        {
            _context = context;
        }
    }
}

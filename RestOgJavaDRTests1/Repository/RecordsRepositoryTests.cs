using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestOgJavaDR.Model;
using RestOgJavaDR.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestOgJavaDR.Repository.Tests
{
    [TestClass()]
    public class RecordsRepositoryTests
    {
        RecordsRepository repo = new RecordsRepository();
        [TestMethod()]
        public void GetAllTest()
        {

            List<Records> allrecords = repo.GetAll();
            Assert.AreEqual(2, allrecords.Count);
        }
        [TestMethod()]
        public void SortByArtistTest()
        {

            List<Records> KRecords = repo.GetAll(artist: "K");
            Assert.AreEqual(1, KRecords.Count);
        }
        [TestMethod()]
        public void SortByTitleTest() 
        {
            List<Records> SRecords = repo.GetAll(title: "s");
            Assert.AreEqual(1, SRecords.Count);
        }
    }
}
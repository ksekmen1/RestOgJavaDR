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
        [TestMethod()]
        public void GetAllTest()
        {
            RecordsRepository repo = new RecordsRepository();

            List<Records> allrecords = repo.GetAll();
            Assert.AreEqual(2, allrecords.Count);
        }
    }
}
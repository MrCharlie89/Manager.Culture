using Microsoft.VisualStudio.TestTools.UnitTesting;
using Syntra.VDOAP.CProef.Manager.Culture.ReadStack.Queries;
using Syntra.VDOAP.CProef.Manager.Culture.ReadStack.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syntra.VDOAP.CProef.Manager.Culture.Tests
{
    [TestClass]
    public class LanguageQueryTests
    {
        private LanguageQueries _queries;

        [TestInitialize]
        public void Initialize()
        {
            _queries = new LanguageQueries();
        }

        [TestMethod]
        public void GetLanguageOverviewTest()
        {
            var result = _queries.GetLanguageOverview();

            Assert.AreNotEqual(null, result);
            /// Assert.IsTrue(result.GetType() == typeof(IEnumerable<LanguageItem>));
            Assert.AreEqual(typeof(List<LanguageItem>), result.GetType());
            Assert.IsTrue(result.Any());
        }

    }
}

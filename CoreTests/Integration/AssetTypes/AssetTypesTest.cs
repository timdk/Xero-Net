using System;
using System.Linq;
using System.Runtime.Hosting;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.AssetTypes
{
    [TestFixture]
    public class AssetTypesTest : ApiWrapperTest
    {
        [Test]
        public void find_all()
        {
            var list = Api.AssetTypes
                .Find()
                .ToList();

            Assert.Greater(list.Count, 0);
        }

      
    }
}

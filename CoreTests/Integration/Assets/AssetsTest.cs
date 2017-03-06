using System;
using System.Linq;
using System.Runtime.Hosting;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;
using Xero.Api.Core.Model.Status;

namespace CoreTests.Integration.Assets
{
    [TestFixture]
    public class AssetsTest : ApiWrapperTest
    {
        [Test]
        public void find_all()
        {
            var list = Api.Assets
                .Find(AssetStatus.Registered);

            Assert.Greater(list.Count(), 0);
        }

       
    }
}

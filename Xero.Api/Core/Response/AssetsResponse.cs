using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Response
{
    public class AssetsResponse : XeroResponse<Asset>
    {
        public IList<Asset> Assets { get; set; }

        public override IList<Asset> Values
        {
            get { return Assets; }
        }
    }
}
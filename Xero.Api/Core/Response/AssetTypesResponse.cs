using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Core.Response
{
    [DataContract(Namespace = "")]
    public class AssetTypesResponse : XeroResponse
    {
        [DataMember]
        public IList<AssetType> AssetTypes { get; set; }


    }
}
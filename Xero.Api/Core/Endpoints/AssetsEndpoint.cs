using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IAssetsEndpoint : IXeroUpdateEndpoint<AssetsEndpoint, Asset, AssetsRequest, AssetsResponse>
    {

    }

    public class AssetsEndpoint
        : XeroUpdateEndpoint<AssetsEndpoint, Asset, AssetsRequest, AssetsResponse>, IAssetsEndpoint
    {
        public AssetsEndpoint(XeroHttpClient client) :
            base(client, "/assets.xro/1.0/Assets")
        {
        }
    }
}
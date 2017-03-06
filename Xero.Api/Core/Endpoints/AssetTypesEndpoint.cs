using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IAssetTypesEndpoint
    {
        IEnumerable<AssetType> Find();

        AssetType Update(AssetType item);

        AssetType Create(AssetType item);

    }

    public class AssetTypesEndpoint :  IAssetTypesEndpoint
    {

        private readonly XeroHttpClient _client;
        private readonly string _apiEndpointUrl;

        public AssetTypesEndpoint(XeroHttpClient client) :
            this(client, "/assets.xro/1.0/AssetTypes")
        {
        }
        protected AssetTypesEndpoint(XeroHttpClient client, string apiEndpointUrl)
        {
            _client = client;
            _apiEndpointUrl = apiEndpointUrl;
        }


        public IEnumerable<AssetType> Find()
        {
            string queryString = null;
            List<AssetType> assetTypes = HandleResponseList(_client.Client.Get(_apiEndpointUrl, queryString));

            return assetTypes;
        }


        public AssetType Update(AssetType item)
        {
            throw new NotImplementedException();
        }



        public AssetType Create(AssetType item)
        {
            throw new NotImplementedException();
        }



        private List<AssetType> HandleResponseList(Infrastructure.Http.Response response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                
                var result = _client.JsonMapper.From<List<AssetType>>(response.Body);
                return result;
            }

            _client.HandleErrors(response);

            return null;
        }

        private AssetType HandleResponse(Infrastructure.Http.Response response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
 
                var result = _client.JsonMapper.From<AssetType>(response.Body);
                return result;
            }

            _client.HandleErrors(response);

            return null;
        }

    }
}
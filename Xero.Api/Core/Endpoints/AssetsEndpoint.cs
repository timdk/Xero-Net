using System;
using System.Collections.Generic;
using System.Net;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IAssetsEndpoint 
    {
        IEnumerable<Asset> Find(AssetStatus status);

        Asset Update(Asset item);

        Asset Create(Asset item);
    }

    public class AssetsEndpoint
        :  IAssetsEndpoint
    {


        private readonly XeroHttpClient _client;
        private readonly string _apiEndpointUrl;


        public AssetsEndpoint(XeroHttpClient client) :
            this(client, "/assets.xro/1.0/Assets")
        {
        }

        protected AssetsEndpoint(XeroHttpClient client, string apiEndpointUrl)
        {
            _client = client;
            _apiEndpointUrl = apiEndpointUrl;
        }

        public IEnumerable<Asset> Find(AssetStatus status)
        {
            string queryString = "status="+status.ToString().ToUpper();
            AssetsResponse response = HandleResponse(_client.Client.Get(_apiEndpointUrl, queryString));
            List<Asset> assets = new List<Asset>();
            assets.AddRange(response.Items);
            while(response.Pagination.PageCount < response.Pagination.Page)
            {
                response = HandleResponse(_client.Client.Get(_apiEndpointUrl, queryString));
                assets.AddRange(response.Items);
            }
            return response.Items;
        }

        public Asset Update(Asset item)
        {
            throw new NotImplementedException();
        }

        public Asset Create(Asset item)
        {
            throw new NotImplementedException();
        }

        private AssetsResponse HandleResponse(Infrastructure.Http.Response response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {

                var result = _client.JsonMapper.From<AssetsResponse>(response.Body);
                return result;
            }

            _client.HandleErrors(response);

            return null;
        }

       
    }
}
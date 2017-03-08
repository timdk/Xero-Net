using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Response
{
    public class AssetsResponse 
    {
        
            public Pagination Pagination { get; set; }
            public List<Asset> Items { get; set; }
        
    }

    public class Pagination
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
        public int ItemCount { get; set; }
        public Links Links { get; set; }
    }

    public class Links
    {
        public First First { get; set; }
        public Last Last { get; set; }
    }

    public class First
    {
        public string Href { get; set; }
    }

    public class Last
    {
        public string Href { get; set; }
    }
}
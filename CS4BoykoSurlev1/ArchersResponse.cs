using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS4BoykoSurlev1
{
    public class ArchersResponse
    {
        public string alias { get; set; }
        public string prices { get; set; }

        public ArchersResponse()
        {

        }

        public ArchersResponse(string alias, string prices)
        {
            this.alias = alias;
            this.prices = prices;
        }

    }
}
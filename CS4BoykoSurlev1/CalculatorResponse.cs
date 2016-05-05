using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS4BoykoSurlev1
{
    public class CalculatorResponse
    {
        public string sequenceOfNumbers { get; set; }
        public int result { get; set; }
        public string alias { get; set; }
        public int[] points { get; set; }

        public CalculatorResponse()
        {

        }

        public CalculatorResponse(string alias, int[] points)
        {
            this.alias = alias;
            this.points = points;
        }

        public CalculatorResponse(string alias, string seq, int res)
        {
            this.alias = alias;
            this.sequenceOfNumbers = seq;
            this.result = res;
        }

    }
}
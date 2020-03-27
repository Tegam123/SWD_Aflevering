using System;
using System.Collections.Generic;
using System.Text;

namespace StockMediator
{
    public class StockOffer
    {
        private int stockShares = 0;
        private int usercode = 0;
        private string stockName = "";

        public StockOffer(int numshares, string stock, int usercode)
        {
            this.stockShares = numshares;
            this.stockName = stock;
            this.usercode = usercode;
        }

        public int StockShares { get; private set; }
        public int UserCode { get; private set; }
        public string StockName { get; private set; }
    }
}

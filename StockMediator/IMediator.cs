using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace StockMediator
{
    public interface IMediator
    {
        void SaleOffer(string stock, int shares, int usercode);
        void BuyOffer(string stock, int shares, int usercode);

        void AddUser(BaseComponent user);
    }
}

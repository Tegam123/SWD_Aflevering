using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace StockMediator
{
    public interface IMediator
    {
        void saleOffer(string stock, int shares, int usercode);
        void buyoffer(string stock, int shares, int usercode);

        void addUser(BaseComponent user);
    }
}

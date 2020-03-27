using System;
using System.Collections.Generic;
using System.Text;

namespace StockMediator
{
    public class StockMediator : IMediator
    {
        private List<BaseComponent> Users;
        private List<StockOffer> stockBuyOffers;
        private List<StockOffer> stockSellOffers;

        public StockMediator()
        {
            Users = new List<BaseComponent>();
            stockBuyOffers = new List<StockOffer>();
            stockSellOffers = new List<StockOffer>();
        }

        public void addUser(BaseComponent user)
        {
            Users.Add(user);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMediator
{
    public abstract class BaseComponent
    {
        private IMediator _mediator;
        private int userCode;
        private List<StockOffer> portfolge;

        
        public BaseComponent(IMediator mediator = null)
        {
            _mediator = mediator;
            _mediator.AddUser(this);
            portfolge = new List<StockOffer>();
        }

        public void SellStock(string stock, int shares)
        {

            _mediator.SaleOffer(stock, shares,userCode);
        }

        public void BuyStock(string stock, int shares)
        {
            _mediator.BuyOffer(stock,shares,userCode);
        }

        public void RemoveStock(StockOffer stock)
        {
            var itemtoRemove = portfolge.Single(r => r.StockName == stock.StockName
                                                     && r.StockShares == stock.StockShares);

            if (itemtoRemove == null)
            {
                Console.WriteLine($"Forhelvede 2");
            }
            portfolge.Remove(itemtoRemove);
        }

        public void AddStock(StockOffer stock)
        {
            portfolge.Add(stock);
        }

        public void setUserCode(int code)
        {
            userCode = code;
        }

        public int getUserCode()
        {
           return userCode;
        }

        public void ShowStocks()
        {
            Console.WriteLine();
            Console.WriteLine($"Din portefølge er: ");
            Console.WriteLine("Portfolge:");
            foreach (var st in portfolge)
            {
                Console.WriteLine($"{st.StockShares} Of {st.StockName}.");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMediator
{
    public class StockMediator : IMediator
    {
        private List<BaseComponent> Users;
        private List<StockOffer> stockBuyOffers;
        private List<StockOffer> stockSellOffers;

        private int userCodes = 0; 

        public StockMediator()
        {
            Users = new List<BaseComponent>();
            stockBuyOffers = new List<StockOffer>();
            stockSellOffers = new List<StockOffer>();
        }

        public void AddUser(BaseComponent user)
        {
            Users.Add(user);
            userCodes++;
            user.setUserCode(userCodes);
        }

        public void SaleOffer(string stock, int shares, int usercode)
        {
            
            bool stocksold = false;
            foreach (var st in stockBuyOffers)
            {
                if (st.StockName == stock && st.StockShares == shares)
                {
                    Console.WriteLine($"{shares} of {stock} Sold to {st.UserCode}" );
                    
                    stockBuyOffers.Remove(st);
                    
                    //Finder user der skal have stock fjernet fra sin portfølge
                    var RemovePortUser = Users.Single(r => r.getUserCode() == usercode);
                    //Fjerner fra portfolge
                    RemovePortUser.RemoveStock(st);
                    stocksold = true;

                    // Tilføjer aktien til købers portølge
                    var AddPortUser = Users.Single(r => r.getUserCode() == st.UserCode);
                    AddPortUser.AddStock(st);
                }

                if (stocksold)
                {
                    break;
                }
            }

            if (!stocksold)
            {
                Console.WriteLine($"{shares} of Stock: {stock} not sold. Now in orders");
                stockSellOffers.Add(new StockOffer(shares,stock,usercode));
            }
        }

        public void BuyOffer(string stock, int shares, int usercode)
        {
            bool stockBought = false;
            foreach (var st in stockSellOffers)
            {
                if (st.StockName == stock && st.StockShares == shares)
                {
                    Console.WriteLine($"{shares} of {stock} bought by {st.UserCode}");
                    stockSellOffers.Remove(st);
                    
                    var RemovePortUser = Users.Single(r => r.getUserCode() == st.UserCode);
                    
                    
                    RemovePortUser.RemoveStock(st);
                    

                    var AddPortUser = Users.Single(r => r.getUserCode() == usercode);
                    AddPortUser.AddStock(st);
                    stockBought = true;
                }

                if (stockBought)
                {
                    break;
                    
                }
            }

            if (!stockBought)
            {
                Console.WriteLine($"{shares} of Stock: {stock} not bought. Now in orders");

                stockBuyOffers.Add(new StockOffer(shares, stock, usercode));
            }
        }

        public void getStockOffers()
        {
            Console.WriteLine("For Sale:");
            foreach (var st in stockSellOffers)
            {
                Console.WriteLine($"{st.StockShares} Of {st.StockName} for sale.");
            }
            Console.WriteLine("");
            Console.WriteLine("Buying offers:");
            foreach (var st in stockBuyOffers)
            {
                Console.WriteLine($"{st.StockShares} Of {st.StockName} for buy.");
            }
        }

       
    }
}

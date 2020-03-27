using System;

namespace StockMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            StockMediator stockMediator = new StockMediator();

            SuperBuyer buyer = new SuperBuyer(stockMediator);

            Nordnet Lasse = new Nordnet(stockMediator);

            Lasse.AddStock(new StockOffer(100,"Vestas", Lasse.getUserCode()));

            Lasse.AddStock(new StockOffer(100, "Amazon", Lasse.getUserCode()));

            Lasse.AddStock(new StockOffer(100, "Tesla", Lasse.getUserCode()));

            Lasse.AddStock(new StockOffer(100, "Microsoft", Lasse.getUserCode()));

            Lasse.ShowStocks();

            Lasse.SellStock("Vestas",100);
            Lasse.SellStock("Amazon", 100);
            Lasse.SellStock("Tesla", 100);
            Lasse.SellStock("Microsoft", 100);



            buyer.BuyStock("Amazon",100);

            buyer.BuyStock("Vestas", 100);

            stockMediator.getStockOffers();

            Lasse.ShowStocks();
            
        }
    }
}

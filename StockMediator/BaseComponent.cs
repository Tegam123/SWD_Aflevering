using System;
using System.Collections.Generic;
using System.Text;

namespace StockMediator
{
    public abstract class BaseComponent
    {
        private IMediator _mediator;
        private int userCode;

        public BaseComponent(IMediator mediator = null)
        {
            _mediator = mediator;
            _mediator.addUser(this);
        }

        public void SellStock(string stock, int shares)
        {
            _mediator.saleOffer(stock, shares,userCode);
        }

        public void BuyStock(string stock, int shares)
        {
            _mediator.buyoffer(stock,shares,userCode);
        }

        public void setUserCode(int code)
        {
            userCode = code;
        }
    }
}

using MyGameSystem.Activity.Abstract;
using MyGameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Activity.Concrete.Platform
{
    class EpicGamesManager : IGameTradeService
    {
        List<IDiscountService> _discountServices;
        public EpicGamesManager(List<IDiscountService> discountServices)
        {
            _discountServices = discountServices;
        }

        public void BuyGame(IEntity game, IEntity customer)
        {
            foreach (var sale in _discountServices)
            {
                sale.Discount(game);
            }
            Console.WriteLine(game.Name + "Oyununu satın aldığınız için teşekkür ederiz " + customer.Name + ".");
        }
    }
}

using MyGameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Activity.Abstract
{
    interface IGameTradeService
    {
        void BuyGame(IEntity game, IEntity customer);
    }
}

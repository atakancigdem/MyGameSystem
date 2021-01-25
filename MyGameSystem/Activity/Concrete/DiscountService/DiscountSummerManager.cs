using MyGameSystem.Activity.Abstract;
using MyGameSystem.Entities;
using MyGameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Activity.Concrete.DiscountService
{
    class DiscountSummerManager : IDiscountService
    {
        public void Discount(IEntity Game)
        {
            Console.WriteLine("Oyun yaz indiriminde : " + Game.Name);
        }     
    }
}

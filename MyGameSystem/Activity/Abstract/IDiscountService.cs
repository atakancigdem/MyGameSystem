using MyGameSystem.Entities;
using MyGameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Activity.Abstract
{
    interface IDiscountService
    {
        void Discount(IEntity entity);
    }
}

using MyGameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Activity.Abstract
{
    interface ICustomerService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);

    }
}

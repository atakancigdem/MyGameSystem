using MyGameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.DataSaving.Abstract
{
    interface ILoggerService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}

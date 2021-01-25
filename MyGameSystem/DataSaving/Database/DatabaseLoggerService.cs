using MyGameSystem.DataSaving.Abstract;
using MyGameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.DataSaving.Database
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine("Veritabanına loglandı : " + entity.Name);
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Veritabanından silindi : " + entity.Name);
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Veritabanında güncellendi : " + entity.Name);
        }
    }
}

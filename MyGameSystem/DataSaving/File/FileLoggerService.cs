using MyGameSystem.DataSaving.Abstract;
using MyGameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.DataSaving.File
{
    class FileLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine("Dosyaya loglandı : " + entity.Name);
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Dosyayadan silindi : " + entity.Name);
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Dosyayada güncellendi : " + entity.Name);
        }
    }
}

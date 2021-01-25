using MyGameSystem.Activity.Abstract;
using MyGameSystem.DataSaving.Abstract;
using MyGameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Activity.Concrete
{
    class GameManager : ICustomerService
    {
        List<ILoggerService> _loggerServices;
        public GameManager(List<ILoggerService> loggerServices)
        {
            _loggerServices = loggerServices;
        }
        public void Add(IEntity entityGame)
        {
            foreach (var log in _loggerServices)
            {
                log.Add(entityGame);
            }
        }

        public void Delete(IEntity entityGame)
        {
            foreach (var log in _loggerServices)
            {
                log.Delete(entityGame);
            }
        }

        public void Update(IEntity entityGame)
        {
            foreach (var log in _loggerServices)
            {
                log.Update(entityGame);
            }
        }
    }
}

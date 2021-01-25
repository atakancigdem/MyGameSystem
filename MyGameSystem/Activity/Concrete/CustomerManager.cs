using MyGameSystem.Activity.Abstract;
using MyGameSystem.Activity.CustomerInformationVerification;
using MyGameSystem.DataSaving.Abstract;
using MyGameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Activity.Concrete
{
    class CustomerManager : ICustomerService
    {
        List<ILoggerService> _loggerServices;
        public CustomerManager(List<ILoggerService> loggerServices)
        {
            _loggerServices = loggerServices;
        }
        public List<ILoggerService> Lists { get; }
        public IPersonVerificationService PersonVerificationService { get; }
        public CustomerManager(List<ILoggerService> lists, IPersonVerificationService personVerificationService)
        {
  
            PersonVerificationService = personVerificationService;
        }



        public void Add(IEntity entity)
        {
            foreach (ILoggerService log in _loggerServices)
            {
                log.Add(entity);
            }
        }

        public void Delete(IEntity entity)
        {
            foreach (ILoggerService log in _loggerServices)
            {
                log.Delete(entity);
            }
        }

        public void Update(IEntity entity)
        {
            foreach (ILoggerService log in _loggerServices)
            {
                log.Update(entity);
            }
        }
    }
}

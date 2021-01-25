using MyGameSystem.Activity.Abstract;
using MyGameSystem.Activity.CustomerInformationVerification;
using MyGameSystem.DataSaving.Abstract;
using MyGameSystem.Entities;
using MyGameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Activity.Concrete
{
    class CustomerManager : ICustomerService
    {
        List<ILoggerService> _loggerServices;
        List<IPersonVerificationService> _personVerificationServices;
        public CustomerManager(List<ILoggerService> loggerServices, List<IPersonVerificationService> personVerificationServices)
        {
            _loggerServices = loggerServices;
            _personVerificationServices = personVerificationServices;
        }
       
        public void Add(IEntity entity)
        {
            try
            {
                foreach (var validate in _personVerificationServices)
                {
                    validate.PersonVerification((Customer)entity);
                }
                foreach (var logger in _loggerServices)
                {
                    logger.Add(entity);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

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

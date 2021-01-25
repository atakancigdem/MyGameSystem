using MyGameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Activity.CustomerInformationVerification.ValidateService
{
    class ValidateService : IPersonVerificationService
    {
        public void PersonVerification(Customer customer)
        {
            if (customer.Name.Length > 1 && customer.LastName.Length > 1 && customer.NationalityId.Length == 11 && customer.DateOfBirth > 1800)
            {
                Console.WriteLine(customer.Name + " " + customer.LastName + "  Doğrulamadan geçti.");
            }
            else
            {
                throw new Exception(customer.Name + " " + customer.LastName + " Doğrulamadan geçemedi.");

            }
        }

    }
}

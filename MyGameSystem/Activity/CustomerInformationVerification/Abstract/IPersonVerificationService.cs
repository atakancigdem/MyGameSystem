using MyGameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Activity.CustomerInformationVerification
{
    interface IPersonVerificationService
    {
        void PersonVerification(Customer customer);
    }
}

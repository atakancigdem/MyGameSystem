using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Entities.Concrete
{
    class Customer : IEntity
    {
        public int Id { get; set; }    //Id
        public string Name { get; set; }    //İsim
        public string LastName { get; set; }    //Soyad    
        public string NationalityId { get; set; }   //Uyruk Id
        public int DateOfBirth { get; set; }   //Doğum Yıllı

    }
}

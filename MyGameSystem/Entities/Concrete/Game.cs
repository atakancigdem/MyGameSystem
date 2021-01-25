using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Entities.Concrete
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } //İsim
        public int Price { get; set; }  //Fiyat
        public int StockQuantity { get; set; }  //Stok Adedi
        
    }
}

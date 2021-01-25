using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

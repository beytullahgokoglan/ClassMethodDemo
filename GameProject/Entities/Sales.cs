using GameProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Sales:IEntity
    {
        public int SalesId { get; set; }
        public double Price { get; set; }
    }
}

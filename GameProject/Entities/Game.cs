﻿using GameProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game:IEntity
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}

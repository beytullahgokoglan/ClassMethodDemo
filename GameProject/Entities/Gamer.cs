using GameProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Gamer: IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long TcNo { get; set; }
        public int DateofBirth { get; set; }

    }


}

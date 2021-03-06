﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarImage :IEntity
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CarID { get; set; }
    }
}

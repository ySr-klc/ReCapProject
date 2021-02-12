using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int RentDate { get; set; }
        public int ReturnDate { get; set; }
    }
}

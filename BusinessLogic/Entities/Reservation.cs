﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}

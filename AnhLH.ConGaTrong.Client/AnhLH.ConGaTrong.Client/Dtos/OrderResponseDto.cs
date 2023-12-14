﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhLH.ConGaTrong.Client.Dtos
{
    public class OrderResponseDto
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string TicketCode { get; set; }
        public int? TicketNumber { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Remark { get; set; }
    }
}

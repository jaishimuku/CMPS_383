﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP20.P05.Web.Features.Cart_and_transactions
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public virtual List<ItemDto> ItemsDto { get; set; }

        public int TotalPrice { get; set; }

        public int cartId { get; set; }

        public DateTime Date { get; set; }
        public Boolean Redeemed { get; set; }

    }
}

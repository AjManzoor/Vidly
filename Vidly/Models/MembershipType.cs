﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        //these values link to the Membership type Id in the customers table allowing for more readable
        //and maintainable code
        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;

    }
}
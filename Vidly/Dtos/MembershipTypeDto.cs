using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MembershipTypeDto
    {
        //only include id to keep lightweight id is PK so can be used to reference rest of the data
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}
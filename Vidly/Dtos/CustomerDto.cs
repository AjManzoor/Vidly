using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        //DTOS should only contain primitive types
        //Only complex types should be other dtos for loose coupling

        public int Id { get; set; }

        //Example of overloading the default message with one of your own
        [Required(ErrorMessage = "Please enter a Name")]
        [StringLength(255)]
        public string Name { get; set; }
        
        /*Commented it out as when creating our API we now 2 endpoints
         * (API and action result) which would lead to an error to work with just api
         * change the form to post the API endpoint
         * 
        [Min18YearsIfAMember]*/
        public DateTime? Birthday { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
    }
}
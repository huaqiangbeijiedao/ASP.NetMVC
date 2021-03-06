﻿using KursMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KursMVC.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewstletter { get; set; }
        public byte MembershipTypeId { get; set; }
       // [Min18YearsIfAMemeber]
        public DateTime? Birthday { get; set; }
    }
}
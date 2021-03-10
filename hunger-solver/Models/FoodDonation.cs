﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hunger_solver.Models
{
    public class FoodDonation
    {
        [Key]
        public string _id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        public string DonatorName { get; set; }
        public string DonatorEmail { get; set; }
        public string DonatorImage { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public bool IsTaken { get; set; }
        public bool IsDelivered { get; set; }
    }
}
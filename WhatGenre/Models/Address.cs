﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WhatGenre.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "House number")]
        [Required]
        public int HouseNo { get; set; }

        [Display(Name = "Street name")]
        [Required]
        public string StreetName { get; set; }

        [Display(Name = "Postcode")]
        [Required]
        public string Postcode { get; set; }

        public User User { get; set; }
    }
}

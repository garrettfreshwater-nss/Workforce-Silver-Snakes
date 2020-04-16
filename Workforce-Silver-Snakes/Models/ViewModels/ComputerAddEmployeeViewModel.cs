﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workforce_Silver_Snakes.Models
{
    public class ComputerAddEmployeeViewModel
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime DecomissionDate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public List<SelectListItem> EmployeeOptions { get; set; }
    }
}

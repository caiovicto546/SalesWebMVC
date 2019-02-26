﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Seller> Sellers { get; set; } = new List<Seller>();

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

       /* public double TotalSales(DateTime initial, DateTime final)
        {
            return ;
        }*/

    }
}
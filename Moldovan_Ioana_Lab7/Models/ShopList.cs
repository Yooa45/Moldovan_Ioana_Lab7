﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Moldovan_Ioana_Lab7.Models
{
    public class ShopList
    {
    [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
    [MaxLength(250), Unique]

        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}
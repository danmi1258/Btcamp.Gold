﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Btcamp.Gold.Web.Models
{
    public class BaseViewModel
    {
        public BaseViewModel()
        {
            Id = Guid.NewGuid();
            UpdateTime = DateTime.Now;
        }

        public Guid Id { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
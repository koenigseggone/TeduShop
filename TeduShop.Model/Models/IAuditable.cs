﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{

    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;

namespace ASPCoreAssesment1.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}

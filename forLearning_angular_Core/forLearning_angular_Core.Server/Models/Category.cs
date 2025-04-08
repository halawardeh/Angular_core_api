﻿using System;
using System.Collections.Generic;

namespace forLearning_angular_Core.Server.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? CategoryDesc { get; set; }
}

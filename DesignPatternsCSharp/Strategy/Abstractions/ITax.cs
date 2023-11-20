﻿using Strategy.Models;

namespace Strategy.Abstractions
{
    internal interface ITax
    {
        double Calculate(Budget budget);
    }
}

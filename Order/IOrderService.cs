﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidCafe.Order
{
    public interface IOrderService
    {
        void GetBucketAll();
        void AddToBucket();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories
{
    public class CustumerRepositoy : ICustumerRepository
    {
        public Custumer createCustumer(Custumer custurmer)
        {
            return custurmer;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    interface ISort
    {
        void Sort(IList<int> listToSort);

    }
}

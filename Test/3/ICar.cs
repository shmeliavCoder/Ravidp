﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public interface ICar
    {
        void StartDriving();
        void StopDriving();
        void Fast();
        void Slow();
        void ShowFuel();
        void ShowLocation();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Helicopter :IairBorne
    {
        public string fly()
        {
            return string.Format("Hello Durga Prasad.This is Helicopter class Implemented from Interface!!!!\n\n");
        }
    }
}
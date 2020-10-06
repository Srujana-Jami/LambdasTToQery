﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LambdasFuncTToQuery
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public WorkPerformedEventArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = workType;
        }

        public int Hours { get; set; }
        public WorkType WorkType { get; set; }

    }
}

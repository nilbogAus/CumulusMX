﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CumulusMX.Extensions
{
    public interface ISystemSettings : IExtension
    {
        bool IsOSX { get; }
    }
}

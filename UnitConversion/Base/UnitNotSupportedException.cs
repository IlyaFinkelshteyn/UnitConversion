﻿using System;

namespace UnitConversion.Base {
    public class UnitNotSupportedException : NotSupportedException {
        internal UnitNotSupportedException() { }
        internal UnitNotSupportedException(string unit) : base(String.Format("The Unit '{0}' is not supported by this converter", unit)) { }
    }
}

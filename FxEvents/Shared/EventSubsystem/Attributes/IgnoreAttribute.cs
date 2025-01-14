﻿using System;

namespace FxEvents.Shared.Attributes
{
    /// <summary>
    /// Indicates that this property should be disregarded from serialization.
    /// </summary>
    public class IgnoreAttribute : Attribute
    {
        public bool Read { get; set; } = true;
        public bool Write { get; set; } = true;
    }
}
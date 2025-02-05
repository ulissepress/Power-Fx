﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Microsoft.PowerFx.Core.Public.Values
{
    /// <summary>
    /// Helper class for representing fields or columns.
    /// </summary>
    public class NamedValue
    {
        public string Name { get; }
        public FormulaValue Value { get; }
        
        public NamedValue(KeyValuePair<string, FormulaValue> pair)
            : this(pair.Key, pair.Value)
        {
        }

        public NamedValue(string name, FormulaValue value)            
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Value = value;
        }
    }
}
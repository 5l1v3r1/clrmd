﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Reflection;

namespace Microsoft.Diagnostics.Runtime
{
    public readonly struct ClrGenericParameter
    {
        public int MetadataToken { get; }

        public int Index { get; }

        public GenericParameterAttributes Attributes { get; }

        public string Name { get; }

        internal ClrGenericParameter(int metadataToken, int index, GenericParameterAttributes attributes, string name)
        {
            MetadataToken = metadataToken;
            Index = index;
            Attributes = attributes;
            Name = name;
        }
    }
}

// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNet.Testing.xunit
{
    [Flags]
    public enum OperatingSystems
    {
        None = 0,
        Win7 = 1 << 0,
        Win2008R2 = 1 << 1,
        Linux = 1 << 2,
        MacOSX = 1 << 3,
        AllWindows = 1 << 4
    }
}
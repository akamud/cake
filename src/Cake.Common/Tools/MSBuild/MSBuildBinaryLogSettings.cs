﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake.Common.Tools.MSBuild
{
    /// <summary>
    /// MSBuild binary logging settings used by <see cref="MSBuildSettings"/>.
    /// </summary>
    public class MSBuildBinaryLogSettings
    {
        /// <summary>
        /// Should binary logging be enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Output filename (optional)
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// What source files should be included in the log
        /// </summary>
        public MSBuildBinaryLogImports Imports { get; set; }
    }
}

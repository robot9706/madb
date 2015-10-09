﻿// <copyright file="IDebugPortProvider.cs" company="The Android Open Source Project, Ryan Conrad, Quamotion">
// Copyright (c) The Android Open Source Project, Ryan Conrad, Quamotion. All rights reserved.
// </copyright>

namespace Managed.Adb
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IDebugPortProvider
    {
        /// <summary>
        /// Returns a non-random debugger port for the specified application running on the specified Device.
        /// </summary>
        /// <param name="device">The device the application is running on.</param>
        /// <param name="appName">The application name, as defined in the <code>AndroidManifest.xml</code>
        /// <var>package</var> attribute of the <var>manifest</var> node.</param>
        /// <returns>The non-random debugger port or NO_STATIC_PORT if the Client
        /// should use the automatic debugger port provider.</returns>
        int getPort(IDevice device, string appName);
    }
}

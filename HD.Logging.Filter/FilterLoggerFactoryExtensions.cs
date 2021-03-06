// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using HD.Logging.Filter;
using HD.Logging.Filter.Filter.Internal;
using System;

namespace HD.Logging.Abstractions
{
    /// <summary>
    /// <see cref="ILoggerFactory"/> extension methods which provide a common way to filter log messages across all
    /// registered <see cref="ILoggerProvider"/>s.
    /// </summary>
    public static class FilterLoggerFactoryExtensions
    {
        /// <summary>
        /// Registers a wrapper logger which provides a common way to filter log messages across all registered
        ///  <see cref="ILoggerProvider"/>s.
        /// </summary>
        /// <param name="loggerFactory">The logger factory.</param>
        /// <param name="settings">The filter settings which get applied to all registered logger providers.</param>
        /// <returns>
        /// A wrapped <see cref="ILoggerFactory"/> which provides common filtering across all registered
        ///  logger providers.
        /// </returns>
        public static ILoggerFactory WithFilter(this ILoggerFactory loggerFactory, Action<FilterLoggerSettings> settingsConfig)
        {
            var settings = new FilterLoggerSettings();
            settingsConfig?.Invoke(settings);
            return new FilterLoggerFactory(loggerFactory, settings);
        }
    }
}

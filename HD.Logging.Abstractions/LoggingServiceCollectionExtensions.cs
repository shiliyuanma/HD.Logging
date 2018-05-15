// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using HD.Logging.Abstractions;
using System;

namespace Autofac
{
    /// <summary>
    /// Extension methods for setting up logging services in an <see cref="IServiceCollection" />.
    /// </summary>
    public static class LoggingServiceCollectionExtensions
    {
        /// <summary>
        /// Adds logging services to the specified <see cref="IServiceCollection" />.
        /// </summary>
        /// <param name="builder">The <see cref="IServiceCollection" /> to add services to.</param>
        /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
        //public static ContainerBuilder AddLogging(this ContainerBuilder builder)
        //{
        //    if (builder == null)
        //    {
        //        throw new ArgumentNullException(nameof(builder));
        //    }

        //    builder.RegisterInstance(LoggerFactory.Instance).As<ILoggerFactory>().SingleInstance();
        //    builder.RegisterGeneric(typeof(Logger<>)).As(typeof(ILogger<>)).SingleInstance();
        //    return builder;
        //}
    }
}
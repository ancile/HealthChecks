// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Microsoft.AspNetCore.HealthChecks
{
    public class HealthCheckStartupFilter : HealthCheckStartupFilter<HealthCheckMiddleware>
    {
        //private string _path;
        //private int? _port;
        //private TimeSpan _timeout;

        public HealthCheckStartupFilter(int port, TimeSpan timeout)
            :base(port, timeout)
        {
        }

        public HealthCheckStartupFilter(string path, TimeSpan timeout)
            : base(path, timeout)
        {
        }

        //public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        //{
        //    return app =>
        //    {
        //        if (_port.HasValue)
        //        {
        //            app.UseMiddleware<HealthCheckMiddleware>(_port, _timeout);
        //        }
        //        else
        //        {
        //            app.UseMiddleware<HealthCheckMiddleware>(_path, _timeout);
        //        }

        //        next(app);
        //    };
        //}
    }
}
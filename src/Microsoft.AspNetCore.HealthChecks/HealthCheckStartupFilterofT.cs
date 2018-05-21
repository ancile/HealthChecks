// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Microsoft.AspNetCore.HealthChecks
{
    public class HealthCheckStartupFilter<TMiddleware> : IStartupFilter
    {
        private string _path;
        private int? _port;
        private TimeSpan _timeout;

        public HealthCheckStartupFilter(int port, TimeSpan timeout)
        {
            _port = port;
            _timeout = timeout;
        }

        public HealthCheckStartupFilter(string path, TimeSpan timeout)
        {
            _path = path;
            _timeout = timeout;
        }

        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return app =>
            {
                if (_port.HasValue)
                {
                    app.UseMiddleware<TMiddleware>(_port, _timeout);
                }
                else
                {
                    app.UseMiddleware<TMiddleware>(_path, _timeout);
                }

                next(app);
            };
        }
    }
}
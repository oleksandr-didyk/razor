﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;

namespace Microsoft.AspNetCore.Razor.Telemetry;

public class NoOpTelemetryReporter : ITelemetryReporter
{
    public static readonly NoOpTelemetryReporter Instance = new();

    private NoOpTelemetryReporter()
    {
    }

    public void ReportEvent(string name, Severity severity)
    {
    }

    public void ReportEvent(string name, Severity severity, ImmutableDictionary<string, object?> values)
    {
    }

    public void ReportFault(Exception exception, string? message, params object?[] @params)
    {
    }

    public IDisposable BeginBlock(string name, Severity severity)
    {
        return NullScope.Instance;
    }

    public IDisposable BeginBlock(string name, Severity severity, ImmutableDictionary<string, object?> values)
    {
        return NullScope.Instance;
    }

    private class NullScope : IDisposable
    {
        public static NullScope Instance { get; } = new NullScope();
        private NullScope() { }
        public void Dispose() { }
    }
}

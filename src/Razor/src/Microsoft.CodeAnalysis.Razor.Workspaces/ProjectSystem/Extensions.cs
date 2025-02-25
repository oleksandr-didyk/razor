﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Razor;

namespace Microsoft.CodeAnalysis.Razor.ProjectSystem;

internal static class Extensions
{
    public static DocumentSnapshotHandle ToHandle(this IDocumentSnapshot snapshot)
        => new(snapshot.FilePath.AssumeNotNull(), snapshot.TargetPath.AssumeNotNull(), snapshot.FileKind.AssumeNotNull());

    public static ProjectSnapshotHandle ToHandle(this IProjectSnapshot snapshot)
        => new(snapshot.FilePath, snapshot.Configuration, snapshot.RootNamespace);
}

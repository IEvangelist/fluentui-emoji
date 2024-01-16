﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Fluent.Emoji.Models;

public record class EmojiDetails(
    Metadata Metadata,
    string[] Routes,
    bool? HasVariations = null)
{
    public string? DefaultImage
    {
        get
        {
            var hasVariations = HasVariations.GetValueOrDefault();
            var imageRoute = Routes.FirstOrDefault(route =>
            {
                var routeSegment = hasVariations ? "/Default/" : "/3D/";
                return route.Contains(routeSegment, StringComparison.OrdinalIgnoreCase);
            });

            return imageRoute;
        }
    }
}

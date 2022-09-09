﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace FluentUi.Emoji.Client.Models;

public readonly record struct Metadata(
    string Cldr,
    string FromVersion,
    string Glyph,
    string[] GlyphAsUtfInEmoticons,
    string Group,
    string[] Keywords,
    string[] MappedToEmoticons,
    string Tts,
    string Unicode);

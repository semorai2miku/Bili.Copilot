﻿// Copyright (c) Reader Copilot. All rights reserved.
// <auto-generated />

namespace Bili.Copilot.App.Controls.Markdown;

public record MarkdownConfig
{
    public string BaseUrl { get; set; }
    public IImageProvider ImageProvider { get; set; }
    public ISVGRenderer SVGRenderer { get; set; }
    public MarkdownThemes Themes { get; set; } = MarkdownThemes.Default;

    public static MarkdownConfig Default = new();
}

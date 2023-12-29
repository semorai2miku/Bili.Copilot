﻿// Copyright (c) Reader Copilot. All rights reserved.
// <auto-generated />

using Markdig.Syntax.Inlines;
using Microsoft.UI.Xaml.Documents;

namespace Bili.Copilot.App.Controls.Markdown.TextElements;

internal class MyAutolinkInline : IAddChild
{
    private readonly AutolinkInline _autoLinkInline;

    public TextElement TextElement { get; private set; }

    public MyAutolinkInline(AutolinkInline autoLinkInline)
    {
        _autoLinkInline = autoLinkInline;
        TextElement = new Hyperlink()
        {
            NavigateUri = new Uri(autoLinkInline.Url),
        };
    }

    public void AddChild(IAddChild child)
    {
        try
        {
            var text = (MyInlineText)child;
            ((Hyperlink)TextElement).Inlines.Add((Run)text.TextElement);
        }
        catch (Exception ex)
        {
            throw new Exception("Error adding child to MyAutolinkInline", ex);
        }
    }
}

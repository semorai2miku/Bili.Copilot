﻿// Copyright (c) Reader Copilot. All rights reserved.
// <auto-generated />

using Markdig.Extensions.Tables;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml.Documents;

namespace Bili.Copilot.App.Controls.Markdown.TextElements;

internal class MyTableCell : IAddChild
{
    private readonly TableCell _tableCell;
    private Paragraph _paragraph = new Paragraph();
    private readonly MyFlowDocument _flowDocument;
    private readonly bool _isHeader;

    public TextElement TextElement => _paragraph;

    public Grid Container { get; }

    public int ColumnSpan => _tableCell.ColumnSpan;

    public int RowSpan => _tableCell.RowSpan;

    public int ColumnIndex { get; }

    public int RowIndex { get; }

    public MyTableCell(TableCell tableCell, TextAlignment textAlignment, bool isHeader, int columnIndex, int rowIndex)
    {
        _isHeader = isHeader;
        _tableCell = tableCell;
        ColumnIndex = columnIndex;
        RowIndex = rowIndex;
        Container = new Grid();

        _flowDocument = new MyFlowDocument(tableCell);
        _flowDocument.RichTextBlock.TextWrapping = TextWrapping.Wrap;
        _flowDocument.RichTextBlock.TextAlignment = textAlignment;
        _flowDocument.RichTextBlock.HorizontalTextAlignment = textAlignment;
        _flowDocument.RichTextBlock.HorizontalAlignment = textAlignment switch
        {
            TextAlignment.Left => HorizontalAlignment.Left,
            TextAlignment.Center => HorizontalAlignment.Center,
            TextAlignment.Right => HorizontalAlignment.Right,
            _ => HorizontalAlignment.Left,
        };

        Container.Padding = new Thickness(4);
        if (_isHeader)
        {
            _flowDocument.RichTextBlock.FontWeight = FontWeights.Bold;
        }

        _flowDocument.RichTextBlock.HorizontalAlignment = textAlignment switch
        {
            TextAlignment.Left => HorizontalAlignment.Left,
            TextAlignment.Center => HorizontalAlignment.Center,
            TextAlignment.Right => HorizontalAlignment.Right,
            _ => HorizontalAlignment.Left,
        };
        Container.Children.Add(_flowDocument.RichTextBlock);
    }

    public void AddChild(IAddChild child) => _flowDocument.AddChild(child);
}

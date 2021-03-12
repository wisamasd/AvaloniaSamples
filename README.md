# Avalonia Sample

Port sample from book Pro WPF 4.5 in C#, by Matthew MacDonald

## Differences/Bugs/Futures

1. Default Button don't use value `Stretch` for properties `HorizontalAlignment`, `VerticalAlignment`, and don't use value `Center` for `HorizontalContentAlignment`, `VerticalContentAlignment`.
2. Don't correct resizing when resize window with `Grid` and using properties `SharedSizeGroup` (LayoutPanels/SharedSizeGroup).
3. Don't support `InkCanvas`.
4. The `Height` property of the `TextBox` object don't support value `auto`. In WPF LengthConverter converts `Auto` to `double.NaN`
5. The `TextWrapping` property of the `TextBox` object incorrect work with value `WrapWithOverflow`. Text don't wrap.
6. `WrapPanel` does not work like in WPF. It's don't get `Height` and `Width` from parent (Windows).
7. `TextBox` don't have properties `MinLines` and `MaxLines`.
namespace AsTrend.Library.Colors;

public static class PickerPalette
{
    public record NamedColor(AsColor Color, string Name)
    {
        public NamedColor(string aHex, string aName) : this(new AsColor(aHex), aName) { }
    }


    public record PaletteRow(string RowName, NamedColor[] Colors)
    {
        public static PaletteRow Separator() => new PaletteRow("", Array.Empty<NamedColor>());
    }


    public record Palette(PaletteRow[] Rows);


    public static Palette CreatePalette()
    {
        List<PaletteRow> paletteRowList = new();
        paletteRowList.Add(PaletteRow.Separator());

        MaterialPalette.CreatePalette(paletteRowList);

        return new Palette(paletteRowList.ToArray());
    }
}

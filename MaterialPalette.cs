using System.Drawing;
using MaterialDesignColors;
using MaterialDesignColors.Recommended;
using static AsTrend.Library.Colors.PickerPalette;

namespace AsTrend.Library.Colors;


public static class MaterialPalette
{
    public static void CreatePalette(List<PaletteRow> aPaletteRowList)
    {
        AddSwatch(new RedSwatch(), aPaletteRowList);
        AddSwatch(new PinkSwatch(), aPaletteRowList);
        AddSwatch(new PurpleSwatch(), aPaletteRowList);
        AddSwatch(new DeepPurpleSwatch(), aPaletteRowList);

        aPaletteRowList.Add(PaletteRow.Separator());

        AddSwatch(new IndigoSwatch(), aPaletteRowList);
        AddSwatch(new BlueSwatch(), aPaletteRowList);
        AddSwatch(new LightBlueSwatch(), aPaletteRowList);
        AddSwatch(new CyanSwatch(), aPaletteRowList);

        aPaletteRowList.Add(PaletteRow.Separator());

        AddSwatch(new TealSwatch(), aPaletteRowList);
        AddSwatch(new GreenSwatch(), aPaletteRowList);
        AddSwatch(new LightGreenSwatch(), aPaletteRowList);
        AddSwatch(new LimeSwatch(), aPaletteRowList);

        aPaletteRowList.Add(PaletteRow.Separator());

        AddSwatch(new YellowSwatch(), aPaletteRowList);
        AddSwatch(new AmberSwatch(), aPaletteRowList);
        AddSwatch(new OrangeSwatch(), aPaletteRowList);
        AddSwatch(new DeepOrangeSwatch(), aPaletteRowList);

        aPaletteRowList.Add(PaletteRow.Separator());
        AddSwatch(new BrownSwatch(), aPaletteRowList);
        AddSwatch(new GreySwatch(), aPaletteRowList);
    }


    static void AddSwatch(ISwatch aSwatch, List<PaletteRow> aPaletteRowList)
    {
        NamedColor[] colors = aSwatch.Lookup.Select(i => new NamedColor(new AsColor(i.Value), i.Key.ToString())).ToArray();
        aPaletteRowList.Add(new PaletteRow(aSwatch.Name, colors));

    }
}

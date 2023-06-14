global using System.Drawing;

namespace MaterialDesignColors;

public static class ColorConverter
{
    public static Color ConvertFromString(string aHtmlHexColor) => ColorTranslator.FromHtml(aHtmlHexColor);
}


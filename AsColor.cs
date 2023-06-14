using System;
using System.Drawing;

namespace AsTrend.Library.Colors
{
    public readonly struct AsColor : IEquatable<AsColor>
    {
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;

        public string Hex => ToString();

        public AsColor(byte aR, byte aG, byte aB)
        {
            R = aR;
            G = aG;
            B = aB;
        }


        public AsColor(Color aColor) : this(aColor.R, aColor.G, aColor.B)
        {
        }


        public AsColor(string aHtmlHexColor)
        {
            Color color = ColorTranslator.FromHtml(aHtmlHexColor);
            R = color.R;
            G = color.G;
            B = color.B;
        }


        public override string ToString()
        {
            return $"#{R:X2}{G:X2}{B:X2}";
        }


        public string Serialize()
        {
            return $"{R},{G},{B}";
        }


        public override bool Equals(object? aObj)
        {
            return aObj is AsColor color && Equals(color);
        }


        public bool Equals(AsColor aOther)
        {
            return R == aOther.R &&
                   G == aOther.G &&
                   B == aOther.B;
        }


        public static bool operator ==(AsColor aLeft, AsColor aRight)
        {
            return aLeft.Equals(aRight);
        }


        public static bool operator !=(AsColor aLeft, AsColor aRight)
        {
            return !(aLeft == aRight);
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(R, G, B, Hex);
        }

    }
}

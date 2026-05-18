using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums.ColorPalettes;

/// <summary>
/// An enum for Tailwind color palettes
/// </summary>
[EnumValue<string>]
public sealed partial class ColorPaletteEnum
{
    public static readonly ColorPaletteEnum Slate = new("slate");
    public static readonly ColorPaletteEnum Gray = new("gray");
    public static readonly ColorPaletteEnum Zinc = new("zinc");
    public static readonly ColorPaletteEnum Neutral = new("neutral");
    public static readonly ColorPaletteEnum Stone = new("stone");
    public static readonly ColorPaletteEnum Red = new("red");
    public static readonly ColorPaletteEnum Orange = new("orange");
    public static readonly ColorPaletteEnum Amber = new("amber");
    public static readonly ColorPaletteEnum Yellow = new("yellow");
    public static readonly ColorPaletteEnum Lime = new("lime");
    public static readonly ColorPaletteEnum Green = new("green");
    public static readonly ColorPaletteEnum Emerald = new("emerald");
    public static readonly ColorPaletteEnum Teal = new("teal");
    public static readonly ColorPaletteEnum Cyan = new("cyan");
    public static readonly ColorPaletteEnum Sky = new("sky");
    public static readonly ColorPaletteEnum Blue = new("blue");
    public static readonly ColorPaletteEnum Indigo = new("indigo");
    public static readonly ColorPaletteEnum Violet = new("violet");
    public static readonly ColorPaletteEnum Purple = new("purple");
    public static readonly ColorPaletteEnum Fuchsia = new("fuchsia");
    public static readonly ColorPaletteEnum Pink = new("pink");
    public static readonly ColorPaletteEnum Rose = new("rose");
}
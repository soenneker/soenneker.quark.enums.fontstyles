using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents a CSS <c>font-style</c> keyword.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public partial class FontStyleKeyword
{
    /// <summary>
    /// Italic text.
    /// </summary>
    public static readonly FontStyleKeyword Italic = new("italic");

    /// <summary>
    /// Normal (non-italic) text.
    /// </summary>
    public static readonly FontStyleKeyword Normal = new("normal");
}

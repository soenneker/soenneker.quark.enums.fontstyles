using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An HTML CSS in a .NET enumeration form
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

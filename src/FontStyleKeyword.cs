using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An HTML CSS in a .NET enumeration form
/// </summary>
[Intellenum<string>]
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

    public static implicit operator FontStyleKeyword(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}

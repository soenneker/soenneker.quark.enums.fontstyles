using Intellenum;
using Soenneker.Quark.Enums.GlobalKeywords;

namespace Soenneker.Quark;

/// <summary>
/// An HTML CSS in a .NET enumeration form
/// </summary>
[Intellenum<string>]
public partial class FontStyle
{
    /// <summary>
    /// Italic text.
    /// </summary>
    public static readonly FontStyle Italic = new("italic");

    /// <summary>
    /// Normal (non-italic) text.
    /// </summary>
    public static readonly FontStyle Normal = new("normal");

    public static implicit operator FontStyle(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}

using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.Email.Format;

/// <summary>
/// An enumerator for email formats
/// </summary>
[EnumValue<string>]
public sealed partial class EmailFormat
{
    public static readonly EmailFormat Plaintext = new(nameof(Plaintext));

    public static readonly EmailFormat Html = new(nameof(Html));
}
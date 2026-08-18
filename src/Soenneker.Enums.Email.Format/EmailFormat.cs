using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.Email.Format;

/// <summary>
/// Identifies the markup format used for an email message body.
/// </summary>
[EnumValue<string>]
public sealed partial class EmailFormat
{
    /// <summary>
    /// Unformatted plain-text email content.
    /// </summary>
    public static readonly EmailFormat Plaintext = new(nameof(Plaintext));

    /// <summary>
    /// HTML-formatted email content.
    /// </summary>
    public static readonly EmailFormat Html = new(nameof(Html));
}

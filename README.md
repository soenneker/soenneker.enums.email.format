[![](https://img.shields.io/nuget/v/soenneker.enums.email.format.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.email.format/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.email.format/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.email.format/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.email.format.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.email.format/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.email.format/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.email.format/actions/workflows/codeql.yml)

# Soenneker.Enums.Email.Format

A string-backed enum-value type for marking an email body as plain text or HTML.

## Install

```bash
dotnet add package Soenneker.Enums.Email.Format
```

## Usage

```csharp
using Soenneker.Enums.Email.Format;

EmailFormat format = EmailFormat.Html;
string wireValue = format.Value; // "Html"

if (EmailFormat.TryFromValue(input, out EmailFormat? parsed))
{
    // parsed is Plaintext or Html
}
```

Available values:

- `Plaintext` — unformatted text content
- `Html` — HTML-formatted content

`System.Text.Json` serializes the type as its string value and restores recognized values to the shared static instances. `FromValue` throws for unknown input; use `TryFromValue` at request and provider boundaries. `FromName` and `TryFromName` are also generated.

This type labels the body format; it does not convert between formats or set a MIME content type by itself. The mail transport must map it to the correct body representation. When producing HTML, encode or sanitize untrusted values before interpolation; choosing `Html` does not make content safe.

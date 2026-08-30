[![](https://img.shields.io/nuget/v/soenneker.quark.enums.fontstyles.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.fontstyles/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.fontstyles/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.fontstyles/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.fontstyles/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.fontstyles/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.fontstyles.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.fontstyles/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.fontstyles/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.fontstyles/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.FontStyles

Strongly typed CSS `font-style` keywords for Quark components and styles.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.FontStyles
```

## Usage

```csharp
FontStyleKeyword style = FontStyleKeyword.Italic;
string cssValue = style.Value; // "italic"
```

Use `FontStyleKeyword.Normal` to explicitly restore non-italic text. The type also includes CSS-wide values from `GlobalKeyword`, such as `Inherit`, `Initial`, `Revert`, `RevertLayer`, and `Unset`.

## Values

| Member | CSS value |
| --- | --- |
| `Italic` | `italic` |
| `Normal` | `normal` |

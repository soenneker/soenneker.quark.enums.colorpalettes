[![](https://img.shields.io/nuget/v/soenneker.quark.enums.colorpalettes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.colorpalettes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.colorpalettes/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.colorpalettes/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.colorpalettes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.colorpalettes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.colorpalettes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.colorpalettes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.colorpalettes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.colorpalettes/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.ColorPalettes

Strongly named tokens for Tailwind's standard color palette families.

## Installation

```bash
dotnet add package Soenneker.Quark.Enums.ColorPalettes
```

## Usage

```csharp
using Soenneker.Quark;

ColorPaletteEnum palette = ColorPaletteEnum.Emerald;
string token = palette.Value;
// emerald

string className = $"bg-{palette.Value}-600";
// bg-emerald-600
```

Available values are `Slate`, `Gray`, `Zinc`, `Neutral`, `Stone`, `Red`, `Orange`, `Amber`, `Yellow`, `Lime`, `Green`, `Emerald`, `Teal`, `Cyan`, `Sky`, `Blue`, `Indigo`, `Violet`, `Purple`, `Fuchsia`, `Pink`, and `Rose`.

The type represents the palette family only. Append a shade in the consuming builder or class expression; theme configuration determines the resulting CSS color.

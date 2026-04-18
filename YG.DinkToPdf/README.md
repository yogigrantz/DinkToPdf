# YG.DinkToPdf

A lightweight .NET 8+ wrapper for the native wkhtmltopdf library that converts HTML into PDF documents.

This package modernizes the original DinkToPdf project for current .NET applications.

## Why YG.DinkToPdf Exists

The original DinkToPdf package was useful but has not been actively maintained for years and targeted early .NET Core versions.

YG.DinkToPdf updates that wrapper for modern .NET 8+ projects and includes the required native `libwkhtmltox.dll` for Windows x64.

## Features

- Targets .NET 8+
- Includes native `libwkhtmltox.dll`
- HTML to PDF conversion
- Simple dependency injection setup
- Compatible with ASP.NET Core / console / worker apps

## Installation


<ItemGroup>
  <PackageReference Include="YG.DinkToPdf" Version="1.1.1" />
</ItemGroup>

## Usage
    //In program.cs with DI
    using DinkToPdf;
    using DinkToPdf.Contracts;

    builder.Services.AddSingleton<IConverter>(new SynchronizedConverter(new PdfTools()));

    //In functions: 
    //// Inject IConverter into your service/class

    var doc = new HtmlToPdfDocument
    {
        GlobalSettings =
        {
            PaperSize = PaperKind.A4
        },
        Objects =
        {
            new ObjectSettings
            {
                HtmlContent = html
            }
        }
    };

    byte[] pdf = _converter.Convert(doc);

## Platform Support

    Windows X64

## License

    MIT

## Third-Party Native Dependency

This package includes `libwkhtmltox.dll`, provided by the wkhtmltopdf project.

Project: wkhtmltopdf  
Source: https://wkhtmltopdf.org/  
License: LGPLv3
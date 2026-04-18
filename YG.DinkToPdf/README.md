# YG.DinktoPdf

A lightweight c# .net class library that wraps libwkhtltox.lb c++ code to convert html to pdf printed pages

YG.DinktoPdf targets .NET .NET 8+ projects.

Why YG.DinktoPdf Exists (The Honest Version)

because the original DinktoPdf was published in 2017 for .net core 1 and does not seem to be maintained

Frameworks are tools. Production is the truth.

## Installation

Include libwkhtmltox and this package in the project file 
  <ItemGroup>
    <None Remove="libwkhtmltox.lib" />
  </ItemGroup>

  <ItemGroup>
    <Content Include="libwkhtmltox.lib">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </Content>
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="DinkToPdf" Version="1.0.8" />
    ....
  </ItemGroup>

⚠️ Use code inside a Try catch block. For brevity, there is no try catch block in GetDataSet

## Usage

        DI IoC registration: 

        using DinkToPdf;
        using DinkToPdf.Contracts;
     
        builder.Services.AddSingleton<IConverter>(new SynchronizedConverter(new PdfTools()));


        var doc = new HtmlToPdfDocument()
        {
            GlobalSettings = {
                PaperSize = PaperKind.A4
                },
            Objects = {
                    new ObjectSettings {
                    HtmlContent = sb.ToString()
                }
            }
        };

        byte[] pdf = _converter.Convert(doc);
        return pdf;

## Examples


Output:
----------
 
The output is a Tuple<DataSet,Dictionary<string, object>, Exception> for GetDataSet with SP or Dictionary for ExecSP. 


## Dependencies

Microsoft.Data.SqlClient

## Contributing

Any new ideas on how to enhance this class without adding much complexity, please adhere to SOLID principle   

## License

This project is licensed under the MIT License(LICENSE).  

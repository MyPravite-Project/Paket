﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Paket.Core")>]
[<assembly: AssemblyProductAttribute("Paket")>]
[<assembly: AssemblyCompanyAttribute("Paket team")>]
[<assembly: AssemblyDescriptionAttribute("A package dependency manager for .NET with support for NuGet packages and GitHub repositories.")>]
[<assembly: AssemblyVersionAttribute("1.13.0")>]
[<assembly: AssemblyFileVersionAttribute("1.13.0")>]
[<assembly: AssemblyInformationalVersionAttribute("1.13.0-alpha001")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.13.0"

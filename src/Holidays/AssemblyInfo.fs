namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Holidays")>]
[<assembly: AssemblyProductAttribute("Holidays")>]
[<assembly: AssemblyDescriptionAttribute("Utility to tell which days are holidays and which are workdays")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
    let [<Literal>] InformationalVersion = "1.0"

#pragma checksum "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "764874fb5353103bacaacedf211fc8de2d7fe5f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Birim_BirimGetir), @"mvc.1.0.view", @"/Views/Birim/BirimGetir.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\_ViewImports.cshtml"
using telefonrehberi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\_ViewImports.cshtml"
using telefonrehberi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764874fb5353103bacaacedf211fc8de2d7fe5f4", @"/Views/Birim/BirimGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37cce4fbc4dbb7a27c8a721fcc8078b0fcb08d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Birim_BirimGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<telefonrehberi.Models.Birim>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimGetir.cshtml"
  
    ViewData["Title"] = "BirimGetir";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimGetir.cshtml"
 using (Html.BeginForm("BirimGuncelle", "Birim", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Birim ID</b>\r\n    <br />\r\n");
#nullable restore
#line 14 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimGetir.cshtml"
Write(Html.TextBoxFor(x => x.BirimID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <b>Birim Adı</b>\r\n    <br />\r\n");
#nullable restore
#line 20 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimGetir.cshtml"
Write(Html.TextBoxFor(x => x.BirimAdi, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Birim Yöneticisi</b>\r\n    <br />\r\n");
#nullable restore
#line 25 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimGetir.cshtml"
Write(Html.TextBoxFor(x => x.BirimYoneticisi, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-info\">Birim Güncelle</button>\r\n");
#nullable restore
#line 30 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimGetir.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<telefonrehberi.Models.Birim> Html { get; private set; }
    }
}
#pragma warning restore 1591
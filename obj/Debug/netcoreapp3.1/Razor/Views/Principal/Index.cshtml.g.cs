#pragma checksum "C:\Users\mille\OneDrive\Área de Trabalho\TrocaJusta\TrocaJusta\Views\Principal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8243a4bfa912cd304bc9f827b55da0291078e4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Principal_Index), @"mvc.1.0.view", @"/Views/Principal/Index.cshtml")]
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
#line 1 "C:\Users\mille\OneDrive\Área de Trabalho\TrocaJusta\TrocaJusta\Views\_ViewImports.cshtml"
using TrocaJusta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mille\OneDrive\Área de Trabalho\TrocaJusta\TrocaJusta\Views\_ViewImports.cshtml"
using TrocaJusta.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8243a4bfa912cd304bc9f827b55da0291078e4b", @"/Views/Principal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ae353ce5771c509e0e4b8ac7def777f4731efed", @"/Views/_ViewImports.cshtml")]
    public class Views_Principal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mille\OneDrive\Área de Trabalho\TrocaJusta\TrocaJusta\Views\Principal\Index.cshtml"
  
    Layout = "_LayoutDeslogado";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8243a4bfa912cd304bc9f827b55da0291078e4b3552", async() => {
                WriteLiteral(@"
  <title>Bootstrap Example</title>
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
  <style>
  .carousel-inner > .item > img,
  .carousel-inner > .item > a > img {
    width: 30%;
    margin: auto;
  }
  </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8243a4bfa912cd304bc9f827b55da0291078e4b5093", async() => {
                WriteLiteral(@"
    <div class=""display-4"">
    <h1>Troca Justa</h1> 
    <h3> Não quero dinheiro , quero uma TROCA JUSTA!</h3>

</div> <br><br><br>
    <div class=""container"">
    
    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
    <!-- Indicators -->
    <ol class=""carousel-indicators"">
      <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
      <li data-target=""#myCarousel"" data-slide-to=""1""></li>
      <li data-target=""#myCarousel"" data-slide-to=""2""></li>
      <li data-target=""#myCarousel"" data-slide-to=""3""></li>
    </ol>

    <!-- Wrapper for slides -->
    <div class=""carousel-inner"" role=""listbox"">

      <div class=""item active"">
        <img src=""img/pexels-andrea-piacquadio-3760069.jpg"" alt=""Chania"" width=""500"" height=""200"">
        <div class=""carousel-caption"">
          
        </div>
      </div>

      <div class=""item"">
        <img src=""img/pexels-pixabay-38293.jpg"" alt=""Chania"" width=""500"" height=""200"">
        <div class=""carousel");
                WriteLiteral(@"-caption"">
         
        </div>
      </div>
    
      <div class=""item"">
        <img src=""img/pexels-pixabay-73833.jpg"" alt=""Flower"" width=""500"" height=""200"">
        <div class=""carousel-caption"">
          
        </div>
      </div>
      <div class=""item"">
        <img src=""img/pexels-tim-samuel-5835362.jpg"" alt=""Flower"" width=""500"" height=""200"">
        <div class=""carousel-caption"">
          
        </div>
      </div>

      <div class=""item"">
        <img src=""img/pexels-thirdman-5961027.jpg"" alt=""Flower"" width=""500"" height=""200"">
        <div class=""carousel-caption"">
          
        </div>
      </div>
  
    </div>

    <!-- Left and right controls -->
    <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
      <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
      <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""ne");
                WriteLiteral("xt\">\r\n      <span class=\"glyphicon glyphicon-chevron-right\" aria-hidden=\"true\"></span>\r\n      <span class=\"sr-only\">Next</span>\r\n    </a>\r\n  </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

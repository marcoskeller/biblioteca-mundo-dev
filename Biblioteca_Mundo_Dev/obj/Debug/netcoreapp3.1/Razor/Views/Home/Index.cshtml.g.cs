#pragma checksum "C:\Source\projetos\Biblioteca_Mundo_Dev\Biblioteca_Mundo_Dev\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48b22ae3b3cf7e9fec2cf593b20a1d3887d26cb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Source\projetos\Biblioteca_Mundo_Dev\Biblioteca_Mundo_Dev\Views\_ViewImports.cshtml"
using Biblioteca_Mundo_Dev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Source\projetos\Biblioteca_Mundo_Dev\Biblioteca_Mundo_Dev\Views\_ViewImports.cshtml"
using Biblioteca_Mundo_Dev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48b22ae3b3cf7e9fec2cf593b20a1d3887d26cb9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d22f9b39b7bd7ac42a6934012f605a2ba3ff45c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Source\projetos\Biblioteca_Mundo_Dev\Biblioteca_Mundo_Dev\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #icon{
        margin-top:20px;
        font-size:50px;
        color:#0026ff;
    }
    #icon:hover{
        color:red;
        font-size:60px;
    }
    .card{
        margin-top: 60px;
        margin-bottom:25px;
        border-radius: 10px;
        background-color:beige;
    }
    .row{
        
    }

</style>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/js/all.min.js"" integrity=""sha512-naukR7I+Nk6gp7p5TMA4ycgfxaZBJ7MO5iC3Fp6ySQyKFHOGfpkSZkYVWV5R7u7cfAicxanwYQ5D1e17EfJcMA=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>

<div class=""row"">
    <div class=""col-sm-12"">
        <h1 style=""text-align:center"">Biblioteca</h1>
    </div>
</div>

<hr />

<div class=""row"">

    <!--Classe Funcionários-->
    <div class=""col-lg-3"">
        <div class=""card"" style=""height:200px"">
            <div class=""card-body"">
                <h2 style=""text-align:center"">Funcionários</h2>
                <div style=""text-align:cen");
            WriteLiteral(@"ter"">
                    <i id=""icon"" class=""fa fa-user""></i>
                </div>
            </div>
        </div>
    </div>

    <!--Classe Fornecedores-->
    <div class=""col-lg-3"">
        <div class=""card"" style=""height:200px"">
            <div class=""card-body"">
                <h2 style=""text-align:center"">Fornecedores</h2>
                <div style=""text-align:center"">
                    <i id=""icon"" class=""fa fa-users""></i>
                </div>
            </div>
        </div>
    </div>

    <!--Classe Leitor-->
    <div class=""col-lg-3"">
        <div class=""card"" style=""height:200px"">
            <div class=""card-body"">
                <h2 style=""text-align:center"">Leitor</h2>
                <div style=""text-align:center"">
                    <i id=""icon"" class=""fa fa-book-reader""></i>
                </div>
            </div>
        </div>
    </div>

    <!--Classe Livros-->
    <div class=""col-lg-3"">
        <div class=""card"" style=""height:200px"">
  ");
            WriteLiteral(@"          <div class=""card-body"">
                <h2 style=""text-align:center"">Livro</h2>
                <div style=""text-align:center"">
                    <i id=""icon"" class=""fa fa-book""></i>
                </div>
            </div>
        </div>
    </div>

    <!--Classe Adicionar-->
    <div class=""col-lg-3"">
        <div class=""card"" style=""height:200px"">
            <div class=""card-body"">
                <h2 style=""text-align:center"">Adicionar</h2>
                <div style=""text-align:center"">
                    <i id=""icon"" class=""fa fa-file-import""></i>
                </div>
            </div>
        </div>
    </div>

    <!--Classe Devolver-->
    <div class=""col-lg-3"">
        <div class=""card"" style=""height:200px"">
            <div class=""card-body"">
                <h2 style=""text-align:center"">Devolver</h2>
                <div style=""text-align:center"">
                    <i id=""icon"" class=""fa fa-undo-alt""></i>
                </div>
            </div>");
            WriteLiteral(@"
        </div>
    </div>

    <!--Classe Empréstimo-->
    <div class=""col-lg-3"">
        <div class=""card"" style=""height:200px"">
            <div class=""card-body"">
                <h2 style=""text-align:center"">Empréstimo</h2>
                <div style=""text-align:center"">
                    <i id=""icon"" class=""fa fa-file-invoice""></i>
                </div>
            </div>
        </div>
    </div>

    <!--Classe Localização-->
    <div class=""col-lg-3"">
        <div class=""card"" style=""height:200px"">
            <div class=""card-body"">
                <h2 style=""text-align:center"">Localização</h2>
                <div style=""text-align:center"">
                    <i id=""icon"" class=""fa fa-map-marker""></i>
                </div>
            </div>
        </div>
    </div>

</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

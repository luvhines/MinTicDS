#pragma checksum "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "178ad88271f17433264e85952b82f8b959269e7f"
// <auto-generated/>
#pragma warning disable 1591
namespace MyPyme.App.Ui.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\_Imports.razor"
using MyPyme.App.Ui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\_Imports.razor"
using MyPyme.App.Ui.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-tbrkohjn1u");
            __builder.AddMarkupContent(3, @"<div class=""cabecera"" b-tbrkohjn1u><div id=""cabecera_div-1"" b-tbrkohjn1u><img src=""iconos/icon_1.png"" alt=""icono1"" width=""22%"" height=""100%"" b-tbrkohjn1u></div>
        <div id=""cabecera_div-2"" b-tbrkohjn1u><h2 b-tbrkohjn1u>EMPRESA</h2></div>
        <div id=""cabecera_div-3"" b-tbrkohjn1u><div class=""form-row"" b-tbrkohjn1u><div class=""form-group col-md-6"" b-tbrkohjn1u><input type=""email"" class=""form-control"" id=""inputEmail4"" placeholder=""Email"" b-tbrkohjn1u></div>
                <div class=""form-group col-md-4"" b-tbrkohjn1u><input type=""password"" class=""form-control"" id=""inputPassword4"" placeholder=""Password"" b-tbrkohjn1u></div></div></div></div>

    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "cuerpo");
            __builder.AddAttribute(6, "b-tbrkohjn1u");
            __builder.AddContent(7, 
#nullable restore
#line 31 "C:\Grupo59-5\MinTicDS\Fuentes\MyPyme.App\MyPyme.App.Ui\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.AddMarkupContent(9, @"<div class=""pie"" b-tbrkohjn1u><div id=""pie_div_1"" b-tbrkohjn1u><img id=""img_pie"" src=""iconos/icon_8.png"" alt=""icon8"" width=""20%"" height=""100%"" b-tbrkohjn1u>
                <h5 b-tbrkohjn1u>316 807 0630</h5></div>
            <div id=""pie_div_2"" b-tbrkohjn1u><img id=""img_pie"" src=""iconos/icon_9.png"" alt=""icon9"" width=""20%"" height=""100%"" b-tbrkohjn1u>
                <h5 b-tbrkohjn1u>@Empresa</h5></div>
            <div id=""pie_div_3"" b-tbrkohjn1u><img id=""img_pie"" src=""iconos/icon_10.png"" alt=""icon10"" width=""20%"" height=""100%"" b-tbrkohjn1u>
                <h5 b-tbrkohjn1u>@Empresa</h5></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

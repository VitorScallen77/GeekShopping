#pragma checksum "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56e6476f9f1d44c9c8dc4c2ca1e86e7175e353a011ca9ee60263fa872719ccdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScopeListItem), @"mvc.1.0.view", @"/Views/Shared/_ScopeListItem.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"56e6476f9f1d44c9c8dc4c2ca1e86e7175e353a011ca9ee60263fa872719ccdf", @"/Views/Shared/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"70172ad1e11deb98c0fed2168cf30f9a40e06246251c96f3cd8e3b0a42d7f218", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ScopeViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<li class=\"list-group-item\">\n    <label>\n        <input class=\"consent-scopecheck\"\n               type=\"checkbox\"\n               name=\"ScopesConsented\"");
            BeginWriteAttribute("id", "\n               id=\"", 174, "\"", 213, 2);
            WriteAttributeValue("", 194, "scopes_", 194, 7, true);
#nullable restore
#line 8 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 201, Model.Value, 201, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\n               value=\"", 214, "\"", 249, 1);
#nullable restore
#line 9 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 237, Model.Value, 237, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\n               checked=\"", 250, "\"", 289, 1);
#nullable restore
#line 10 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 275, Model.Checked, 275, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\n               disabled=\"", 290, "\"", 331, 1);
#nullable restore
#line 11 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 316, Model.Required, 316, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 12 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"\n                   name=\"ScopesConsented\"");
            BeginWriteAttribute("value", "\n                   value=\"", 449, "\"", 488, 1);
#nullable restore
#line 16 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 476, Model.Value, 476, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 17 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>");
#nullable restore
#line 18 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n");
#nullable restore
#line 19 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\n");
#nullable restore
#line 22 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </label>\n");
#nullable restore
#line 24 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span><em>(required)</em></span>\n");
#nullable restore
#line 27 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"consent-description\">\n            <label");
            BeginWriteAttribute("for", " for=\"", 861, "\"", 886, 2);
            WriteAttributeValue("", 867, "scopes_", 867, 7, true);
#nullable restore
#line 31 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 874, Model.Value, 874, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n        </div>\n");
#nullable restore
#line 33 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Resources?.Any() == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"consent-description\">\n            <label>Will be available to these resource servers:</label>\n            <ul>\n");
#nullable restore
#line 39 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
             foreach (var resource in Model.Resources)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 41 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
               Write(resource.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 42 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </div>\n");
#nullable restore
#line 45 "C:\Users\scall\OneDrive\Documentos\DOTNET\GeekShopping\GeekShopping.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScopeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

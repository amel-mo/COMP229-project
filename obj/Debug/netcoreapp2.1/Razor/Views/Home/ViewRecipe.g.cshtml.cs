#pragma checksum "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03478bcde93d38a578dbac4d6e6f111f2e3cee91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewRecipe), @"mvc.1.0.view", @"/Views/Home/ViewRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewRecipe.cshtml", typeof(AspNetCore.Views_Home_ViewRecipe))]
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
#line 1 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\_ViewImports.cshtml"
using Recipes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03478bcde93d38a578dbac4d6e6f111f2e3cee91", @"/Views/Home/ViewRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e841be1e0d9941dbb9198d3d39aa3099b8020fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Recipe>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/salmonBaked.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("position center-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReviewRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#019966"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RecipeList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
  
    ViewBag.Title = "Review Recipe";

#line default
#line hidden
            BeginContext(75, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b46c74458c54da998b357b96b47a466", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(143, 9, true);
            WriteLiteral("<p></p>\r\n");
            EndContext();
#line 7 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
 foreach (Recipe recipe in Model)
{

#line default
#line hidden
            BeginContext(190, 50, true);
            WriteLiteral("    <h3 class=\"text-center\" style=\"color:#019966\">");
            EndContext();
            BeginContext(241, 17, false);
#line 9 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
                                             Write(recipe.RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(258, 307, true);
            WriteLiteral(@"</h3>
    <table class=""table table-sm table-striped table-bordered"">
        <thead>

        </thead>

        <tbody class=""text-left"">
            <tr style=""color:#666666"">
                <td style=""color:#019966"">
                    Recipe Id:
                    <p style=""color:#666666"">");
            EndContext();
            BeginContext(566, 15, false);
#line 19 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
                                        Write(recipe.RecipeId);

#line default
#line hidden
            EndContext();
            BeginContext(581, 152, true);
            WriteLiteral("</p>\r\n                </td>\r\n                <td style=\"color:#019966\">\r\n                    Recipe Name:\r\n                    <p style=\"color:#666666\">");
            EndContext();
            BeginContext(734, 17, false);
#line 23 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
                                        Write(recipe.RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(751, 211, true);
            WriteLiteral("</p>\r\n                </td>\r\n            </tr>\r\n            <tr style=\"color:#666666\">\r\n                <td style=\"color:#019966\">\r\n                    Recipe Type:\r\n                    <p style=\"color:#666666\">");
            EndContext();
            BeginContext(963, 17, false);
#line 29 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
                                        Write(recipe.RecipeType);

#line default
#line hidden
            EndContext();
            BeginContext(980, 149, true);
            WriteLiteral("</p>\r\n                </td>\r\n                <td style=\"color:#019966\">\r\n                    Added By:\r\n                    <p style=\"color:#666666\">");
            EndContext();
            BeginContext(1130, 14, false);
#line 33 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
                                        Write(recipe.AddedBy);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 209, true);
            WriteLiteral("</p>\r\n                </td>\r\n            </tr>\r\n            <tr style=\"color:#666666\">\r\n                <td style=\"color:#019966\">\r\n                    Prep(min):\r\n                    <p style=\"color:#666666\">");
            EndContext();
            BeginContext(1354, 15, false);
#line 39 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
                                        Write(recipe.PrepTime);

#line default
#line hidden
            EndContext();
            BeginContext(1369, 150, true);
            WriteLiteral("</p>\r\n                </td>\r\n                <td style=\"color:#019966\">\r\n                    Cook(min):\r\n                    <p style=\"color:#666666\">");
            EndContext();
            BeginContext(1520, 15, false);
#line 43 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
                                        Write(recipe.CookTime);

#line default
#line hidden
            EndContext();
            BeginContext(1535, 196, true);
            WriteLiteral("</p>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <b style=\"color:#019966\">Ingredients:</b>\r\n                    <p style=\"color:#666666\">");
            EndContext();
            BeginContext(1732, 18, false);
#line 49 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
                                        Write(recipe.Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(1750, 160, true);
            WriteLiteral("</p>\r\n\r\n                </td>\r\n                <td>\r\n                    <b style=\"color:#019966\">Directions:</b>\r\n                    <p style=\"color:#666666\">");
            EndContext();
            BeginContext(1911, 17, false);
#line 54 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
                                        Write(recipe.Directions);

#line default
#line hidden
            EndContext();
            BeginContext(1928, 87, true);
            WriteLiteral("</p>\r\n                </td>\r\n            </tr>\r\n        </tbody>       \r\n    </table>\r\n");
            EndContext();
#line 59 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
}

#line default
#line hidden
            BeginContext(2018, 127, true);
            WriteLiteral("\r\n<table align=\"center\">\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n                <b style=\"color:#019966\">Pictures:</b>\r\n");
            EndContext();
#line 66 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
                 foreach (var file in Model)
                {
                    

#line default
#line hidden
            BeginContext(2231, 47, false);
#line 68 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
               Write(await Html.PartialAsync("PictureSummary", file));

#line default
#line hidden
            EndContext();
#line 68 "C:\Users\Owner\Desktop\COMP229_G5_recipe\COMP229_G5_recipe\Recipes\Recipes\Views\Home\ViewRecipe.cshtml"
                                                                    
                }

#line default
#line hidden
            BeginContext(2299, 111, true);
            WriteLiteral("            </td>\r\n\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n    <h4 style=\"color:#666666\" class=\"text-center\"> ");
            EndContext();
            BeginContext(2410, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "268c9ecbcccc4452b58cae950ac38d93", async() => {
                BeginContext(2478, 12, true);
                WriteLiteral("View Reviews");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2494, 83, true);
            WriteLiteral("</h4>\r\n    <h5 style=\"color:#666666\" class=\"text-center\">To go back to Recipes List");
            EndContext();
            BeginContext(2577, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02cd744aeb454eceb8a8f02fc7e4d173", async() => {
                BeginContext(2643, 10, true);
                WriteLiteral("Click here");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2657, 9, true);
            WriteLiteral("</h5>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
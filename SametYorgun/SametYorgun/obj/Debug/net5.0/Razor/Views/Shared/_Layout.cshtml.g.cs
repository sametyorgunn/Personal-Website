#pragma checksum "C:\Users\asame\source\repos\SametYorgun\SametYorgun\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d859573bcf9fe563521951e569c6cc30236f2179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\asame\source\repos\SametYorgun\SametYorgun\Views\_ViewImports.cshtml"
using SametYorgun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asame\source\repos\SametYorgun\SametYorgun\Views\_ViewImports.cshtml"
using SametYorgun.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d859573bcf9fe563521951e569c6cc30236f2179", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed2c7fc73d60aa2d6cc5801f8b7b17660450d893", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/kisisel/js/vendor/jquary.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/kisisel/js/vendor/slick.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/kisisel/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n\r\n<!-- Mirrored from bostamihtml.ibthemespro.com/aboutOne.html by HTTrack Website Copier/3.x [XR&CO\'2014], Sat, 08 Oct 2022 13:08:26 GMT -->\r\n");
#nullable restore
#line 6 "C:\Users\asame\source\repos\SametYorgun\SametYorgun\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("~/Views/LayoutPartials/Head/HeadStyles.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d859573bcf9fe563521951e569c6cc30236f21794849", async() => {
                WriteLiteral(@"
    <!-- PRELOADER -->
    <div id=""preloader"">
        <div class=""loader_line""></div>
    </div>
    <!-- /PRELOADER -->

    <div class=""bg-homeBg dark:bg-homeTwoBg-dark min-h-screen bg-no-repeat bg-center bg-cover bg-fixed md:pb-16 w-full"">
        <div class=""section-bg"">
            <div class=""w-full flex justify-between px-4"">
                <!-- website Logo -->
");
                WriteLiteral("                <div class=\"flex items-center\">\r\n                    <!-- dark and light mode toggle -->\r\n");
                WriteLiteral(@"                    <!-- mobile toggle button -->
                    <button id=""menu-toggle"" type=""button"" class=""menu-toggle-btn"">
                        <i id=""menu-toggle-open-icon"" class=""fa-solid fa-bars text-xl ""></i>
                        <i id=""menu-toggle-close-icon"" class=""fa-solid fa-xmark text-xl hidden  ""></i>
                    </button>
                </div>
            </div>
        </div>

        <!-- mobile menu start -->
        <nav id=""navbar"" class=""hidden lg:hidden"">
            <ul class=""block rounded-b-[20px] shadow-md absolute left-0 top-20 z-[22222222222222] w-full bg-white dark:bg-[#1d1d1d]"">
                <li>
                    <a class=""mobile-menu-items-active"" href=""/Home/Index"">
                        <span class=""mr-2 text-xl"">
                            <i class=""fa-regular fa-user""></i>
                        </span>Hakkımda
                    </a>
                </li>
                <li>
                    <a class=""mobile-menu-item");
                WriteLiteral(@"s"" href=""/Home/OzGecmis"">
                        <span class=""mr-2 text-xl"">
                            <i class=""fa-regular fa-file-lines""></i>
                        </span>ÖzGeçmiş
                    </a>
                </li>
                <li>
                    <a class=""mobile-menu-items"" href=""/Home/Projeler"">
                        <span class=""mr-2 text-xl"">
                            <i class=""fas fa-briefcase""></i>
                        </span>Projeler
                    </a>
                </li>
                <li>
                    <a class=""mobile-menu-items"" href=""/Home/Blog"">
                        <span class=""mr-2 text-xl"">
                            <i class=""fa-brands fa-blogger""></i>
                        </span>Blog
                    </a>
                </li>
                <li>
                    <a class=""mobile-menu-items"" href=""/Home/Contact"">
                        <span class=""mr-2 text-xl"">
                            <i class=""fa-");
                WriteLiteral(@"solid fa-address-book""></i>
                        </span> İletişim
                    </a>
                </li>
            </ul>
        </nav>
        <!-- mobile menu end -->

        <div class=""container grid grid-cols-12 md:gap-10 justify-between lg:mt-[220px]"">
            <!-- sidber personal info -->
            ");
#nullable restore
#line 80 "C:\Users\asame\source\repos\SametYorgun\SametYorgun\Views\Shared\_Layout.cshtml"
       Write(await Component.InvokeAsync("KisiselBilgiler"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <div class=""col-span-12 lg:col-span-8"">
                <!-- header for mobile devices start -->
                <header class=""lg:w-[560px] h-[144px] hidden lg:block p-[30px] ml-auto mb-10 rounded-[16px] bg-white dark:bg-[#111111]"">
                    <nav class=""hidden lg:block"">
                        <ul class=""flex"">
                            <li>
                                <a class=""menu-active"" href=""/Home/Index"">
                                    <span class=""text-xl mb-1"">
                                        <i class=""fa-regular fa-user""></i>
                                    </span> Hakkımda
                                </a>
                            </li>
                            <li>
                                <a class=""menu-item"" href=""/Home/OzGecmis"">
                                    <span class=""text-xl mb-1"">
                                        <i class=""fa-regular fa-file-lines""></i>
                                    </span>");
                WriteLiteral(@" ÖzGeçmiş
                                </a>
                            </li>
                            <li>
                                <a class=""menu-item"" href=""/Home/Projeler"">
                                    <span class=""text-xl mb-1"">
                                        <i class=""fas fa-briefcase""></i>
                                    </span> Projeler
                                </a>
                            </li>
                            <li>
                                <a class=""menu-item"" href=""/Home/Blog"">
                                    <span class=""text-xl mb-1"">
                                        <i class=""fa-brands fa-blogger""></i>
                                    </span> Blog
                                </a>
                            </li>
                            <li>
                                <a class=""menu-item"" href=""/Home/Contact"">
                                    <span class=""text-xl mb-1"">
               ");
                WriteLiteral(@"                         <i class=""fa-solid fa-address-book""></i>
                                    </span> İletişim
                                </a>
                            </li>
                        </ul>
                    </nav>
                </header>
                <!-- header for mobile devices end -->
                <!-- about me section start -->
                <div>
                    <div class=""lg:rounded-2xl bg-white dark:bg-[#111111]"">
                        <div class=""pt-12 md:py-12 px-2 sm:px-5 md:px-10 lg:px-14"">
                           ");
#nullable restore
#line 129 "C:\Users\asame\source\repos\SametYorgun\SametYorgun\Views\Shared\_Layout.cshtml"
                      Write(await Component.InvokeAsync("MobilKisiselBilgiler"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                            ");
#nullable restore
#line 131 "C:\Users\asame\source\repos\SametYorgun\SametYorgun\Views\Shared\_Layout.cshtml"
                       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <!-- footer start -->
                        <footer class=""overflow-hidden rounded-b-2xl"" style=""background: transparent"">
                            <p class=""text-center py-6 text-gray-lite dark:text-color-910"">
                                © 2022 tüm hakları saklıdır -Samet Yorgun
                                by <a class=""hover:text-[#FA5252] duration-300 transition""
                                      href=""https://themeforest.net/user/ib-themes"" target=""_blank""
                                      rel=""noopener noreferrer""></a>.
                            </p>
                        </footer>
                        <!-- footer section end -->
                    </div>
                </div>

                <!-- about me section start -->
            </div>
        </div>
    </div>
    <!-- End bgHomeBg -->
    <!--==== js =====-->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d859573bcf9fe563521951e569c6cc30236f217912750", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d859573bcf9fe563521951e569c6cc30236f217913850", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- main js -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d859573bcf9fe563521951e569c6cc30236f217914974", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n\r\n<!-- Mirrored from bostamihtml.ibthemespro.com/aboutOne.html by HTTrack Website Copier/3.x [XR&CO\'2014], Sat, 08 Oct 2022 13:08:34 GMT -->\r\n</html>\r\n");
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

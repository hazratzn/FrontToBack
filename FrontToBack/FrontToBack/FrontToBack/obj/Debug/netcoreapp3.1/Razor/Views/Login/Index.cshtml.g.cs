#pragma checksum "C:\Users\ASUS\Desktop\ASP\FrontToBack\FrontToBack\FrontToBack\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6da507f421adf7f5baa983962aefc9c3848f4ebb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da507f421adf7f5baa983962aefc9c3848f4ebb", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\ASP\FrontToBack\FrontToBack\FrontToBack\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>

    <section id=""login-page"">
        <div class=""container"">
            <ul>
                <li><span> <a href=""./index.html"" class=""home"">HOME ></a></span></li>
                <li style=""color:#d3d1d1"">
                    <span>
                        <a style=""color:#d3d1d1""
                           href=""#"" disabled>MY ACCOUNT</a>
                    </span>
                </li>
            </ul>
            <div class=""input-box"">
                <div class=""row"">
                    <div class=""col-xl-6  col-sm-12"">
                        <div class=""login"">
                            <div class=""txt"">
                                <h6>LOGIN</h6>
                            </div>
                            <span>Username or email address *</span>
                            <div class=""input-group mt-2"">
                                <input style=""outline: none;"" type=""email"" class=""form"">
                            </div><br>
                          ");
            WriteLiteral(@"  <span>Password *</span>
                            <div class=""input-group mt-3"">
                                <input style=""outline: none;"" type=""password"" class=""form"">
                            </div><br>
                            <input style=""outline: none;"" type=""checkbox"" name=""remember"">
                            <label for=""remember"">Remember me</label><br>
                            <button class=""btn mt-3"">Log in</button><br><br>
                            <a href=""#"" class="" mb-5"">Lost your password?</a>
                        </div>
                    </div>
                    <div class=""col-xl-6 col-sm-12"">
                        <div class=""register"">
                            <div class=""txt"">
                                <h6>REGISTER</h6>
                            </div>
                            <span>Email address *</span>
                            <div class=""input-group mt-2"">
                                <input style=""outline: none;"" type");
            WriteLiteral(@"=""email"" class=""form"">
                            </div><br>
                            <span>Password *</span>
                            <div class=""input-group mt-3"">
                                <input style=""outline: none;"" type=""password"" class=""form"">
                            </div><br>
                            <p>
                                Your personal data will be used to support your experience throughout this website,
                                to <br>
                                manage access to your account, and for other purposes described in our <a href=""#"">privacy policy</a>.
                            </p>
                            <button class=""btn mt-3"">Register</button><br>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    </section>
</main>

");
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

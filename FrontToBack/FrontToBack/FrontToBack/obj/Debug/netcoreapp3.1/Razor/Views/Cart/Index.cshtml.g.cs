#pragma checksum "C:\Users\ASUS\Desktop\ASP\FrontToBack\FrontToBack\FrontToBack\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5dc1e33610d3a698401fecc083af0030c68ae9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5dc1e33610d3a698401fecc083af0030c68ae9a", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\ASP\FrontToBack\FrontToBack\FrontToBack\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""cart"">
        <div class=""container"">
            <ul>
                <li><span> <a href=""./index.html"" class=""home"">HOME ></a></span></li>
                <li style=""color:#d3d1d1"">
                    <span>
                        <a style=""color:#d3d1d1""
                           href=""#"" disabled>CART</a>
                    </span>
                </li>
            </ul>
            <div class=""card"">
                <div class=""row"">
                    <div class=""col-md-8 cart"">
                        <div class=""title"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h4><b>Shopping Cart</b></h4>
                                </div>
                                <div class=""col align-self-center text-right text-muted"">3 items</div>
                            </div>
                        </div>
                        <div class=""row border-top border-bottom""");
            WriteLiteral(@">
                            <div class=""row main align-items-center"">
                                <div class=""col-2""><img class=""img-fluid"" src=""./assets/img/card1.jpg""></div>
                                <div class=""col"">
                                    <div class=""row text-muted"">Product</div>
                                    <div class=""row"">Field Roast Chao Cheese Creamy Original</div>
                                </div>
                                <div class=""col""> <a href=""#"">-</a><a href=""#"" class=""border"">1</a><a href=""#"">+</a> </div>
                                <div class=""col"">&euro; 44.00 <span class=""close"">&#10005;</span></div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""row main align-items-center"">
                                <div class=""col-2""><img class=""img-fluid"" src=""./assets/img/card2.jpg"" ""></div>
                                <div class=""");
            WriteLiteral(@"col"">
                                    <div class=""row text-muted"">Product</div>
                                    <div class=""row"">Angie's Boomchickapop Sweet & Salty Kettle Corn</div>
                                </div>
                                <div class=""col""> <a href=""#"">-</a><a href=""#"" class=""border"">1</a><a href=""#"">+</a> </div>
                                <div class=""col"">&euro; 44.00 <span class=""close"">&#10005;</span></div>
                            </div>
                        </div>
                        <div class=""row border-top border-bottom"">
                            <div class=""row main align-items-center"">
                                <div class=""col-2""><img class=""img-fluid"" src=""./assets/img/card3.jpg"" ""></div>
                                <div class=""col"">
                                    <div class=""row text-muted"">Product</div>
                                    <div class=""row"">Field Roast Chao Cheese Creamy Original</div>
          ");
            WriteLiteral(@"                      </div>
                                <div class=""col""> <a href=""#"">-</a><a href=""#"" class=""border"">1</a><a href=""#"">+</a> </div>
                                <div class=""col"">&euro; 44.00 <span class=""close"">&#10005;</span></div>
                            </div>
                        </div>
                        <div class=""back-to-shop""><a href=""./index.html"">&leftarrow;</a><span class=""text-muted"">Back to shop</span></div>
                    </div>
                    <div class=""col-md-4 summary"">
                        <div>
                            <h5><b>Summary</b></h5>
                        </div>
                        <hr>
                        <div class=""row"">
                            <div class=""col"" style=""padding-left:0;"">ITEMS 3</div>
                            <div class=""col text-right"">&euro; 132.00</div>
                        </div>
                        <form>
                            <p>SHIPPING</p> <select>
        ");
            WriteLiteral(@"                        <option class=""text-muted"">Standard-Delivery- &euro;5.00</option>
                            </select>
                            <p>GIVE CODE</p> <input id=""code"" placeholder=""Enter your code"">
                        </form>
                        <div class=""row"" style=""border-top: 1px solid rgba(0,0,0,.1); padding: 2vh 0;"">
                            <div class=""col"">TOTAL PRICE</div>
                            <div class=""col text-right"">&euro; 137.00</div>
                        </div> <button class=""btn"">CHECKOUT</button>
                    </div>
                </div>
            </div>
        </div>
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

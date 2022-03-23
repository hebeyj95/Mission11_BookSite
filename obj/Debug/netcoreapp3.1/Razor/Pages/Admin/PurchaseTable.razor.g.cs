#pragma checksum "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "742e09f37d341b7b4b76adc67b83e73f7a0cac3f"
// <auto-generated/>
#pragma warning disable 1591
namespace BookSite2._0.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\_Imports.razor"
using BookSite2._0.Models;

#line default
#line hidden
#nullable disable
    public partial class PurchaseTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddAttribute(4, "class", "thead-dark");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "th");
            __builder.AddAttribute(9, "colspan", "5");
            __builder.AddAttribute(10, "class", "text-center");
            __builder.AddContent(11, 
#nullable restore
#line 4 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
                                                 TableTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 8 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
         if (Purchases?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
             foreach (Purchase p in Purchases)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 13 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
                         p.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 14 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
                         p.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.AddMarkupContent(26, "<th>Book</th>\r\n                    ");
            __builder.AddMarkupContent(27, "<th>Quantity</th>\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-small btn-danger");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
                                                                             x =>PurchaseSelected.InvokeAsync(p.PurchaseId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.AddContent(34, 
#nullable restore
#line 19 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
                             ButtonLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 23 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
                 foreach (BasketLineItem bli in p.Lines)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                    ");
            __builder.OpenElement(40, "tr");
            __builder.AddMarkupContent(41, "\r\n                        <td colspan=\"2\"></td>\r\n                        ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 27 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
                             bli.Book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 28 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
                             bli.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 30 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "            ");
            __builder.AddMarkupContent(50, "<tr>\r\n                <td colspan=\"5\">There are no orders.</td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\PurchaseTable.razor"
       

    [Parameter]
    public string TableTitle { get; set; } = "Purchases";

    [Parameter]
    public IEnumerable<Purchase> Purchases { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Shipped";

    [Parameter]
    public EventCallback<int> PurchaseSelected { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

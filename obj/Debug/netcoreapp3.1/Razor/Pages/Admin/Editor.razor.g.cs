#pragma checksum "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cf726283949925c8a6f95cb15e280722600629c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/create")]
    public partial class Editor : OwningComponentBase<IBookSiteRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    div.validation-message {\r\n        color: rgb(220,53,69);\r\n        font-weight: 500;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "bg-" + (
#nullable restore
#line 13 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
               ThemeColor

#line default
#line hidden
#nullable disable
            ) + " text-white" + " text-center" + " p-1");
            __builder.AddContent(3, 
#nullable restore
#line 13 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                                       TitleText

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " a Book");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                 b

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                   SaveBook

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.AddMarkupContent(16, "<label>Book Id:</label>\r\n        ");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "disabled", true);
                __builder2.AddAttribute(20, "value", 
#nullable restore
#line 19 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                                     b.BookId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.AddMarkupContent(26, "<label>Title:</label>\r\n        ");
                __Blazor.BookSite2._0.Pages.Admin.Editor.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 23 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                  () => b.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                                     b.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Title = __value, b.Title))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.AddMarkupContent(40, "<label>Author:</label>\r\n        ");
                __Blazor.BookSite2._0.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 28 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                  () => b.Author

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                                     b.Author

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Author = __value, b.Author))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Author));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n\r\n    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.AddMarkupContent(54, "<label>Publisher:</label>\r\n        ");
                __Blazor.BookSite2._0.Pages.Admin.Editor.TypeInference.CreateValidationMessage_2(__builder2, 55, 56, 
#nullable restore
#line 34 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                  () => b.Publisher

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                                     b.Publisher

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Publisher = __value, b.Publisher))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Publisher));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.AddMarkupContent(68, "<label>ISBN:</label>\r\n        ");
                __Blazor.BookSite2._0.Pages.Admin.Editor.TypeInference.CreateValidationMessage_3(__builder2, 69, 70, 
#nullable restore
#line 39 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                  () => b.Isbn

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                                     b.Isbn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Isbn = __value, b.Isbn))));
                __builder2.AddAttribute(76, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Isbn));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n    ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group");
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.AddMarkupContent(82, "<label>Classification:</label>\r\n        ");
                __Blazor.BookSite2._0.Pages.Admin.Editor.TypeInference.CreateValidationMessage_4(__builder2, 83, 84, 
#nullable restore
#line 44 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                  () => b.Classification

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(86);
                __builder2.AddAttribute(87, "class", "form-control");
                __builder2.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                                     b.Classification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Classification = __value, b.Classification))));
                __builder2.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Classification));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n    ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group");
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.AddMarkupContent(96, "<label>Category:</label>\r\n        ");
                __Blazor.BookSite2._0.Pages.Admin.Editor.TypeInference.CreateValidationMessage_5(__builder2, 97, 98, 
#nullable restore
#line 49 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                  () => b.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(99, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(100);
                __builder2.AddAttribute(101, "class", "form-control");
                __builder2.AddAttribute(102, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                                     b.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Category = __value, b.Category))));
                __builder2.AddAttribute(104, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n    ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "form-group");
                __builder2.AddMarkupContent(109, "\r\n        ");
                __builder2.AddMarkupContent(110, "<label># of Pages:</label>\r\n        ");
                __Blazor.BookSite2._0.Pages.Admin.Editor.TypeInference.CreateValidationMessage_6(__builder2, 111, 112, 
#nullable restore
#line 54 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                  () => b.PageCount

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(113, "\r\n        ");
                __Blazor.BookSite2._0.Pages.Admin.Editor.TypeInference.CreateInputNumber_7(__builder2, 114, 115, "form-control", 116, 
#nullable restore
#line 55 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                                       b.PageCount

#line default
#line hidden
#nullable disable
                , 117, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.PageCount = __value, b.PageCount)), 118, () => b.PageCount);
                __builder2.AddMarkupContent(119, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n    ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "form-group");
                __builder2.AddMarkupContent(123, "\r\n        ");
                __builder2.AddMarkupContent(124, "<label>Price:</label>\r\n        ");
                __Blazor.BookSite2._0.Pages.Admin.Editor.TypeInference.CreateValidationMessage_8(__builder2, 125, 126, 
#nullable restore
#line 59 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                  () => b.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(127, "\r\n        ");
                __Blazor.BookSite2._0.Pages.Admin.Editor.TypeInference.CreateInputNumber_9(__builder2, 128, 129, "form-control", 130, 
#nullable restore
#line 60 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                                       b.Price

#line default
#line hidden
#nullable disable
                , 131, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Price = __value, b.Price)), 132, () => b.Price);
                __builder2.AddMarkupContent(133, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n    ");
                __builder2.OpenElement(135, "button");
                __builder2.AddAttribute(136, "type", "submit");
                __builder2.AddAttribute(137, "class", "btn" + " btn-" + (
#nullable restore
#line 62 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
                                          ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(138, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(140);
                __builder2.AddAttribute(141, "class", "btn btn-secondary");
                __builder2.AddAttribute(142, "href", "/admin/books");
                __builder2.AddAttribute(143, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(144, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(145, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Editor.razor"
       

    public IBookSiteRepository repo => Service;

    [Parameter]
    public long Id { get; set; } = 0;

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

    public Book b { get; set; } = new Book();
    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            b = repo.Books.FirstOrDefault(x => x.BookId == Id);
        }
    }
    public void SaveBook()
    {
        if (Id == 0)
        {
            repo.CreateBook(b);

        }
        else
        {
            repo.SaveBook(b);
        }
        NavManager.NavigateTo("/admin/books");
    }
    [Inject]
    public NavigationManager NavManager { get; set; }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BookSite2._0.Pages.Admin.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

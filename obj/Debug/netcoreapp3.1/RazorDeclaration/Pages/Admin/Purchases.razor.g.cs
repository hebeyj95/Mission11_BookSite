// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/purchases")]
    public partial class Purchases : OwningComponentBase<IPurchaseRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Heber\Source\Repos\Mission11_BookSite\Pages\Admin\Purchases.razor"
       

    public IPurchaseRepository repo => Service;

    public IEnumerable<Purchase> AllPurchases { get; set; }
    public IEnumerable<Purchase> NotShippedPurchases { get; set; }
    public IEnumerable<Purchase> ShippedPurchases { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllPurchases = await repo.Purchases.ToListAsync();
        NotShippedPurchases = AllPurchases.Where(x => !x.PurchaseShipped);
        ShippedPurchases = AllPurchases.Where(x => x.PurchaseShipped);
    }

    public void ShipPurchase(int id) => UpdatePurchase(id, true);
    public void ResetPurchase(int id) => UpdatePurchase(id, false);

    private void UpdatePurchase(int id, bool shipped)
    {
        Purchase p = repo.Purchases.FirstOrDefault(x => x.PurchaseId == id);
        p.PurchaseShipped = shipped;
        repo.savePurchase(p);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

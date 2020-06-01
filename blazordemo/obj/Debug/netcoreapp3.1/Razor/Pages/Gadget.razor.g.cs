#pragma checksum "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76d14fa572f9aa8ef9799819709ffe9f398083e4"
// <auto-generated/>
#pragma warning disable 1591
namespace blazordemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/_Imports.razor"
using blazordemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/_Imports.razor"
using blazordemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
using blazordemo.Logics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/gadget")]
    public partial class Gadget : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n  ");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.AddMarkupContent(4, "\n    ");
            __builder.AddMarkupContent(5, "<thead>\n      <tr>\n        <th>Product Name</th>\n        <th>Brand Name</th>\n        <th>Cost(Rupees)</th>\n        <th>Type</th>\n        <th>Created Date</th>\n        <th>Modified Date</th>\n        <th>Actions</th>\n      </tr>\n    </thead>\n    ");
            __builder.OpenElement(6, "tbody");
            __builder.AddMarkupContent(7, "\n");
#nullable restore
#line 21 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
       foreach(blazordemo.Data.Gadget item in AllGadgets)
      {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "          ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\n            ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 24 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                 item.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 25 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                 item.Brand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 26 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                 item.Cost

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 27 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                 item.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 28 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                 item.CreatedDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n            ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 29 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                 item.ModifiedDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                                                          e =>  OpenModal("gadgetModal",item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, " \n            | ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                                                        e => OpenDeleteModal("deleteConfirmation", item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
#nullable restore
#line 34 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n\n");
            __builder.OpenElement(48, "div");
            __builder.AddMarkupContent(49, "\n  ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                                            e => OpenModal("gadgetModal",0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Add Gadget");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n\n");
            __builder.OpenElement(57, "div");
            __builder.AddMarkupContent(58, "\n  ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "modal fade");
            __builder.AddAttribute(61, "id", "gadgetModal");
            __builder.AddAttribute(62, "data-backdrop", "static");
            __builder.AddAttribute(63, "tabindex", "-1");
            __builder.AddAttribute(64, "role", "dialog");
            __builder.AddAttribute(65, "aria-labelledby", "staticBackdropLabel");
            __builder.AddAttribute(66, "aria-hidden", "true");
            __builder.AddMarkupContent(67, "\n  ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "modal-dialog");
            __builder.AddAttribute(70, "role", "document");
            __builder.AddMarkupContent(71, "\n    ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "modal-content");
            __builder.AddMarkupContent(74, "\n      ");
            __builder.AddMarkupContent(75, @"<div class=""modal-header"">
        <h5 class=""modal-title"" id=""staticBackdropLabel"">Modal title</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">×</span>
        </button>
      </div>
      ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "modal-body");
            __builder.AddMarkupContent(78, "\n        ");
            __builder.OpenElement(79, "form");
            __builder.AddMarkupContent(80, "\n            ");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "type", "hidden");
            __builder.AddAttribute(83, "id", "gadgetId");
            __builder.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                        Model.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Id = __value, Model.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n            ");
            __builder.OpenElement(87, "input");
            __builder.AddAttribute(88, "type", "hidden");
            __builder.AddAttribute(89, "id", "createdDate");
            __builder.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                        Model.CreatedDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.CreatedDate = __value, Model.CreatedDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\n            ");
            __builder.OpenElement(93, "input");
            __builder.AddAttribute(94, "type", "hidden");
            __builder.AddAttribute(95, "id", "modifiedDate");
            __builder.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                        Model.ModifiedDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.ModifiedDate = __value, Model.ModifiedDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n          ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "form-group");
            __builder.AddMarkupContent(101, "\n            ");
            __builder.AddMarkupContent(102, "<label for=\"txtProdcutName\">Name</label>\n            ");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "type", "text");
            __builder.AddAttribute(105, "class", "form-control");
            __builder.AddAttribute(106, "id", "txtProductName");
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                                                               Model.ProductName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.ProductName = __value, Model.ProductName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\n          ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "form-group");
            __builder.AddMarkupContent(113, "\n            ");
            __builder.AddMarkupContent(114, "<label for=\"txtBrand\">Brand Name</label>\n            ");
            __builder.OpenElement(115, "input");
            __builder.AddAttribute(116, "type", "text");
            __builder.AddAttribute(117, "class", "form-control");
            __builder.AddAttribute(118, "id", "txtBrand");
            __builder.AddAttribute(119, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                                                         Model.Brand

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Brand = __value, Model.Brand));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\n          ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "form-group");
            __builder.AddMarkupContent(125, "\n            ");
            __builder.AddMarkupContent(126, "<label for=\"txtCost\">Cost</label>\n            ");
            __builder.OpenElement(127, "input");
            __builder.AddAttribute(128, "type", "text");
            __builder.AddAttribute(129, "class", "form-control");
            __builder.AddAttribute(130, "id", "txtCost");
            __builder.AddAttribute(131, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                                                        Model.Cost

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Cost = __value, Model.Cost));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\n          ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "form-group");
            __builder.AddMarkupContent(137, "\n            ");
            __builder.AddMarkupContent(138, "<label for=\"ddlType\">Gadget Type</label>\n            ");
            __builder.OpenElement(139, "select");
            __builder.AddAttribute(140, "class", "form-control");
            __builder.AddAttribute(141, "id", "ddlType");
            __builder.AddAttribute(142, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                                             Model.Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(143, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Type = __value, Model.Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(144, "\n              ");
            __builder.OpenElement(145, "option");
            __builder.AddAttribute(146, "value", "mobile");
            __builder.AddContent(147, "Mobile");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\n              ");
            __builder.OpenElement(149, "option");
            __builder.AddAttribute(150, "value", "laptop");
            __builder.AddContent(151, "Laptop");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\n              ");
            __builder.OpenElement(153, "option");
            __builder.AddAttribute(154, "value", "Computer");
            __builder.AddContent(155, "Computer");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\n      ");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, "class", "modal-footer");
            __builder.AddMarkupContent(163, "\n        ");
            __builder.AddMarkupContent(164, "<button type=\"button\" class=\"btn btn-secondary\">Close</button>\n        ");
            __builder.OpenElement(165, "button");
            __builder.AddAttribute(166, "type", "button");
            __builder.AddAttribute(167, "class", "btn btn-primary");
            __builder.AddAttribute(168, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                                                (e => SaveGadget("gadgetModal"))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(169, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\n\n");
            __builder.OpenElement(176, "div");
            __builder.AddAttribute(177, "class", "modal fade");
            __builder.AddAttribute(178, "id", "deleteConfirmation");
            __builder.AddAttribute(179, "tabindex", "-1");
            __builder.AddAttribute(180, "role", "dialog");
            __builder.AddAttribute(181, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(182, "aria-hidden", "true");
            __builder.AddMarkupContent(183, "\n  ");
            __builder.OpenElement(184, "div");
            __builder.AddAttribute(185, "class", "modal-dialog");
            __builder.AddAttribute(186, "role", "document");
            __builder.AddMarkupContent(187, "\n    ");
            __builder.OpenElement(188, "div");
            __builder.AddAttribute(189, "class", "modal-content");
            __builder.AddMarkupContent(190, "\n      ");
            __builder.AddMarkupContent(191, @"<div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Are You Sure You Want To Remove This Item?</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">×</span>
        </button>
      </div>
      
      ");
            __builder.OpenElement(192, "div");
            __builder.AddAttribute(193, "class", "modal-footer");
            __builder.AddMarkupContent(194, "\n        ");
            __builder.AddMarkupContent(195, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\n        ");
            __builder.OpenElement(196, "button");
            __builder.AddAttribute(197, "type", "button");
            __builder.AddAttribute(198, "class", "btn btn-primary");
            __builder.AddAttribute(199, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
                                                                  e => ConfirmDelete("deleteConfirmation")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(200, "Ok");
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "/Users/sanh/Documents/GitHub/Dotnet/blazordemo/Pages/Gadget.razor"
 
    public blazordemo.Data.Gadget Model = new blazordemo.Data.Gadget();
  public IList<blazordemo.Data.Gadget> AllGadgets = 
    new List<blazordemo.Data.Gadget>();
  protected override void OnInitialized()
  {
    GetAllGadgets();
  }    
  // code hidden for display purpose
  public void GetAllGadgets()
  {
    AllGadgets = _gadgetLogic.GetAll();
  }

  public async Task OpenModal(string modalId, int itemId)
  {
    if(itemId == 0)
    {
        Model = new blazordemo.Data.Gadget();
    }
    else
    {
        Model = AllGadgets.Where(_ => _.Id == itemId).FirstOrDefault();
    }

    await _jsRuntime.InvokeVoidAsync("global.openModal", modalId);
  }

  public async Task CloseModal(string modalId)
  {
    await _jsRuntime.InvokeAsync<object>("global.closeModal", modalId);
  }

  public async Task ConfirmDelete(string modalId)
  {
    var itemTodelete = AllGadgets.Where (_=> _.Id == itemToDelete).FirstOrDefault();
    _gadgetLogic.Delete(itemTodelete);
    AllGadgets.Remove(itemTodelete);
    await _jsRuntime.InvokeAsync<object>("global.closeModal", modalId);
  }

  public async Task SaveGadget(string modalId)
  {
    if(Model.Id == 0)
    {
        // id zero represents new item
        Model.CreatedDate = DateTime.Now;
        var newGadget = _gadgetLogic.AddGadget(Model);
        AllGadgets.Add(newGadget);
    }
    else
    {
        Model.ModifiedDate = DateTime.Now;
        var gadgetToUpdate = _gadgetLogic.UpdateGadget(Model);
        AllGadgets = AllGadgets.Where(_ => _.Id != Model.Id).ToList();
        AllGadgets.Add(gadgetToUpdate);
    }

    await _jsRuntime.InvokeAsync<object>("global.closeModal", modalId);
  }

  public int itemToDelete;
  public async Task OpenDeleteModal(string modalId, int itemId)
  {
     itemToDelete = itemId;
     await _jsRuntime.InvokeVoidAsync("global.openModal", modalId);
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGadgetLogic _gadgetLogic { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
    }
}
#pragma warning restore 1591

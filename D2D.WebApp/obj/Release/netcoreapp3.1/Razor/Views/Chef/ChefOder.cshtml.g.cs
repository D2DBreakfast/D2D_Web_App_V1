#pragma checksum "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Chef\ChefOder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0bb1860b01871d906aac77ee9a8a49efe8df190"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chef_ChefOder), @"mvc.1.0.view", @"/Views/Chef/ChefOder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0bb1860b01871d906aac77ee9a8a49efe8df190", @"/Views/Chef/ChefOder.cshtml")]
    public class Views_Chef_ChefOder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<D2D.WebApp.ViewModel.NeedtocookVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Chef\ChefOder.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    .switch {
        position: relative;
        display: inline-block;
        width: 30%;
        height: 34px;
    }

        .switch input {
            display: none;
        }

    .slider {
        position: absolute;
        cursor: pointer;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background-color: #ca2222;
        -webkit-transition: .4s;
        transition: .4s;
    }

        .slider:before {
            position: absolute;
            content: """";
            height: 26px;
            width: 26px;
            left: 4px;
            bottom: 4px;
            background-color: white;
            -webkit-transition: .4s;
            transition: .4s;
        }

    input:checked + .slider {
        background-color: #2ab934;
    }

    input:focus + .slider {
        box-shadow: 0 0 1px #2196F3;
    }

    input:checked + .slider:before {
        -webkit-transform: translateX(315px);
        -ms-transform: ");
            WriteLiteral(@"translateX(315px);
        transform: translateX(315px);
    }

    /*------ ADDED CSS ---------*/
    .on {
        display: none;
    }

    .on, .off {
        color: white;
        position: absolute;
        transform: translate(-50%,-50%);
        top: 50%;
        left: 50%;
        font-size: 15px;
        font-family: Verdana, sans-serif;
    }

    input:checked + .slider .on {
        display: block;
    }

    input:checked + .slider .off {
        display: none;
    }

    /*--------- END --------*/

    /* Rounded sliders */
    .slider.round {
        border-radius: 34px;
    }

        .slider.round:before {
            border-radius: 50%;
        }
</style>

<div class=""ms-content-wrapper"">
    <div class=""row"">
        <div class=""col-md-12"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb pl-0"">
                    <li class=""breadcrumb-item""><a href=""#""><i class=""material-icons"">home</i> Home</a></li>
            ");
            WriteLiteral(@"        <li class=""breadcrumb-item active"" aria-current=""page"">Need To Cook</li>
                </ol>
            </nav>
        </div>

        <div class=""col-xl-12 col-md-12"">
            <div class=""ms-panel ms-panel-fh"">
                <div class=""ms-panel-header"">
                    <h6>Need to Cook Items List</h6>
                </div>
                <div class=""ms-panel-body clearfix"">
                    <ul class=""nav nav-tabs d-flex nav-justified mb-4"" role=""tablist"">
                        <li role=""presentation""><a href=""#tab13"" aria-controls=""tab13"" class=""active"" role=""tab"" data-toggle=""tab"">Alacarte Orders</a></li>
                        <li role=""presentation""><a href=""#tab14"" aria-controls=""tab14"" role=""tab"" data-toggle=""tab"">Subcription Orders </a></li>

                    </ul>
                    <div class=""tab-content"">
                        <div role=""tabpanel"" class=""tab-pane active show fade in"" id=""tab13"">
                            <div class=""table-res");
            WriteLiteral(@"ponsive"">
                                <table id=""needtocook"" class=""table table-hover thead-primary"">
                                    <thead>
                                        <tr>
                                            <th scope=""col"">Item ID</th>
                                            <th scope=""col"">Item Name</th>
                                            <th scope=""col"">Total Quantity</th>
                                            <th scope=""col"">Status</th>
                                            <th scope=""col"">Action</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    </tbody>
                                </table>
                            </div>
                            <div class=""row"">
                                <div class=""col-xl-12 col-md-12"">
                                    <div class=""ms-panel ms-panel-fh"">
");
            WriteLiteral(@"                                        <div class=""ms-panel-body clearfix"">
                                            <div class=""tab-content"">
                                                <div class=""table-responsive"">
                                                    <table id=""addOnslist"" class=""table table-hover thead-primary"">
                                                        <thead>
                                                            <tr>
                                                                <th scope=""col"">Addon Name</th>
                                                                <th scope=""col"">Total Quantity</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                        </tbody>
                                                    </table>
                       ");
            WriteLiteral(@"                         </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div role=""tabpanel"" class=""tab-pane fade"" id=""tab14"">
                            <div class=""table-responsive"">
                                <table id=""needtocooksub"" class=""table table-hover thead-primary"">
                                    <thead>
                                        <tr>

                                            <th scope=""col"">Subscription Type</th>
                                            <th scope=""col"">Item Name </th>
                                            <th scope=""col"">Total Quantity </th>
                                            <th scope=""col"" style=""display:none"">Day</th>
                                            <th scope=""col"" style=""displ");
            WriteLiteral(@"ay:none"">Subscription Id</th>
                                            <th scope=""col"">Action</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""modal fade"" id=""editfoodstatusmodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""notes-modal"">
    <div class=""modal-dialog modal-dialog-centered"" style=""max-width: 80%;"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-secondary"">
                <h5 class=""modal-title has-icon text-white"" id=""NoteModal"">Edit Food Status</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""ms-panel-body"">
                <form class=""needs-validation"" novalidate>
                    <div class=""form-row"">
                        <div class=""col-md-6 mb-3"">
                            <label for=""validationCustom01"">Item ID</label>
                            <div class=""input-group"">
                                <input type=""text"" class=""form-control readitemid"" value="" "" readonly");
            WriteLiteral(@">
                                <div class=""invalid-feedback"">
                                    Enter Name!
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6 mb-3"">
                            <label for=""validationCustom01"">Item Name</label>
                            <div class=""input-group"">
                                <input type=""text"" class=""form-control readitemname"" value="" "" readonly>
                                <div class=""invalid-feedback"">
                                    Enter Name!
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6 mb-3"">
                            <label for=""validationCustom02"">Quantity</label>
                            <div class=""input-group"">
                                <input type=""number"" class=""form-control readquantity"" value="" "" rea");
            WriteLiteral(@"donly>
                                <div class=""invalid-feedback"">
                                    Enter Number!
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""col-md-12 mb-3"">
                            <label for=""validationCustom22""><b>Change Status</b></label>
                            <div class=""input-group"">
                                <label class=""switch"">
                                    <input type=""checkbox"" id=""togBtn"">
                                    <div class=""slider round"">
                                        <!--ADDED HTML -->
                                        <span class=""off"">Received</span>
                                        <span class=""on"">Prepared</span>
                                        <!--END-->
                                    </div>
                        ");
            WriteLiteral(@"        </label>
                            </div>
                        </div>
                    </div>
                    <button class=""btn btn-primary"" id=""editstatus"" type=""submit"">Update</button>
                </form>
            </div>
        </div>
    </div>
</div>

");
            WriteLiteral(@"<div class=""modal fade"" id=""viewAddonsModel"" tabindex=""-1"" role=""dialog"" aria-labelledby=""notes-modal"">
    <div class=""modal-dialog modal-dialog-centered"" style=""max-width: 80%;"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-secondary"">
                <h5 class=""modal-title has-icon text-white"" id=""NoteModal"">Item Selections</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""ms-panel-body"">
                <div class=""table-responsive"">
                    <table id=""selections"" class=""table table-hover thead-primary"">
                        <thead>
                            <tr>
                                <th scope=""col"">Selection</th>
                                <th scope=""col"">Quantity</th>
                                <th scope=""col"">Type</th>
         ");
            WriteLiteral(@"                       

                            </tr>
                        </thead>
                        <tbody>
                        </tbody>
                    </table>
                </div>

            </div>
        </div>
    </div>
</div>

");
            WriteLiteral(@"<div class=""modal fade"" id=""editfoodsubscriptionstatusmodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""notes-modal"">
    <div class=""modal-dialog modal-dialog-centered"" style=""max-width: 80%;"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-secondary"">
                <h5 class=""modal-title has-icon text-white"" id=""NoteModal"">Edit Subscription Food Status</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""ms-panel-body"">
                <form class=""needs-validation"" novalidate>
                    <div class=""form-row"">
                        <div class=""col-md-4 mb-3"">
                            <label for=""validationCustom01"">Subscription Name</label>
                            <div class=""input-group"">
                                <input type=""text"" class=""form-con");
            WriteLiteral(@"trol readitemname"" value="" "" readonly>
                                <div class=""invalid-feedback"">
                                    Enter Name!
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4 mb-3"">
                            <label for=""validationCustom02"">Meal Name</label>
                            <div class=""input-group"">
                                <input type=""text"" class=""form-control readmeal"" value="" "" readonly>
                                <div class=""invalid-feedback"">
                                    Enter Number!
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4 mb-3"">
                            <label for=""validationCustom02"">Quantity</label>
                            <div class=""input-group"">
                                <input type=""number"" class=""form-");
            WriteLiteral(@"control readquantity"" value="" "" readonly>
                                <div class=""invalid-feedback"">
                                    Enter Number!
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4 mb-3"" style=""display:none"">
                            <label for=""validationCustom02"">Day</label>
                            <div class=""input-group"">
                                <input type=""text"" class=""form-control readsubday"" value="" "" readonly>
                                <div class=""invalid-feedback"">
                                    Enter Number!
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4 mb-3"" style=""display:none"">
                            <label for=""validationCustom02"">Subscription ID</label>
                            <div class=""input-group"">
               ");
            WriteLiteral(@"                 <input type=""number"" class=""form-control readsubid"" value="" "" readonly>
                                <div class=""invalid-feedback"">
                                    Enter Number!
                                </div>
                            </div>
                        </div>
                    </div>
");
            WriteLiteral(@"                    <div class=""form-row"">
                        <div class=""col-md-12 mb-3"">
                            <label for=""validationCustom22""><b>Change Status</b></label>
                            <div class=""input-group"">
                                <label class=""switch"">
                                    <input type=""checkbox"" id=""togBtnSub"">
                                    <div class=""slider round"">
                                        <!--ADDED HTML -->
                                        <span class=""off"">Received</span>
                                        <span class=""on"">Prepared</span>
                                        <!--END-->
                                    </div>
                                </label>
                            </div>
                        </div>
                    </div>
                    <button class=""btn btn-primary"" id=""editstatussubscription"" type=""submit"">Update</button>
                </form>

    ");
            WriteLiteral("        </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0bb1860b01871d906aac77ee9a8a49efe8df19020364", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0bb1860b01871d906aac77ee9a8a49efe8df19021404", async() => {
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
            WriteLiteral(@"

<script>
    //Modal Script
    $(""#editfoodstatus"").click(function () {
        debugger;
        $('#editfoodstatusmodal').modal('show');
    })

    $(""#editsubsstatus"").click(function () {
        debugger;
        $('#editfoodsubscriptionstatusmodal').modal('show');
    })

    // Need to cook for Alacarte
    $(document).ready(function () {
        var APIString = '");
#nullable restore
#line 431 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Chef\ChefOder.cshtml"
                    Write(Model.Connectionstringneedtocook);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        debugger;
        $.ajax({
            type: ""GET"",
            contentType: ""application/json"",
            url: APIString,
            data: ""{}"",
            dataType: ""json"",
            success: function (needtocook, status) {
                console.log(""needtocookkkkkkkkk"", needtocook)
                debugger;
                var data = needtocook.orders;
                if (data) {
                    data.forEach(function (dt) {

                        var itemName = """";
                        var itemBaseQuantity = """";
                        var itemStatus = """";
                        var itemId = """";
                        itemName = itemName + dt.itemName;

                            $(""#needtocook"").append(""<tr>"" +
                                ""<td>"" + dt.itemId + ""</td>"" +
                                ""<td>"" + itemName + ""</td>"" +
                                ""<td >"" + dt.itemBaseQuantity + ""</td>"" +
                                ""<td style =");
            WriteLiteral(@"'color: green;  font-size: 18px;  font-weight: bold;'>"" +dt.itemStatus + ""</td>"" +
                                ""<td>"" + `<a id=""editfoodstatus"" 'data-bs-toggle=""tooltip"" data-bs-placement=""top""  title = ""Edit!""' onclick= $('#editfoodstatusmodal').modal('show')><i class='fas fa-pencil-alt text-secondary'></i></a>
                                             <a id = ""viewbutton""  'data-bs-toggle=""tooltip"" data-bs-placement=""top""  title = ""View!""' onclick= $('#viewAddonsModel').modal('show')><i class=""fa fa-eye  text-secondary text-success""></i></a>` + ""</td>"")

                    })
                }
            },
            error: function (Result) {
                alert(""Error or Error"");
            }
        });
    });



    //From View to Send Item Id
    $(document).on('click', ""#viewbutton"", this.onclick = null, function (e) {
        e.preventDefault();
        var currentRow = $(this).closest(""tr"");
        var itemId = currentRow.find(""td:eq(0)"").text();
         var APIS");
            WriteLiteral("tring = \'");
#nullable restore
#line 476 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Chef\ChefOder.cshtml"
                     Write(Model.Connectionstringneedtocookaddonselection);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
           $.ajax({
            type: 'POST',
            url: APIString,
            data: JSON.stringify({
                itemId: itemId
            }),
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                debugger;
              /*  SelectionCount = [];*/
                if (data.status) {
                   var SelectionCount = [];
                       // SelectionCount.length = 0
                    /*toastr.success(data.message);*/
                     SelectionCount = data.SelectionCount;

                    SelectionCount.forEach(function (dt) {
                        $(""#selections"").append(""<tr>"" +
                            ""<td>"" + dt.addOnName + ""</td>"" +
                            ""<td>"" + dt.addOnBaseQuantity + ""</td>"" +
                            ""<td >"" + dt.type + ""</td>"" )
                    });
");
            WriteLiteral("\r\n                    $(\'#viewAddonsModel\').on(\'hidden.bs.modal\', function () {\r\n                       window.location.href = \'");
#nullable restore
#line 505 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Chef\ChefOder.cshtml"
                                          Write(Url.Action("ChefOder", "Chef"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                    });

                } else {
                    toastr.error(data.message);
                }

            },
            error: function (ajaxContext) {

                alert("" its Fail"");
            }
        });
    });



    //to send alacarte status change
    $(document).on(""click"", ""#editfoodstatus"", function (e) {
        debugger;
        var id = $(this).closest('tr').attr('id');
        var currentRow = $(this).closest(""tr"");
        var itemId = currentRow.find(""td:eq(0)"").text(); // get current row 1st TD value
        var itemName = currentRow.find(""td:eq(1)"").text(); // get current row 1st TD value
        var quantity = currentRow.find(""td:eq(2)"").text(); // get current row 2nd TD

        $(""#editfoodstatusmodal .modal-content .readitemid"").val(itemId);
        $(""#editfoodstatusmodal .modal-content .readitemname"").val(itemName);
        $(""#editfoodstatusmodal .modal-content .readquantity"").val(quantity);

    });

    //Alacarte Fo");
            WriteLiteral(@"od Status change
    $('#editstatus').on('click', function (e) {
        e.preventDefault();
        debugger;
        var itemID = $(""#editfoodstatusmodal .modal-content .readitemid"").val();
        var foodstatus = $('#editfoodstatusmodal form #togBtn').is(':checked') ? ""Prepared"" : """";
        var APIString = '");
#nullable restore
#line 543 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Chef\ChefOder.cshtml"
                    Write(Model.Connectionstringitemstatuschange);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $.ajax({

            type: 'POST',
            url: APIString,
            data: JSON.stringify({
                itemId: itemID,
                itemStatus: foodstatus.trim()
            }),
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                debugger;
                if (data.status) {
                    toastr.success(data.message);
                     window.setTimeout(function () {
                            window.location.href='");
#nullable restore
#line 559 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Chef\ChefOder.cshtml"
                                             Write(Url.Action("ChefOder", "Chef"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                        }, 1000);

                } else {
                    toastr.error(data.message);
                }

            },
            error: function (ajaxContext) {

                alert("" its Fail"");
            }
        });
    });

     // Need to cook for subscription
    $(document).ready(function () {
        var APIString = '");
#nullable restore
#line 576 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Chef\ChefOder.cshtml"
                    Write(Model.Connectionstringneedtocooksubscription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        debugger;
        $.ajax({
            type: ""POST"",
            contentType: ""application/json"",
            url: APIString,
            data: ""{}"",
            dataType: ""json"",
            success: function (needtocooksub, status) {
                console.log(""needtocooksubscription"", needtocooksub)
                debugger;
                 let data = needtocooksub.NeedToCookSubscription;
                data.forEach(function (dt) {
                    if (dt.totalQuantity) {
                        $(""#needtocooksub"").append(""<tr>"" +
                            ""<td>"" + dt.subscriptionTitle + ""</td>"" +
                            ""<td>"" + dt.meal + ""</td>"" +
                            ""<td>"" + dt.totalQuantity + ""</td>"" +
                            ""<td style='display: none'>"" + dt.day + ""</td>"" +
                            ""<td style='display: none'>"" + dt.subscriptionId + ""</td>"" +
                            ""<td>"" + `<a id=""editfoodstatussub"" 'data-bs-toggle=""toolti");
            WriteLiteral(@"p"" data-bs-placement=""top""  title = ""Edit!""' onclick= $('#editfoodsubscriptionstatusmodal').modal('show')><i class='fas fa-pencil-alt text-secondary'></i></a>` + ""</td>"")
                            }            
                    })

            },
            error: function (Result) {
                alert(""Error Api Subscription"");
            }
        });
    });

    //to send subscription status change
    $(document).on(""click"", ""#editfoodstatussub"", function (e) {
        debugger;
        var id = $(this).closest('tr').attr('id');
        var currentRow = $(this).closest(""tr"");
        var itemName = currentRow.find(""td:eq(0)"").text(); // get current row 1st TD value
        var meal = currentRow.find(""td:eq(1)"").text();
        var quantity = currentRow.find(""td:eq(2)"").text();
        var day = currentRow.find(""td:eq(3)"").text();
        var subscriptionId = currentRow.find(""td:eq(4)"").text();

        $(""#editfoodsubscriptionstatusmodal .modal-content .readitemname"").val(");
            WriteLiteral(@"itemName);
        $(""#editfoodsubscriptionstatusmodal .modal-content .readmeal"").val(meal);
        $(""#editfoodsubscriptionstatusmodal .modal-content .readquantity"").val(quantity);
        $(""#editfoodsubscriptionstatusmodal .modal-content .readsubday"").val(day);
        $(""#editfoodsubscriptionstatusmodal .modal-content .readsubid"").val(subscriptionId);
    });

    //Subscription Food Status change
    $('#editstatussubscription').on('click', function (e) {
        e.preventDefault();
        debugger;
         var subscriptionName = $(""#editfoodsubscriptionstatusmodal .modal-content .readitemname"").val();
         var mealName = $(""#editfoodsubscriptionstatusmodal .modal-content .readmeal"").val();
         var quantity = $(""#editfoodsubscriptionstatusmodal .modal-content .readquantity"").val();
          var day = $(""#editfoodsubscriptionstatusmodal .modal-content .readsubday"").val();
         var subscriptionid = $(""#editfoodsubscriptionstatusmodal .modal-content .readsubid"").val();
     ");
            WriteLiteral("   var foodstatus = $(\"#editfoodsubscriptionstatusmodal  form #togBtnSub\").is(\':checked\') ? \"Prepared\" : \"\";\r\n\r\n        var APIString = \'");
#nullable restore
#line 636 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Chef\ChefOder.cshtml"
                    Write(Model.Connectionstringsubscriptionitemstatuschange);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $.ajax({

            type: 'POST',
            url: APIString,
            data: JSON.stringify({
                subscriptionId: subscriptionid,
                subscriptionTitle: subscriptionName,
                day: day,
                 meal: mealName,
                totalQuantity: quantity,
                itemStatus: foodstatus.trim()
            }),
            dataType: 'json',
            contentType: 'application/json',
             success: function (data) {
                debugger;
                if (data.status) {
                    toastr.success(data.message);
                     window.setTimeout(function () {
                            window.location.href='");
#nullable restore
#line 656 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Chef\ChefOder.cshtml"
                                             Write(Url.Action("ChefOder", "Chef"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                        }, 1000);

                } else {
                    toastr.error(data.message);
                }

            },
            error: function (ajaxContext) {

                alert("" its Fail"");
            }
        });
    });
    //toggle Switch
    var switchStatus = false;
    $(""#togBtn"").on('change', function () {
        if ($(this).is(':checked')) {
            switchStatus = $(this).is(':checked');
            alert(""Are you Sure Food Got Prepared?"");// To verify
        }
        //else {
        //    switchStatus = $(this).is(':checked');
        //    alert(switchStatus);// To verify
        //}
    });

    var switchStatus = false;
    $(""#togBtnSub"").on('change', function () {
        if ($(this).is(':checked')) {
            switchStatus = $(this).is(':checked');
            alert(""Are you sure Subscription Food Got Prepared"");// To verify
        }
        //else {
        //    switchStatus = $(this).is(':checked');
        /");
            WriteLiteral("/    alert(switchStatus);// To verify\r\n        //}\r\n    });\r\n\r\n    // Ordered AddOnlis List\r\n    $(document).ready(function () {\r\n        var APIString = \'");
#nullable restore
#line 697 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Chef\ChefOder.cshtml"
                    Write(Model.ConnectionstringneedtocookAddOnlist);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        debugger;
        $.ajax({
            type: ""GET"",
            contentType: ""application/json"",
            url: APIString,
            data: ""{}"",
            dataType: ""json"",
            success: function (res, status) {
                debugger;
                console.log(""addOns"", res);
                var data = res.AddOnCount;
                data.forEach(function (dt) {
                    console.log(dt);

                    $(""#addOnslist"").append(""<tr>"" +


                        ""<td>"" + dt.addOnName + ""</td>"" +
                        ""<td>"" + dt.addOnBaseQuantity+ ""</td>"")
                })
            },
            error: function (Result) {
                alert(""Error"");
            }
        });
    });



</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<D2D.WebApp.ViewModel.NeedtocookVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

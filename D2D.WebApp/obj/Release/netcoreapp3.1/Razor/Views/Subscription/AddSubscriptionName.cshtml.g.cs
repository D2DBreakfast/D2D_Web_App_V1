#pragma checksum "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Subscription\AddSubscriptionName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b77ce2cc50fa19d346318f5f8525ed76f04f0ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscription_AddSubscriptionName), @"mvc.1.0.view", @"/Views/Subscription/AddSubscriptionName.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b77ce2cc50fa19d346318f5f8525ed76f04f0ea", @"/Views/Subscription/AddSubscriptionName.cshtml")]
    public class Views_Subscription_AddSubscriptionName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Subscription\AddSubscriptionName.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""ms-content-wrapper"">
    <div class=""row"">
        <div class=""col-md-12"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb pl-0"">
                    <li class=""breadcrumb-item""><a href=""#""><i class=""material-icons"">home</i> Home</a></li>
                    <li class=""breadcrumb-item""><a href=""#"">Menu</a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Add Subscription Details</li>
                </ol>
            </nav>
            <div class=""col-xl-12 col-md-12"">
                <div class=""ms-panel ms-panel-fh"">
                    <div class=""ms-panel-header"">
                        <h6>Add Details</h6>
                    </div>
                    <div class=""ms-panel-body"">
                        <form class=""needs-validation clearfix"" autocomplete=""off"">
                            <div class=""form-row"">
                                <div class=""col-md-6 mb-3"">
                                    <d");
            WriteLiteral(@"iv class=""input-group"">
                                        <label for=""validationCustom22"">Main Subscription</label>
                                        <div class=""input-group"">
                                            <textarea style="" height: 38px;background: #ffffff"" id=""Note"" name=""Note"" placeholder=""Subscription"" value=""Subscription"" class=""form-control"" readonly></textarea>
                                            <div class=""invalid-feedback"">
                                                Please provide a message.
                                            </div>
                                           
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-6 mb-3"">
                                    <div class=""input-group"">
                                        <label for=""validationCustom02"">Subscription Name</label>
                     ");
            WriteLiteral(@"                   <div class=""input-group"">
                                            <input type=""text"" class=""form-control"" id=""SubSubscriptionName"" name=""SubSubscriptionName "" value="" "" required>
                                            <div class=""invalid-feedback"">
                                                Enter!
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""col-md-6 mb-3"">
                                    <label for=""validationCustom03"">Amount</label>
                                    <div class=""input-group"">
                                        <input type=""text"" class=""form-control"" id=""SubAmount"" name=""SubAmount"" value="" "" required>
                                        <div class=""invalid-feedback"">
   ");
            WriteLiteral(@"                                         Enter!
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-6 mb-3"">
                                    <label for=""validationCustom12"">Package Image</label>
                                    <div class=""custom-file"">
                                        <input type=""file"" class=""custom-file-input"" id=""validatedCustomFile"">
                                        <label class=""custom-file-label"" for=""validatedCustomFile"">Upload Image...</label>
                                        <div class=""invalid-feedback"">Example invalid custom file feedback</div>
                                    </div>
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""col-md-12 mb-3"">
                                    <label f");
            WriteLiteral(@"or=""validationCustom12"">Description</label>
                                    <div class=""input-group"">
                                        <textarea rows=""5"" id=""SubDescription"" name=""SubDescription"" class=""form-control""
                                                  placeholder=""Message""></textarea>
                                        <div class=""invalid-feedback"">
                                            Please provide a message.
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class=""col-md-12 mb-3"">
                                <button id=""AddDetails"" class=""btn btn-primary"">Add Details</button>
                            </div>

                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b77ce2cc50fa19d346318f5f8525ed76f04f0ea9002", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b77ce2cc50fa19d346318f5f8525ed76f04f0ea10041", async() => {
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
    //Create Subscription Name
    //$(document).on(""click"", ""#addSubscriptionName"", function () {
    //    debugger;
    //    var APIString = 'http://localhost:3000/manager/createSubscription';
    //    var SubscriptionNameValue = $('#SubscriptionName').val();

    //    $.ajax({
    //        type: 'POST',
    //        url: APIString,
    //        data: JSON.stringify({
    //            subscriptionName: SubscriptionNameValue
    //        }),
    //        dataType: 'json',
    //        contentType: 'application/json',
    //        success: function (data) {
    //            $('#SubscriptionName').val('');
    //            toastr.success(""SubscriptionName Saved Sucessfully"", 'Sucess');
    //        },
    //        error: function (ajaxContext) {
    //            toastr.error(""Try After Sometime"", 'Error');
    //        }
    //    });

    //})

    //Adding Subscription List
    //$(document).ready(function () {
    //    var APIString = 'http://10.12");
            WriteLiteral(@".14.56:3000/manager/fetchSubscriptions';
    //    $.ajax({
    //        type: ""GET"",
    //        contentType: ""application/json"",
    //        url: APIString,
    //        data: ""{}"",
    //        dataType: ""json"",
    //        success: function (Result) {
    //            debugger;
    //            //$.each(Result.d, function (key, value) {
    //            //    debugger;
    //            //    console.log(value)
    //            //    $(""#SelMainCat"").append($(""<option></option>"").val(value.mainCategoryId).html(value.subCategoryName));
    //            //});
    //            console.log(Result.mainCategoryData)
    //            var ele = document.getElementById('SubCatList');
    //            for (var i = 0; i < Result.mainCategoryData.length; i++) {
    //                // POPULATE SELECT ELEMENT WITH JSON.
    //                ele.innerHTML = ele.innerHTML +
    //                    '<option value=""' + Result.mainCategoryData[i]['subscriptionId'] + '"">' + Result.mai");
            WriteLiteral(@"nCategoryData[i]['subscriptionName'] + '</option>';
    //            }
    //        },
    //        error: function (Result) {
    //            alert(""Error or Error"");
    //        }
    //    });
    //});

    // Modal Event
    //$(""#addSubscription"").click(function () {
    //    debugger;
    //    $('#notesmodal').modal('show');

    //})

    //Send All Details
    $(""#AddDetails"").click(function (e) {
        e.preventDefault();
        debugger;
         var APIString = '");
#nullable restore
#line 220 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Subscription\AddSubscriptionName.cshtml"
                     Write(Model.Connectionstringcreatesubscription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        // var mainSubscription = $('#SubCatList :selected').text();
       /* var subscriptionId = $('#SubCatList').val();*/
        var subscriptioname = $('#SubSubscriptionName').val();
        var subscriptionleastamount = $('#SubAmount').val();
        var subscriptiondescription = $('#SubDescription').val();
        var subscriptionimage = ""ImageURL"";

        debugger;
        $.ajax({
            type: 'POST',
            url: APIString,
            data: JSON.stringify({
                /*subscriptionId: subscriptionId,*/
                subscriptionType: subscriptioname.trim(),
                subscriptionDescription: subscriptiondescription.trim(),
                subscriptionLeastAmount: subscriptionleastamount.trim(),
                subscriptionImage: subscriptionimage

            }),
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {

                debugger;
                if (data.status) {
        ");
            WriteLiteral(@"            toastr.success(data.message);
                } else {
                    toastr.error(data.message);
                }
            },
            //error: function (ajaxContext) {
            //    debugger;
            //    toastr.error(""Try After Sometime"", 'Error');
            //}
        });
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

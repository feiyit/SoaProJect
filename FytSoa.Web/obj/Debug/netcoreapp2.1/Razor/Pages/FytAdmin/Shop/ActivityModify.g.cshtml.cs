#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1371663093a260b6d6cf4ecf2339168f7cf31c47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_ActivityModify), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Shop/ActivityModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Shop/ActivityModify.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_ActivityModify), null)]
namespace FytSoa.Web.Pages.FytAdmin.Shop
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1371663093a260b6d6cf4ecf2339168f7cf31c47", @"/Pages/FytAdmin/Shop/ActivityModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Shop_ActivityModify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
  
    ViewData["Title"] = "活动管理";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 409, true);
            WriteLiteral(@"<style>
    .layui-form-item .layui-input-inline {
        width: 280px;
    }

    .layui-textarea {
        width: 97%;
        min-height: 60px;
    }
    .full-wall{margin:8px 0;}
    .full-wall .layui-input{width:200px; display:inline-block;}
    .full-wall .layui-form-label{float:none; display:inline-block; width:auto;}
    .full-wall .layui-form-label:first-child{width:80px;}
</style>
");
            EndContext();
            BeginContext(564, 3754, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f84420c8381747ca8718eb9f81251093", async() => {
                BeginContext(608, 248, true);
                WriteLiteral("\r\n    <div class=\"layui-form-item\">\r\n        <div class=\"layui-inline\">\r\n            <label class=\"layui-form-label\">活动类型</label>\r\n            <div class=\"layui-input-inline\">\r\n                <input type=\"radio\" name=\"Method\" value=\"1\" title=\"打折\" ");
                EndContext();
                BeginContext(858, 48, false);
#line 26 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
                                                                   Write(Model.activityModel.Method == 1 ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(907, 74, true);
                WriteLiteral(">\r\n                <input type=\"radio\" name=\"Method\" value=\"2\" title=\"满减\" ");
                EndContext();
                BeginContext(983, 48, false);
#line 27 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
                                                                   Write(Model.activityModel.Method == 2 ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1032, 230, true);
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-inline\">\r\n            <label class=\"layui-form-label\">折扣数</label>\r\n            <div class=\"layui-input-inline\">\r\n                <input type=\"number\" name=\"CountNum\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1262, "\"", 1299, 1);
#line 33 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 1270, Model.activityModel.CountNum, 1270, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1300, 330, true);
                WriteLiteral(@" placeholder=""如果折扣是8折，请输入80数字"" maxlength=""10"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item layui-hide"" id=""full"">
        <div class=""full-wall"">
            <label class=""layui-form-label"">满</label>
            <input type=""number"" name=""fullbegin[]""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1630, "\"", 1671, 1);
#line 40 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 1638, Model.shopActivity?[0].fullbegin, 1638, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1672, 162, true);
                WriteLiteral(" maxlength=\"10\" autocomplete=\"off\" class=\"layui-input\">\r\n            <label class=\"layui-form-label\">元减</label>\r\n            <input type=\"number\" name=\"fullend[]\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1834, "\"", 1873, 1);
#line 42 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 1842, Model.shopActivity?[0].fullend, 1842, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1874, 267, true);
                WriteLiteral(@" maxlength=""10"" autocomplete=""off"" class=""layui-input"">
            <label class=""layui-form-label"">元</label>
        </div>
        <div class=""full-wall"">
            <label class=""layui-form-label"">满</label>
            <input type=""number"" name=""fullbegin[]""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2141, "\"", 2182, 1);
#line 47 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 2149, Model.shopActivity?[1].fullbegin, 2149, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2183, 162, true);
                WriteLiteral(" maxlength=\"10\" autocomplete=\"off\" class=\"layui-input\">\r\n            <label class=\"layui-form-label\">元减</label>\r\n            <input type=\"number\" name=\"fullend[]\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2345, "\"", 2384, 1);
#line 49 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 2353, Model.shopActivity?[1].fullend, 2353, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2385, 267, true);
                WriteLiteral(@" maxlength=""10"" autocomplete=""off"" class=""layui-input"">
            <label class=""layui-form-label"">元</label>
        </div>
        <div class=""full-wall"">
            <label class=""layui-form-label"">满</label>
            <input type=""number"" name=""fullbegin[]""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2652, "\"", 2693, 1);
#line 54 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 2660, Model.shopActivity?[2].fullbegin, 2660, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2694, 162, true);
                WriteLiteral(" maxlength=\"10\" autocomplete=\"off\" class=\"layui-input\">\r\n            <label class=\"layui-form-label\">元减</label>\r\n            <input type=\"number\" name=\"fullend[]\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2856, "\"", 2895, 1);
#line 56 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 2864, Model.shopActivity?[2].fullend, 2864, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2896, 377, true);
                WriteLiteral(@" maxlength=""10"" autocomplete=""off"" class=""layui-input"">
            <label class=""layui-form-label"">元</label>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">开始时间</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""BeginDate"" id=""btime""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3273, "\"", 3339, 1);
#line 64 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 3281, Model.activityModel.BeginDate.ToString().Replace("/","-"), 3281, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3340, 278, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">结束时间</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""EndDate"" id=""etime""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3618, "\"", 3682, 1);
#line 70 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 3626, Model.activityModel.EndDate.ToString().Replace("/","-"), 3626, 56, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3683, 425, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
            <button type=""button"" class=""layui-btn layui-btn-primary btn-open-close"">取消</button>
        </div>
    </div>
    <input type=""hidden"" name=""Guid"" id=""Guid""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4108, "\"", 4141, 1);
#line 80 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 4116, Model.activityModel.Guid, 4116, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4142, 45, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"ShopGuid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4187, "\"", 4224, 1);
#line 81 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 4195, Model.activityModel.ShopGuid, 4195, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4225, 44, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"AddDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4269, "\"", 4305, 1);
#line 82 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
WriteAttributeValue("", 4277, Model.activityModel.AddDate, 4277, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4306, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(4318, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4337, 1140, true);
                WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['layer', 'jquery', 'laydate', 'common', 'form'], function () {
            var form = layui.form
                , $ = layui.$
                , os = layui.common
                , layer = layui.layer
                , laydate = layui.laydate;
            var index = parent.layer.getFrameIndex(window.name);
            laydate.render({
                elem: '#btime'
                , theme: '#393D49'
                , format: 'yyyy-MM-dd HH:mm:ss'
                , type: 'datetime'
            });
            laydate.render({
                elem: '#etime'
                , theme: '#393D49'
                , format: 'yyyy-MM-dd HH:mm:ss'
                , type: 'datetime'
            });
            form.on('radio', function (data) {
                console.log(data.value);
                if (data.value === '1') {
                    $(""#full"").addClass('layui-hide');
                } else");
                WriteLiteral(" {\r\n                    $(\"#full\").removeClass(\'layui-hide\');\r\n                }\r\n            }); \r\n            if (");
                EndContext();
                BeginContext(5478, 26, false);
#line 115 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityModify.cshtml"
           Write(Model.activityModel.Method);

#line default
#line hidden
                EndContext();
                BeginContext(5504, 1001, true);
                WriteLiteral(@"== 2) {
                $(""#full"").removeClass('layui-hide');
            }
            //监听提交
            form.on('submit(submit)', function (data) {
                var urls = ""api/shops/addact"";
                if ($(""#Guid"").val()) {
                    urls = ""api/shops/editact"";
                }
                //console.log(JSON.stringify(data.field)); return false;
                if (data.field.Method == 2) {
                    data.field.CountNum = 0;
                }
                os.ajax(urls, data.field, function (res) {
                    if (res.statusCode == 200) {
                        parent.layer.close(index);
                    }
                    else {
                        os.error(res.message);
                    }
                });
                return false;
            });
            $("".btn-open-close"").on('click', function () {
                parent.layer.close(index);
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(6508, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Shop.ActivityModifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.ActivityModifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.ActivityModifyModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Shop.ActivityModifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8c72d430c6d10ee3b5b5f4b095f69c17754a0d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Report.Pages_FytAdmin_Report_ShopInventory), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Report/ShopInventory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Report/ShopInventory.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Report.Pages_FytAdmin_Report_ShopInventory), null)]
namespace FytSoa.Web.Pages.FytAdmin.Report
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c72d430c6d10ee3b5b5f4b095f69c17754a0d1", @"/Pages/FytAdmin/Report/ShopInventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Report_ShopInventory : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
  
    ViewData["Title"] = "报表管理-加盟商盘点报表";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(160, 574, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""可根据条形码搜索"">
            </div>
            <div class=""layui-inline lay-time-icon"">
                <input class=""layui-input"" id=""times"" autocomplete=""off"" placeholder=""时间区间""><i class=""layui-icon layui-icon-date""></i>
            </div>
            <div class=""layui-inline"">
                <select id=""shops"" lay-search="""">
                    ");
            EndContext();
            BeginContext(734, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcd42289e31c4280be3978d02ff8786b", async() => {
                BeginContext(751, 11, true);
                WriteLiteral("--可根据店铺搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(771, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                      
                        if (Model.shopList != null)
                        {
                            foreach (var item in Model.shopList)
                            {

#line default
#line hidden
            BeginContext(974, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1006, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a53d954c54244f54bba366f77b482a1d", async() => {
                BeginContext(1034, 13, false);
#line 24 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                                                      Write(item.ShopName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 24 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1056, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                            }
                        }
                    

#line default
#line hidden
            BeginContext(1139, 158, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"layui-inline\">\r\n                <select id=\"years\" lay-search=\"\">\r\n                    ");
            EndContext();
            BeginContext(1297, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "821f8bc731b74a0ba290c68b6753e726", async() => {
                BeginContext(1314, 11, true);
                WriteLiteral("--可根据年份搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1334, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                      
                        if (Model.yearCodeList != null)
                        {
                            foreach (var item in Model.yearCodeList)
                            {

#line default
#line hidden
            BeginContext(1545, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1577, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a08a3daec924aa5b2c8b7b18bf8f6f8", async() => {
                BeginContext(1605, 9, false);
#line 38 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 38 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1623, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                            }
                        }
                    

#line default
#line hidden
            BeginContext(1706, 216, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div style=\"height:5px; width:100%;\"></div>\r\n            <div class=\"layui-inline\">\r\n                <select id=\"branks\" lay-search=\"\">\r\n                    ");
            EndContext();
            BeginContext(1922, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "761e93c92ea94a82b87617da5c713350", async() => {
                BeginContext(1939, 11, true);
                WriteLiteral("--可根据品牌搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1959, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                      
                        if (Model.codeList != null)
                        {
                            foreach (var item in Model.codeList)
                            {

#line default
#line hidden
            BeginContext(2162, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2194, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "461da5faa6dd4b69b2ba92caa3b91407", async() => {
                BeginContext(2222, 9, false);
#line 53 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 53 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2240, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                            }
                        }
                    

#line default
#line hidden
            BeginContext(2323, 160, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"layui-inline\">\r\n                <select id=\"seasons\" lay-search=\"\">\r\n                    ");
            EndContext();
            BeginContext(2483, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb1cf09adb154c01a68cbdd7edb05db1", async() => {
                BeginContext(2500, 11, true);
                WriteLiteral("--可根据季节搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2520, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 62 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                      
                        if (Model.seasonCodeList != null)
                        {
                            foreach (var item in Model.seasonCodeList)
                            {

#line default
#line hidden
            BeginContext(2735, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2767, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1db31e5ff8a4392a1aacea191bce167", async() => {
                BeginContext(2795, 9, false);
#line 67 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 67 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2813, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 68 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                            }
                        }
                    

#line default
#line hidden
            BeginContext(2896, 157, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"layui-inline\">\r\n                <select id=\"size\" lay-search=\"\">\r\n                    ");
            EndContext();
            BeginContext(3053, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b17043012c346bd9b6a498db44abfad", async() => {
                BeginContext(3070, 11, true);
                WriteLiteral("--可根据尺码搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3090, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 76 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                      
                        if (Model.sizeCodeList != null)
                        {
                            foreach (var item in Model.sizeCodeList)
                            {

#line default
#line hidden
            BeginContext(3301, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3333, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6837d6ac31fd4586966b5dd406d4f5cc", async() => {
                BeginContext(3361, 9, false);
#line 81 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 81 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3379, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 82 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Report\ShopInventory.cshtml"
                            }
                        }
                    

#line default
#line hidden
            BeginContext(3462, 5069, true);
            WriteLiteral(@"                </select>
            </div>

            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script type=""text/html"" id=""toolbar"">
        <div class=""layui-btn-container"">
            <h4>销售商品明细</h4>
        </div>
    </script>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'form', 'common', 'laydate'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    laydate = layui.laydate,
                    form = layui.form;
                form.render('select');
                laydate.render({
                    elem: '#times'
                    , theme: '#393D49'
            WriteLiteral(@"
                    , format: 'yyyy/MM/dd'
                    , range: true
                });
                var e = layer.load(2, { shade: [.05, '#000'] });
                table.render({
                    toolbar: '#toolbar',
                    elem: '#tablist',
                    url: '/api/inventory/shop/inventory',
                    cellMinWidth: 110,
                    totalRow: true,
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left', totalRowText: '合计行' },
                            { field: 'shopName', width: 200, title: '加盟商', fixed: 'left', sort: true },
                            {
                                field: 'goodsname', width: 200, title: '商品名称', templet: function (res) {
                                    return res.brand + res.seasonName + res.style + res.size;
                                }
                            },
                            { field: 'code', width: 180, titl");
            WriteLiteral(@"e: '条形码', sort: true },
                            { field: 'brand', title: '品牌', sort: true },
                            { field: 'style', title: '款式', sort: true },
                            { field: 'seasonName', title: '季节', sort: true },
                            { field: 'size', title: '尺码', sort: true },
                            { field: 'stock', sort: true, title: '库存数', totalRow: true },
                            { field: 'sale', sort: true, title: '销售数', totalRow: true },
                            { field: 'returnSum', sort: true, title: '返货数', totalRow: true }
                        ]
                    ],
                    page: { limits: [15, 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                    limit: 15,
                    id: 'tables',
                    done: function () {
                        layer.close(e);
                    }
                });

                table.on('sort(tool)', function (obj) {
                    var e = ");
            WriteLiteral(@"layer.load(2, { shade: [.05, '#000'] });
                    table.reload('tables', {
                        initSort: obj,
                        page: {
                            curr: 1
                        },
                        where: {
                            field: obj.field,
                            order: obj.type
                        },
                        done: function () {
                            layer.close(e);
                        }
                    });
                });


                var active = {
                    reload: function () {
                        var e = layer.load(2, { shade: [.05, '#000'] });
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $('#key').val(),
                          ");
            WriteLiteral(@"          brank: $('#branks').val(),
                                    size: $('#size').val(),
                                    year: $('#years').val(),
                                    season: $('#seasons').val(),
                                    time: $('#times').val(),
                                    shopGuid: $(""#shops"").val()
                                },
                                done: function () {
                                    layer.close(e);
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    }
                };

                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
            });
    </script>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Report.ShopInventoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Report.ShopInventoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Report.ShopInventoryModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Report.ShopInventoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 1 "..\..\Views\Shared\Form.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 2 "..\..\Views\Shared\Form.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\Form.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Form.cshtml")]
    public partial class _Views_Shared_Form_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Form_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\Form.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    var entity = Model as IEntity;
    var isNew = entity.IsNullKey;

    var rv = entity.GetRouteKey();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 14 "..\..\Views\Shared\Form.cshtml"
Write(Html.Partial("_Form_Header", entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\Views\Shared\Form.cshtml"
    
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Shared\Form.cshtml"
     using (Html.BeginForm((isNew ? "Add" : "Edit"), null, rv))
    {
        
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Shared\Form.cshtml"
                                    
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\Form.cshtml"
                                     
        //解决主键为(0长度字符串"")的异常信息无法显示问题

            
            #line default
            #line hidden
WriteLiteral("        <ul>\r\n");

            
            #line 21 "..\..\Views\Shared\Form.cshtml"
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Shared\Form.cshtml"
             foreach (var item in ViewData.ModelState.Values)
            {
                foreach (var error in item.Errors)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li>");

            
            #line 25 "..\..\Views\Shared\Form.cshtml"
                   Write(error.Exception);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 26 "..\..\Views\Shared\Form.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

            
            #line 29 "..\..\Views\Shared\Form.cshtml"
        
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Shared\Form.cshtml"
   Write(Html.Partial("_Form_Body", entity));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Shared\Form.cshtml"
                                           
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591

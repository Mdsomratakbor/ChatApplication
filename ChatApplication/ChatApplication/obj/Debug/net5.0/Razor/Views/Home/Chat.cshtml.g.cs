#pragma checksum "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e17bee546271b92b9f12151b9e86f06f6041f42d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chat), @"mvc.1.0.view", @"/Views/Home/Chat.cshtml")]
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
#nullable restore
#line 1 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\_ViewImports.cshtml"
using ChatApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\_ViewImports.cshtml"
using ChatEntities.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e17bee546271b92b9f12151b9e86f06f6041f42d", @"/Views/Home/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c891741cf2bdcebe81f83fafe2aa740d843085f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chat>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user_image_2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle user_img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/download.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("loader_image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("loader-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/loader-image.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle user_img_msg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user_image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("sendMessage(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
  ViewBag.Title = "Chat Room";
    var users = ViewBag.Users;
    int pages = @ViewBag.TotalPage - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    	body,html{
			height: 100%;
			margin: 0;
			background: #7F7FD5;
	       background: -webkit-linear-gradient(to right, #91EAE4, #86A8E7, #7F7FD5);
	        background: linear-gradient(to right, #91EAE4, #86A8E7, #7F7FD5);
		}

		.chat{
			margin-top: auto;
			margin-bottom: auto;
		}
		.card{
			height: 500px;
			border-radius: 15px !important;
			background-color: rgba(0,0,0,0.4) !important;
		}
		.contacts_body{
			padding:  0.75rem 0 !important;
			overflow-y: auto;
			white-space: nowrap;
		}
		.msg_card_body{
			overflow-y: auto;
		}
		.card-header{
			border-radius: 15px 15px 0 0 !important;
			border-bottom: 0 !important;
		}
	 .card-footer{
		border-radius: 0 0 15px 15px !important;
			border-top: 0 !important;
	}
		.container{
			align-content: center;
		}
		.search{
			border-radius: 15px 0 0 15px !important;
			background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color:white !important;
		}
		.search:focus{
		     box-s");
            WriteLiteral(@"hadow:none !important;
           outline:0px !important;
		}
		.type_msg{
			background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color:white !important;
			height: 60px !important;
			overflow-y: auto;
		}
			.type_msg:focus{
		     box-shadow:none !important;
           outline:0px !important;
		}
		.attach_btn{
	border-radius: 15px 0 0 15px !important;
	background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color: white !important;
			cursor: pointer;
		}
		.send_btn{
	border-radius: 0 15px 15px 0 !important;
	background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color: white !important;
			cursor: pointer;
		}
		.search_btn{
			border-radius: 0 15px 15px 0 !important;
			background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color: white !important;
			cursor: pointer;
		}
		.contacts{
			list-style: none;
			padding: 0;
		}
		.contacts li{
			width: 100% !important;
			padding: 5px 10px;
");
            WriteLiteral(@"			margin-bottom: 15px !important;
		}
	.active{
			background-color: rgba(0,0,0,0.3);
	}
		.user_img{
			height: 70px;
			width: 70px;
			border:1.5px solid #f5f6fa;

		}
		.user_img_msg{
			height: 40px;
			width: 40px;
			border:1.5px solid #f5f6fa;

		}
	.img_cont{
			position: relative;
			height: 70px;
			width: 70px;
	}
	.img_cont_msg{
			height: 40px;
			width: 40px;
	}
	.online_icon{
		position: absolute;
		height: 15px;
		width:15px;
		background-color: #4cd137;
		border-radius: 50%;
		bottom: 0.2em;
		right: 0.4em;
		border:1.5px solid white;
	}
	.offline{
		background-color: #c23616 !important;
	}
	.user_info{
		margin-top: auto;
		margin-bottom: auto;
		margin-left: 15px;
	}
	.user_info span{
		font-size: 20px;
		color: white;
	}
	.user_info p{
	font-size: 10px;
	color: rgba(255,255,255,0.6);
	}
	.video_cam{
		margin-left: 50px;
		margin-top: 5px;
	}
	.video_cam span{
		color: white;
		font-size: 20px;
		cursor: pointer;
		margin-right: ");
            WriteLiteral(@"20px;
	}
	.msg_cotainer{
		margin-top: auto;
		margin-bottom: auto;
		margin-left: 10px;
		border-radius: 25px;
		background-color: #82ccdd;
		padding: 10px;
		position: relative;
	}
	.msg_cotainer_send{
		margin-top: auto;
		margin-bottom: auto;
		margin-right: 10px;
		border-radius: 25px;
		background-color: #78e08f;
		padding: 10px;
		position: relative;
	}
	.msg_time{
		position: absolute;
		left: 0;
		bottom: -15px;
		color: rgba(255,255,255,0.5);
		font-size: 10px;
	}
	.msg_time_send{
		position: absolute;
		right:0;
		bottom: -15px;
		color: rgba(255,255,255,0.5);
		font-size: 10px;
	}
	.msg_head{
		position: relative;
	}
	#action_menu_btn{
		position: absolute;
		right: 10px;
		top: 10px;
		color: white;
		cursor: pointer;
		font-size: 20px;
	}
	.action_menu{
		z-index: 1;
		position: absolute;
		padding: 15px 0;
		background-color: rgba(0,0,0,0.5);
		color: white;
		border-radius: 15px;
		top: 30px;
		right: 15px;
		display: none;
	}
	.action_me");
            WriteLiteral(@"nu ul{
		list-style: none;
		padding: 0;
	margin: 0;
	}
	.action_menu ul li{
		width: 100%;
		padding: 10px 15px;
		margin-bottom: 5px;
	}
	.action_menu ul li i{
		padding-right: 10px;

	}
	.action_menu ul li:hover{
		cursor: pointer;
		background-color: rgba(0,0,0,0.2);
	}
    .loader_image {
        display: none;
        margin-left: auto;
        margin-right: auto;
        width: 6%;
    }
");
            WriteLiteral(@"</style>




<div class=""container-fluid h-100"">
    <div class=""row justify-content-center h-100"">
        <div class=""col-md-4 col-xl-3 chat"">
            <div class=""card mb-sm-3 mb-md-0 contacts_card"">
                <div class=""card-header"">
                    <div class=""input-group"">
                        <input type=""text"" placeholder=""Search...""");
            BeginWriteAttribute("name", " name=\"", 5103, "\"", 5110, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control search"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text search_btn""><i class=""fas fa-search""></i></span>
                        </div>
                    </div>
                </div>
                <div class=""card-body contacts_body"">
                    <ui class=""contacts"">
                        <li class=""active"">
                            <div class=""d-flex bd-highlight"">
                                <div class=""img_cont"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e17bee546271b92b9f12151b9e86f06f6041f42d13637", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <span class=""online_icon""></span>
                                </div>
                                <div class=""user_info"">
                                    <span>Khalid</span>
                                    <p>Kalid is online</p>
                                </div>
                            </div>
                        </li>
");
#nullable restore
#line 269 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                         foreach (var user in users)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <div class=\"d-flex bd-highlight\">\r\n                                    <div class=\"img_cont\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e17bee546271b92b9f12151b9e86f06f6041f42d15631", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <span class=\"online_icon offline\"></span>\r\n                                    </div>\r\n                                    <div class=\"user_info\">\r\n                                        <span>");
#nullable restore
#line 279 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                                         Write(user.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <p>Taherah left 7 mins ago</p>\r\n                                    </div>\r\n                                </div>\r\n                            </li>\r\n");
#nullable restore
#line 284 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </ui>
                </div>
                <div class=""card-footer""></div>
            </div>
        </div>
        <div class=""col-md-8 col-xl-6 chat"">
            <div class=""card"">
                <div class=""card-header msg_head"">
                    <div class=""d-flex bd-highlight"">
                        <div class=""img_cont"">
                            <img src=""https://static.turbosquid.com/Preview/001292/481/WV/_D.jpg"" class=""rounded-circle user_img"">
                            <span class=""online_icon""></span>
                        </div>
                        <div class=""user_info"">
                            <span>");
#nullable restore
#line 300 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                             Write(ViewBag.RoomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <p>");
#nullable restore
#line 301 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                          Write(Model.Messages.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                        <div class=""video_cam"">
                            <span><i class=""fas fa-video""></i></span>
                            <span><i class=""fas fa-phone""></i></span>
                        </div>
                    </div>
                    <span id=""action_menu_btn""><i class=""fas fa-ellipsis-v""></i></span>
                    <div class=""action_menu"">
                        <ul>
                            <li><i class=""fas fa-user-circle""></i> View profile</li>
                            <li><i class=""fas fa-users""></i> Add to close friends</li>
                            <li><i class=""fas fa-plus""></i> Add to group</li>
                            <li><i class=""fas fa-ban""></i> Block</li>
                        </ul>
                    </div>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e17bee546271b92b9f12151b9e86f06f6041f42d19812", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"card-body msg_card_body\" id=\"chat-body\" onscroll=\"data_load()\">\r\n\r\n");
#nullable restore
#line 321 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                     foreach (var message in Model.Messages)
                    {


                        if (message.Name == User.Identity.Name)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"d-flex justify-content-end mb-4\">\r\n                                <div class=\"msg_cotainer_send\">\r\n                                    ");
#nullable restore
#line 329 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                               Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span class=\"msg_time_send\">");
#nullable restore
#line 330 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                                                           Write(message.Timestamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"img_cont_msg\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e17bee546271b92b9f12151b9e86f06f6041f42d22411", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 336 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                        }
                        else
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"d-flex justify-content-start mb-4\">\r\n                                <div class=\"img_cont_msg\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e17bee546271b92b9f12151b9e86f06f6041f42d24063", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"msg_cotainer\">\r\n                                    ");
#nullable restore
#line 345 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                               Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span class=\"msg_time\">");
#nullable restore
#line 346 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                                                      Write(message.Timestamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 349 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e17bee546271b92b9f12151b9e86f06f6041f42d26272", async() => {
                WriteLiteral(@"
                    <div class=""card-footer"">
                        <div class=""input-group"">
                            <div class=""input-group-append"">
                                <span class=""input-group-text attach_btn""><i class=""fas fa-paperclip""></i></span>
                            </div>


");
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"roomId\"");
                BeginWriteAttribute("value", " value=\"", 10839, "\"", 10856, 1);
#nullable restore
#line 362 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
WriteAttributeValue("", 10847, Model.Id, 10847, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            <textarea name=""message"" id=""message-input"" required class=""form-control type_msg"" placeholder=""Type your message...""></textarea>
                            <div class=""input-group-append"">
                                <span class=""input-group-text send_btn""> <button type=""submit""><i class=""fa fa-send""></i></button></span>
                            </div>

                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e17bee546271b92b9f12151b9e86f06f6041f42d29459", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
    <script>
        //fetch(""http://example.com/api/endpoint/"", {
        //    method: ""post"",
        //    headers: {
        //        'Accept': 'application/json',
        //        'Content-Type': 'application/json'
        //    },

        //    //make sure to serialize your JSON body
        //    body: JSON.stringify({
        //        name: myName,
        //        password: myPassword
        //    })
        //})


		function message_load(id, page) {
            document.getElementById('loader-img').style.display ='inline'
			   $.ajax({
                        method: 'Get',
                        url: '../Home/MessageData',
                   data: { chatId: id, totalPages: page  }
			   }).done(function (response) {
				   let message;
                   let chatBody = document.querySelector('#chat-body');
				   if (response.messages.length > 0) {
					   let messages = response.messages;
 ");
                WriteLiteral("                      for (let i = 0; i < messages.length; i++) {\r\n                           if (messages[i].name == \'");
#nullable restore
#line 407 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                                               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"') {
							   message = `<div class=""d-flex justify-content-end mb-4"">
                                <div class=""msg_cotainer_send"">
                                   ${messages[i].text}
                                    <span class=""msg_time_send"">${messages[i].timestamp}</span>
                                </div>
                                <div class=""img_cont_msg"">
                                    <img src=""/images/user_image_2.jpg"" class=""rounded-circle user_img_msg"">
                                </div>
                            </div>`
						   }
						   else {

							   message = `<div class=""d-flex justify-content-start mb-4"">
                                <div class=""img_cont_msg"">
                                    <img src=""/images/user_image.png"" class=""rounded-circle user_img_msg"">
                                </div>
                                <div class=""msg_cotainer"">
                                     ${messages[i].text}
                  ");
                WriteLiteral(@"                  <span class=""msg_time"">${messages[i].timestamp}</span>
                                </div>
                            </div>`
						   }
						   chatBody.insertAdjacentHTML('afterbegin', message);
                          document.getElementById('loader-img').style.display = 'none'
					   }
                   }

              })
		}

		let page = ");
#nullable restore
#line 438 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
              Write(pages);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\t\tfunction data_load() {\r\n\r\n\t\t\tif (document.querySelector(\'#chat-body\').scrollTop == 0) {\r\n\r\n\t\t\t\tif (page > 0) {\r\n\t\t\t\t\tmessage_load(\'");
#nullable restore
#line 444 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                             Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', page);
                    page= page-1;
                }

			};
		}



        const connection = new signalR.HubConnectionBuilder()
            .withUrl(""/chatHub"")
            .build();

        var _connectionId = '';

        connection.on(""RecieveMessage"", function (data) {

			var message = `<div class=""d-flex justify-content-end mb-4"">
                                    <div class=""msg_cotainer_send"">
                                        ${data.text}
                                        <span class=""msg_time_send"">${data.timestamp}</span>
                                    </div>
                                    <div class=""img_cont_msg"">
                                        <img src=""/images/user_image_2.jpg"" class=""rounded-circle user_img_msg"">
                                    </div>
                                </div>`
            document.querySelector('#chat-body').innerHTML += message;
        });



        var joinRoom = function () {
   ");
                WriteLiteral("         var url = \'Chat/JoinRoom/\' + _connectionId + \'/");
#nullable restore
#line 476 "D:\My Project\ChatApp\ChatApplication\ChatApplication\Views\Home\Chat.cshtml"
                                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            axios.post(url, null)
                .then(result => {
                    console.log(""Room Joined!"", result);
                })
                .catch(error => {
                    console.error(""Failed to join Room"");
                });
    }

    connection.start()
        .then(function () {
            connection.invoke('getConnectionId')
                .then(function (connectionId) {
                    _connectionId = connectionId;
                    joinRoom();
                })
        })
        .catch(function (error) {
            console.log(error);
        })

        var form = null;
        var sendMessage = (event) => {
            event.preventDefault();
            form = event.target;
            var data = new FormData(event.target);
            document.getElementById('message-input').value='';
            axios.post(""/Chat/SendMessage"", data)
                .then(res => {
                    console.log('Message Sent!!');
          ");
                WriteLiteral("      })\r\n                .catch(error => {\r\n                    console.log(\"Failed to send message\");\r\n                });\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chat> Html { get; private set; }
    }
}
#pragma warning restore 1591

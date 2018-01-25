using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Local_EPiServer.Models.Pages
{
    [ContentType(DisplayName = "testpage", GroupName = Global.GroupNames.Products, GUID = "4ac0966a-8225-4d54-9401-2e29a94d1f44", Description = "TESTTESTTEST")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-product.png")]
    public class testpage : SitePageData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }

                [Display(GroupName = Global.GroupNames.MetaData, Order = 300)]
                    public virtual LinkItemCollection Meta_Title { get; set; }
        
         
    }
}
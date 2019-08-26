using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06.fiap.TagHelpers
{
    public class AlertaTagHelper : TagHelper
    {

        public string Texto { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!string.IsNullOrEmpty(Texto))
            {
                output.TagName = "div";
                output.Attributes.SetAttribute("class", "alert alert-sucess");
                output.Content.SetContent(Texto);
            }          
        }
    }
}

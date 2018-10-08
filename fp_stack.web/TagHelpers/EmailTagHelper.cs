using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;

namespace fp_stack.web.TagHelpers
{
    public class Email :TagHelper
    {
        public string MailTo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var address = $"{MailTo}@fiap.com";
            output.Attributes.SetAttribute("href", $"mailto:{address}");
            output.Content.SetContent(address);
        }
    }
}

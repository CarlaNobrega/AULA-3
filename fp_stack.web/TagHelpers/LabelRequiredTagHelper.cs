using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace fp_stack.web.TagHelpers
{
    [HtmlTargetElement("label", Attributes = ForAttributeName)]
    public class LabelRequiredTagHelper : LabelTagHelper
    {
        private const string ForAttributeName = "asp-for";

        public LabelRequiredTagHelper(IHtmlGenerator generator) : base(generator)
        {
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await base.ProcessAsync(context, output);
            var data = new DateTime();
            //if (For.Metadata.IsRequired)
            if (For.Model != null)
                if (DateTime.TryParse(For.Model.ToString(), out data))
                {
                    output.Content.AppendHtml("<input type=\"date\" value=\"" + data.ToString("yyyy-MM-dd") + "\">");
                }
        }
    }
}

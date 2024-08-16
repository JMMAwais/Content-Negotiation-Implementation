using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System.Text;
using System.IO;

namespace Content_Negotiation_Implementation.TextFormatter
{
    public class HtmlTextFormatter : TextOutputFormatter
    {
        public HtmlTextFormatter()
        {
            SupportedMediaTypes.Add( new MediaTypeHeaderValue("text/html"));
            SupportedEncodings.Add(Encoding.UTF8);
        }


        public override bool CanWriteResult(OutputFormatterCanWriteContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            return /*context.ContentType != null &&*/
           context.ContentType.Equals("text/html", StringComparison.OrdinalIgnoreCase);
        }
        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            var employees = context.Object;
            using (var writer = new StreamWriter(context.HttpContext.Response.Body, selectedEncoding, leaveOpen: true))
            {

              
            }
        }
    }
}

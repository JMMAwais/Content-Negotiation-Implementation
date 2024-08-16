using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System.Net.Http.Handlers;
using System.Net.Http.Formatting;
using System.Net.Http;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Extensions.Primitives;
namespace Content_Negotiation_Implementation.TextFormatter
{

    public class PlainTextFormatter : TextOutputFormatter
    {

        public PlainTextFormatter()
        {
                SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/plain"));
                SupportedEncodings.Add(Encoding.UTF8);
            
        }
       
        public override bool CanWriteResult(OutputFormatterCanWriteContext context)
        {
                return context.ContentType.Equals("text/plain", StringComparison.OrdinalIgnoreCase);
        }

    
     
        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            using (var writer = new StreamWriter(context.HttpContext.Response.Body, selectedEncoding, leaveOpen: true))
            {
                foreach (var employee in context.Object as IEnumerable<Employee>)
                {
                    await writer.WriteLineAsync($"ID: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Age: {employee.Age}, Department: {employee.Department}");
                }
            }
        }
    }

}    


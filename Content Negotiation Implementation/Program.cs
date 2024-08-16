using Content_Negotiation_Implementation.MiddleWares;
using Content_Negotiation_Implementation.TextFormatter;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(options =>
{
    //options.OutputFormatters.Clear();
    options.OutputFormatters.Add(new PlainTextFormatter());
    options.OutputFormatters.Add(new HtmlTextFormatter());
    options.RespectBrowserAcceptHeader = true;
    options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
}).AddXmlSerializerFormatters();

builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.AllowSynchronousIO = true;
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGet("/plain-text", (HttpContext context) =>
{
    context.Response.ContentType = "text/plain";
});
app.UseMiddleware<RequestCheckMiddleware>();

app.Run();

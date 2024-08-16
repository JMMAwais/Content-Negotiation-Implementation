using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text;

namespace Content_Negotiation_Implementation
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    //      <title>AJAX Example</title>
    //    <script src = "https://code.jquery.com/jquery-3.6.0.min.js" ></ script >
    //</ head >
    //< body >
    //    < h1 > AJAX Call Example</h1>
    //    <button id = "fetchJson" > Fetch JSON</button>
    //    <button id = "fetchText" > Fetch Plain Text</button>
    //    <button id = "fetchHtml" > Fetch HTML</button>

    //    <div id = "responseContainer" ></ div >

    //    < script >
    //        $(document).ready(function() {
    //            $('#fetchJson').click(function() {
    //                $.ajax({
    //                url: '/api/employees',
    //                    type: 'GET',
    //                    headers:
    //                {
    //                    'Accept': 'application/json'
    //                    },
    //                    dataType: 'json',
    //                    success: function(data) {
    //                    // Generate table
    //                    let html = '<table border="1" style="width:100%; border-collapse: collapse;">';
    //                    html += '<thead><tr><th>ID</th><th>Name</th><th>Gender</th><th>Age</th></tr></thead>';
    //                    html += '<tbody>';

    //                        $.each(data, function(index, employee) {
    //                        html += `< tr >

    //                                    < td >${ employee.id}</ td >

    //                                    < td >${ employee.name}</ td >

    //                                    < td >${ employee.gender}</ td >

    //                                    < td >${ employee.age}</ td >

    //                                 </ tr >`;
    //                    });

    //                    html += '</tbody></table>';
    //                        $('#responseContainer').html(html);
    //                },
    //                    error: function() {
    //                        $('#responseContainer').html('<p>An error occurred.</p>');
    //                }
    //            });

    //public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
    //{
    //    //var employees = context.Object ;
    //    //using (var writer = new StreamWriter(context.HttpContext.Response.Body, selectedEncoding, leaveOpen: true))
    //    //{

    //    //    await writer.WriteLineAsync("<h1>Employee List</h1>");
    //    //    foreach (var employee in employees)
    //    //    {
    //    //        await writer.WriteLineAsync($"<p>ID: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Age: {employee.Age}, Department: {employee.Department}</p>");
    //    //    }
    //    //}
    //}

    //public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
    //{
    //    //using (var writer = new StreamWriter(context.HttpContext.Response.Body, selectedEncoding, leaveOpen: true))
    //    //{
    //    //    foreach (var employee in context.Object )
    //    //    {
    //    //        await writer.WriteLineAsync($"ID: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Age: {employee.Age}");
    //    //    }
    //    //}
    //}

}

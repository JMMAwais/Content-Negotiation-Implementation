namespace Content_Negotiation_Implementation
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        //bool isAjaxRequest = context.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        //context.Items["IsAjaxRequest"] = isAjaxRequest;
    }
}

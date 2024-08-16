using Microsoft.AspNetCore.Mvc.Rendering;

namespace Content_Negotiation_Implementation.ViewModel
{
    public class ContentTypeDropDown
    {
        public int SelectedValue { get; set; }
        public List<SelectListItem> Options { get; set; }
    }
}

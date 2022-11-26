using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngelasBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }        // Displays all the product details
        public IEnumerable<SelectListItem> CategoryList { get; set; }           // Installed the package for SelectListItem to work
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}

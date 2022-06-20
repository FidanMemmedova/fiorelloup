using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.ViewModels.Category1
{
    public class CategoryCreateViewModel
    {
        [Required(ErrorMessage =("Boş buraxma."))]
        public string Name { get; set; }
    }
}

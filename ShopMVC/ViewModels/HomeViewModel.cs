using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopMVC.Models;

namespace ShopMVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}

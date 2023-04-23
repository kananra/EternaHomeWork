using EternaHomeWork.Models;
using System.Collections.Generic;

namespace EternaHomeWork.ViewModels
{
    public class HomeViewModel
    {
        public List<Feature> Features { get; set; }
        public List<Service> Services { get; set; }
        public List<Slider> Sliders { get; set; }
    }
}

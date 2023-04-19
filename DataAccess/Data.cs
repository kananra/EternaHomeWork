using EternaHomeWork.Models;
using System.Collections.Generic;

namespace EternaHomeWork.DataAccess
{
    public  static class Data
    {
        public static List<Feature> Features = new List<Feature>
        {
            new Feature{Id=1,Tittle="Lorem Ipsum",Icon="bi bi-card-checklist",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new Feature{Id=2,Tittle="Dolor Sitema",Icon="bi bi-bar-chart",Desc="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"},
            new Feature{Id=3,Tittle="Sed ut perspiciatis",Icon="bi bi-binoculars",Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"},
        };

        public static List<Service> Services = new List<Service>
        {
            new Service{Id=1,Tittle="Lorem Ipsum",Icon="bx bxl-dribbble",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=2,Tittle="Sed ut perspiciatis",Icon="bx bx-file",Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"},
            new Service{Id=3,Tittle="Magni Dolores",Icon="bx bx-tachometer",Desc="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"},
            new Service{Id=4,Tittle="Nemo Enim",Icon="bx bx-world",Desc="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"},
            new Service{Id=5,Tittle="Dele cardo",Icon="bx bx-slideshow",Desc="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"},
            new Service{Id=6,Tittle="Divera don",Icon="bx bx-arch",Desc="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"},
        };
    }
}

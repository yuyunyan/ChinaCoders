using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinaCoders.Models.ViewModels
{
    public class BaseViewModel
    {//Sabio: make note that this base class does not have to be, or should not be abstract. 
     // it is a perfectly good class to be used as a ViewModel 

        public bool IsLoggedIn { get; set; }
        public string CurrentNav { get; set; }
        //public UserDetails AppUser { get; set; }
        //public UserRolesType CurrentRole { get; set; }
        //public List<CmsPageMetaTag> MetaTags { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.DirectoryServices.AccountManagement;
using System.Web;

namespace WordStuff.Models
{
    public class User
    {
        public WindowsIdentity UserObject { get; set; }
        public PrincipalContext Context { get; set; }
        public User()
        {
            UserObject = WindowsIdentity.GetCurrent();
            //Context = new PrincipalContext(ContextType.Domain, "DESKTOP-9UJUBIL");
            
        }
    }
}
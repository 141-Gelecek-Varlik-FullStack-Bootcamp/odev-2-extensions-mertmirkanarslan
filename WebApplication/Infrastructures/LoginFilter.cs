using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1;
using ConsoleApp1;

namespace WebApplication.Infrastructures
{
    //LoginFilter attribute'u Attribute ve IActionFilter'dan kalitim alacak. Daha sonra
    //implementasyonlari yaptik
    public class LoginFilter : Attribute, IActionFilter
    {
        string userType = ClassLibrary1.Extensions.GetDisplayName(UserTypes.type1);
        
        private string user;
        public LoginFilter(string _user)
        {
            user = _user;
        }

        //Metot sonu.
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        //Metot calistirildiği an. Burada kisaca bir if blogu icinde ulasmaya calisan kullanici
        //eger admin veya developer ise indexe, bunlar disinda herhangi bir tipteyse privacy sayfasina yonlendirdik.
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (user == "Admin" || user == "Developer")
            {

            }
            else
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Privacy" }));
            }
            return;
            throw new NotImplementedException();
        }
    }
}

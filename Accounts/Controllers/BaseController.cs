﻿    using System.Web.Mvc;
using AccountsFunction;
using AccountsWebAuthentication.Helper;

namespace Accounts.Controllers
{
    public class BaseController : Controller
    {
        private IFUser _iFUser;

        public BaseController()
        {
            _iFUser = new FUser();
        }

        protected string Username
        {
            get
            {
                return WindowsUser.Username;
            }
        }

        protected int UserId
        {
            get
            {
                var user = _iFUser.Read(Username);
                int UserID = user?.UserId ?? 0;
                return UserID;
            }
        }

    }
}
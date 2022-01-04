using Dependency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dependency.Controllers
{
    public class NotificationController : ApiController
    {
        public void Get()
        {
            Notification bildirim = Creator.CreateBildirimInstance();
            bildirim.Yap();
        }
    }
}

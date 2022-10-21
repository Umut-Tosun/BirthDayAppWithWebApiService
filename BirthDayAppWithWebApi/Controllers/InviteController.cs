using BirthDayAppWithWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirthDayAppWithWebApi.Controllers
{
    public class InviteController : ApiController
    {
      
        public IEnumerable<InvitationModel> GetAttendees()
        {
            return Database.List.Where(x => x.Status == true);
        }
       
        public void Postadd(InvitationModel invitationModel)
        {
            if(ModelState.IsValid)
            {
                Database.add(invitationModel);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthDayAppWithWebApi.Models
{
    public class Database
    {
        private static Dictionary<string, InvitationModel> _list;
        static Database()
        {
            _list = new Dictionary<string, InvitationModel>();
            _list.Add("Hasan", new InvitationModel
            {
                Name = "Hasan",
                Mail = "Hasan@gmail.com",
                Status = true
            });
            _list.Add("İsmail", new InvitationModel
            {
                Name = "İsmail",
                Mail = "ismail@gmail.com",
                Status = true
            });
        }
        public static void add(InvitationModel invitationModel)
        {
            string key = invitationModel.Name.ToLower();
            if (_list.ContainsKey(key))
            {
                _list[key] = invitationModel;
            }
            else
            {
                _list.Add(key, invitationModel);
            }
        }
        public static IEnumerable<InvitationModel> List
        {
            get { return _list.Values; }
        }
    }
}

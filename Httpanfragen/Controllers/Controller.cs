using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Httpanfragen.Models;

namespace Httpanfragen.Controllers
{
    public class Controller
    {
        #region Eigenschaften
        private List<Models.Nachricht> _ChatList = new List<Models.Nachricht>();

        #endregion

        #region Accessoren/Modifier
        public List<Nachricht> ChatList { get => _ChatList; set => _ChatList = value; }

        #endregion

        #region Konstruktoren
        public Controller()
        {
            this.ChatList = new List<Nachricht>();
        }


        #endregion

        #region Worker
        public async Task Senden(string url,string Nachricht)
        {
            HttpClient ht = new HttpClient();

            var x = ht.GetAsync(url + "?wert=" + Nachricht).Result;
        }
        #endregion
    }
}
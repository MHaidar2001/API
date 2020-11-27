using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Httpanfragen.Controllers;

namespace Httpanfragen.Views
{
    public partial class Chat : System.Web.UI.Page
    {
        #region Eigenschaften
        private Controllers.Controller _Verwalter;

        #endregion

        #region Accessoren/Modifier
        public Controller Verwalter { get => _Verwalter; set => _Verwalter = value; }

        #endregion

        #region Konstruktoren
        public Chat()
        {
            this.Verwalter = new Controller();
        }
        #endregion

        #region Worker
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitbtn_Click(object sender, EventArgs e)
        {
           Verwalter.Senden(urltxt.Text,chattxt.Text);
        }
        #endregion

       
    }
}
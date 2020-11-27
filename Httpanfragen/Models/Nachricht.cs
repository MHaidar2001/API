using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Httpanfragen.Models
{
    public class Nachricht
    {
        #region Eigenschaften
        private int _ID;
        private string _Text;
        private DateTime _Datum;
        private string _status;

        #endregion

        #region Accessoren/Modifier
        public int ID { get => _ID; set => _ID = value; }
        public string Text { get => _Text; set => _Text = value; }
        public DateTime Datum { get => _Datum; set => _Datum = value; }
        public string Status { get => _status; set => _status = value; }

        #endregion

        #region Konstruktoren
        public Nachricht()
        {
            this.ID = -1;
            this.Text = "";
            this.Datum = new DateTime() ;
            this.Status = "";
        }
        #endregion

        #region Worker
        #endregion
    }
}
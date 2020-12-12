using DEMO.Webforms.DAL;
using DEMO.Webforms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO.Webforms
{
    public partial class BandList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Band> GetBands()
        {
            var _db = new BandContext();
            IQueryable<Band> query = _db.Bands;
            return query;
        }
    }
}
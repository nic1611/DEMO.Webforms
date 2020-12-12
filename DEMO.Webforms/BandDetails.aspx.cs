using DEMO.Webforms.DAL;
using DEMO.Webforms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO.Webforms
{
    public partial class BandDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Band> GetBand([RouteData] int? Id)
        {
            var _db = new BandContext();
            IQueryable<Band> query = _db.Bands;
            if (Id.HasValue && Id > 0)
            {
                query = query.Where(p => p.Id == Id);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}
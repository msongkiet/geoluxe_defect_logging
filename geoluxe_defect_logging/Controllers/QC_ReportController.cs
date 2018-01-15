using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace geoluxe_defect_logging.Controllers
{
    public class QC_ReportController : Controller
    {
        // GET: QC_Report
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PM_O()
        {
            return View();
        }

        public ActionResult Shift()
        {
            return View();
        }

        public ActionResult Production()
        {
            return View();
        }
    }
}
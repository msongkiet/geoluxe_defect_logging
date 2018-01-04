using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using geoluxe_defect_logging.Models;

namespace geoluxe_defect_logging.Controllers
{
    public class QC_DefectDataInputController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        // POST: Index
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(QC_SlabList models)
        {
            TempData["SlabID"] = models.SlabID;
            return RedirectToAction("SlabDetailPartial", "QC_DefectDataInput", TempData["SlabID"]);
        }

        // GET: Slab Detail Partial View
        public ActionResult SlabDetailPartial(QC_SlabList models)
        {
            models.SlabID = (UInt64)(TempData["SlabID"]);
            models.OrderNo = 999999;
            models.MatType = "";

            if (models.SlabID.ToString().Length == 0)
            {
                models.SlabID = 999999;
            }

            if (models.SlabID.ToString().Length > 2)
            {
                var str = (models.SlabID.ToString()).Substring(0, 2);

                switch (str)
                {
                    case "10":
                        models.MatType = "ERAMO";
                        break;
                    case "14":
                        models.MatType = "APHRODITE";
                        break;
                    case "27":
                        models.MatType = "PALISSANDRO";
                        break;
                    case "30":
                        models.MatType = "BLUETTE";
                        break;
                    case "40":
                        models.MatType = "DIONYSOS";
                        break;
                    case "60":
                        models.MatType = "NESTOS GRAY";
                        break;
                    case "62":
                        models.MatType = "ALIVERY";
                        break;
                    case "70":
                        models.MatType = "NESTOS ROYAL";
                        break;
                    case "74":
                        models.MatType = "ERABUS";
                        break;
                    default:
                        models.MatType = "N/A";
                        break;
                }
            }

            return RedirectToAction("SlabDetail", "QC_DefectDataInput", models);

        }

        // GET: Slab Detail
        public ActionResult SlabDetail(QC_SlabDefectList models)
        {
            //var SlabID = models.SlabID;
            //var OrderNo = models.OrderNo;
            //var MatType = models.MatType;
            //var SlabWidth_1 = models.Width_1;
            //var SlabWidth_2 = models.Width_2;
            //var SlabLength_1 = models.Length_1;
            //var SlabLength_2 = models.Length_2;
            //var SlabThickness_1 = models.Thickness_1;
            //var SlabThickness_2 = models.Thickness_2;
            //var SlabThickness_3 = models.Thickness_3;
            //var SlabThickness_4 = models.Thickness_4;
            //var SlabThickness_5 = models.Thickness_5;
            //var SlabThickness_6 = models.Thickness_6;

            return View();
        }

        //GET: Defect Detail Partial View
        public ActionResult DefectDetailPartial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DefectListPartial()
        {
            Console.WriteLine("STOP");
            return View();
        }

        // POST: Defect Detail Partial View
        //[HttpPost]
        //[AllowAnonymous]
        //public ActionResult DefectDetailPartial(ICollection<QC_SlabDefectList> QC_SlabDefectList)
        //{

        //    return RedirectToAction("ListView", "QC_DefectDataInput", QC_SlabDefectList);
        //}

        //public ActionResult ListView(ICollection<QC_SlabDefectList> models)
        //{
        //    return View();
        //}

        public ActionResult Defect0()
        {
            return PartialView();
        }

        public ActionResult Defect100()
        {
            return PartialView();
        }

        public ActionResult Defect200()
        {
            return PartialView();
        }

        public ActionResult Defect300()
        {
            return PartialView();
        }

        public ActionResult Defect400()
        {
            return PartialView();
        }

        public ActionResult Defect500()
        {
            return PartialView();
        }

    }

}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebformReal.Models;

namespace WebformReal.Controllers
{
    public class UEC_UEC57Controller : Controller
    {
        // GET: UEC_UEC57
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;


        //Alam View Controls
        public ActionResult UEC_UEC57_AlamIndex()
        {
            UEC_UEC57 db = new UEC_UEC57();
            List<UEC_UEC57> obj = db.AlamgetData();

            return View(obj);
        }
        public ActionResult UEC_UEC57_AlamCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UEC_UEC57_AlamCreate(UEC_UEC57 data)
        {
            try
            {
                UEC_UEC57 db = new UEC_UEC57();
                bool check = db.AlamAddData(data);
                if (check == true)
                {
                    TempData["InsertMessage"] = "Data has been inserted Successfully!";
                    ModelState.Clear();
                    return RedirectToAction("UEC_UEC57_AlamIndex");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult UEC_UEC57_AlamEdit(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.AlamgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_AlamEdit(int id, UEC_UEC57 data)
        {

            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.AlamUpdateData(data);
            if (check == true)
            {
                TempData["UpdateMessage"] = "Data has been Updated Successfully.";
                ModelState.Clear();
                return RedirectToAction("UEC_UEC57_AlamIndex");
            }
            return View();
        }
        public ActionResult UEC_UEC57_AlamDetails(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.AlamgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        public ActionResult UEC_UEC57_AlamDelete(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.AlamgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_AlamDelete(int id, UEC_UEC57 data)
        {
            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.AlamDeleteData(id);
            if (check == true)
            {
                TempData["DeleteMessage"] = "Data has been Deleted Successfully.";
                return RedirectToAction("UEC_UEC57_AlamIndex");
            }
            return View();
        }


        //Amal View Controls

        public ActionResult UEC_UEC57_AmalIndex()
        {
            UEC_UEC57 db = new UEC_UEC57();
            List<UEC_UEC57> obj = db.AmalgetData();

            return View(obj);
        }
        public ActionResult UEC_UEC57_AmalCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UEC_UEC57_AmalCreate(UEC_UEC57 data)
        {
            try
            {
                UEC_UEC57 db = new UEC_UEC57();
                bool check = db.AmalAddData(data);
                if (check == true)
                {
                    TempData["InsertMessage"] = "Data has been inserted Successfully!";
                    ModelState.Clear();
                    return RedirectToAction("UEC_UEC57_AmalIndex");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult UEC_UEC57_AmalEdit(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.AmalgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_AmalEdit(int id, UEC_UEC57 data)
        {

            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.AmalUpdateData(data);
            if (check == true)
            {
                TempData["UpdateMessage"] = "Data has been Updated Successfully.";
                ModelState.Clear();
                return RedirectToAction("UEC_UEC57_AmalIndex");
            }
            return View();
        }
        public ActionResult UEC_UEC57_AmalDetails(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.AmalgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        public ActionResult UEC_UEC57_AmalDelete(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.AmalgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_AmalDelete(int id, UEC_UEC57 data)
        {
            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.AmalDeleteData(id);
            if (check == true)
            {
                TempData["DeleteMessage"] = "Data has been Deleted Successfully.";
                return RedirectToAction("UEC_UEC57_AmalIndex");
            }
            return View();
        }


        //Harweel View Controls

        public ActionResult UEC_UEC57_HarweelIndex()
        {
            UEC_UEC57 db = new UEC_UEC57();
            List<UEC_UEC57> obj = db.HarweelgetData();

            return View(obj);
        }
        public ActionResult UEC_UEC57_HarweelCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UEC_UEC57_HarweelCreate(UEC_UEC57 data)
        {
            try
            {
                UEC_UEC57 db = new UEC_UEC57();
                bool check = db.HarweelAddData(data);
                if (check == true)
                {
                    TempData["InsertMessage"] = "Data has been inserted Successfully!";
                    ModelState.Clear();
                    return RedirectToAction("UEC_UEC57_HarweelIndex");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult UEC_UEC57_HarweelEdit(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.HarweelgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_HarweelEdit(int id, UEC_UEC57 data)
        {

            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.HarweelUpdateData(data);
            if (check == true)
            {
                TempData["UpdateMessage"] = "Data has been Updated Successfully.";
                ModelState.Clear();
                return RedirectToAction("UEC_UEC57_HarweelIndex");
            }
            return View();
        }
        public ActionResult UEC_UEC57_HarweelDetails(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.HarweelgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        public ActionResult UEC_UEC57_HarweelDelete(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.HarweelgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_HarweelDelete(int id, UEC_UEC57 data)
        {
            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.HarweelDeleteData(id);
            if (check == true)
            {
                TempData["DeleteMessage"] = "Data has been Deleted Successfully.";
                return RedirectToAction("UEC_UEC57_HarweelIndex");
            }
            return View();
        }


        //Birba View Controls

        public ActionResult UEC_UEC57_BirbaIndex()
        {
            UEC_UEC57 db = new UEC_UEC57();
            List<UEC_UEC57> obj = db.BirbagetData();

            return View(obj);
        }
        public ActionResult UEC_UEC57_BirbaCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UEC_UEC57_BirbaCreate(UEC_UEC57 data)
        {
            try
            {
                UEC_UEC57 db = new UEC_UEC57();
                bool check = db.BirbaAddData(data);
                if (check == true)
                {
                    TempData["InsertMessage"] = "Data has been inserted Successfully!";
                    ModelState.Clear();
                    return RedirectToAction("UEC_UEC57_BirbaIndex");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult UEC_UEC57_BirbaEdit(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.BirbagetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_BirbaEdit(int id, UEC_UEC57 data)
        {

            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.BirbaUpdateData(data);
            if (check == true)
            {
                TempData["UpdateMessage"] = "Data has been Updated Successfully.";
                ModelState.Clear();
                return RedirectToAction("UEC_UEC57_BirbaIndex");
            }
            return View();
        }
        public ActionResult UEC_UEC57_BirbaDetails(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.BirbagetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        public ActionResult UEC_UEC57_BirbaDelete(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.BirbagetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_BirbaDelete(int id, UEC_UEC57 data)
        {
            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.BirbaDeleteData(id);
            if (check == true)
            {
                TempData["DeleteMessage"] = "Data has been Deleted Successfully.";
                return RedirectToAction("UEC_UEC57_BirbaIndex");
            }
            return View();
        }


        //Alnoor View Controls

        public ActionResult UEC_UEC57_AlnoorIndex()
        {
            UEC_UEC57 db = new UEC_UEC57();
            List<UEC_UEC57> obj = db.AlnoorgetData();

            return View(obj);
        }
        public ActionResult UEC_UEC57_AlnoorCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UEC_UEC57_AlnoorCreate(UEC_UEC57 data)
        {
            try
            {
                UEC_UEC57 db = new UEC_UEC57();
                bool check = db.AlnoorAddData(data);
                if (check == true)
                {
                    TempData["InsertMessage"] = "Data has been inserted Successfully!";
                    ModelState.Clear();
                    return RedirectToAction("UEC_UEC57_AlnoorIndex");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult UEC_UEC57_AlnoorEdit(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.AlnoorgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_AlnoorEdit(int id, UEC_UEC57 data)
        {

            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.AlnoorUpdateData(data);
            if (check == true)
            {
                TempData["UpdateMessage"] = "Data has been Updated Successfully.";
                ModelState.Clear();
                return RedirectToAction("UEC_UEC57_AlnoorIndex");
            }
            return View();
        }
        public ActionResult UEC_UEC57_AlnoorDetails(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.AlnoorgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        public ActionResult UEC_UEC57_AlnoorDelete(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.AlnoorgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_AlnoorDelete(int id, UEC_UEC57 data)
        {
            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.AlnoorDeleteData(id);
            if (check == true)
            {
                TempData["DeleteMessage"] = "Data has been Deleted Successfully.";
                return RedirectToAction("UEC_UEC57_AlnoorIndex");
            }
            return View();
        }

        //RHIP View Controls

        public ActionResult UEC_UEC57_RHIPIndex()
        {
            UEC_UEC57 db = new UEC_UEC57();
            List<UEC_UEC57> obj = db.RHIPgetData();

            return View(obj);
        }
        public ActionResult UEC_UEC57_RHIPCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UEC_UEC57_RHIPCreate(UEC_UEC57 data)
        {
            try
            {
                UEC_UEC57 db = new UEC_UEC57();
                bool check = db.RHIPAddData(data);
                if (check == true)
                {
                    TempData["InsertMessage"] = "Data has been inserted Successfully!";
                    ModelState.Clear();
                    return RedirectToAction("UEC_UEC57_RHIPIndex");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult UEC_UEC57_RHIPEdit(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.RHIPgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_RHIPEdit(int id, UEC_UEC57 data)
        {

            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.RHIPUpdateData(data);
            if (check == true)
            {
                TempData["UpdateMessage"] = "Data has been Updated Successfully.";
                ModelState.Clear();
                return RedirectToAction("UEC_UEC57_RHIPIndex");
            }
            return View();
        }
        public ActionResult UEC_UEC57_RHIPDetails(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.RHIPgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        public ActionResult UEC_UEC57_RHIPDelete(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.RHIPgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_RHIPDelete(int id, UEC_UEC57 data)
        {
            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.RHIPDeleteData(id);
            if (check == true)
            {
                TempData["DeleteMessage"] = "Data has been Deleted Successfully.";
                return RedirectToAction("UEC_UEC57_RHIPIndex");
            }
            return View();
        }

        //YKP View Controls

        public ActionResult UEC_UEC57_YKPIndex()
        {
            UEC_UEC57 db = new UEC_UEC57();
            List<UEC_UEC57> obj = db.YKPgetData();

            return View(obj);
        }
        public ActionResult UEC_UEC57_YKPCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UEC_UEC57_YKPCreate(UEC_UEC57 data)
        {
            try
            {
                UEC_UEC57 db = new UEC_UEC57();
                bool check = db.YKPAddData(data);
                if (check == true)
                {
                    TempData["InsertMessage"] = "Data has been inserted Successfully!";
                    ModelState.Clear();
                    return RedirectToAction("UEC_UEC57_YKPIndex");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult UEC_UEC57_YKPEdit(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.YKPgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_YKPEdit(int id, UEC_UEC57 data)
        {

            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.YKPUpdateData(data);
            if (check == true)
            {
                TempData["UpdateMessage"] = "Data has been Updated Successfully.";
                ModelState.Clear();
                return RedirectToAction("UEC_UEC57_YKPIndex");
            }
            return View();
        }
        public ActionResult UEC_UEC57_YKPDetails(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.YKPgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        public ActionResult UEC_UEC57_YKPDelete(int id)
        {
            UEC_UEC57 db = new UEC_UEC57();
            var row = db.YKPgetData().Find(model => model.UEC_UEC57_Alam_id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult UEC_UEC57_YKPDelete(int id, UEC_UEC57 data)
        {
            UEC_UEC57 db = new UEC_UEC57();
            bool check = db.YKPDeleteData(id);
            if (check == true)
            {
                TempData["DeleteMessage"] = "Data has been Deleted Successfully.";
                return RedirectToAction("UEC_UEC57_YKPIndex");
            }
            return View();
        }


    }
}
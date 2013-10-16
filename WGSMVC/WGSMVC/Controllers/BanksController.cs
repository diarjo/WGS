using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
//using System.Web.Routing;
using System.Web.Mvc;
using WGSMVC.Models;
using AppCore;

namespace WGSMVC.Controllers
{
    public class BanksController : Controller
    {
        //
        // GET: /Banks/
        private BankDBContext db = new BankDBContext();

        public ActionResult Index()
        {
            //return View(db.BankDB.ToList());
            BanksModel bankModel = new BanksModel();
            IList<Banks> bank =  bankModel.GetBank();
            return View(bank);
        }

        public ActionResult FormBank()
        {
            return View();
        }

        public ActionResult SaveBank()
        {
            BanksModel bankModel = new BanksModel();
            Banks bank = new Banks();
            bank.RekBank = Request["txbRekBank"];
            bank.BankName = Request["txbBankName"];
            bank.Country = Request["txbCountry"];
            if(string.IsNullOrEmpty(Request["txbBankId"]))
            {
                bankModel.InsertBank(bank);
            }
            else
            {
                bank.BankId = Request["txbBankId"];
                bankModel.UpdateBanks(bank);
            }
            return RedirectToAction("Index", "Banks");
        }

        public ActionResult EditBank(string ID)
        {
            BanksModel bankModel = new BanksModel();
            Banks bank = new Banks();
            bank.BankId = ID;
            
            bankModel.GetBankDetail(bank);
            TempData["BankId"] = bank.BankId;
            TempData["RekBank"] = bank.RekBank;
            TempData["BankName"] = bank.BankName;
            TempData["Country"] = bank.Country;
            return RedirectToAction("FormBank", "Banks");
        }

        public ActionResult DeleteBank(string ID)
        {
            BanksModel bankModel = new BanksModel();
            Banks bank = new Banks();
            bank.BankId = ID;
            bankModel.DeleteBanks(bank);
            return RedirectToAction("Index", "Banks");
        }
    }
}

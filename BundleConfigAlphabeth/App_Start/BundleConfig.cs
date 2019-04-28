using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BundleConfigAlphabeth.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Eger asagidaki gibi tek tek eklerseniz ugrasıp eklediğiniz sırada da sayfaya yüklenir ve alfabetik sorunlardan kaynaklı önce yüklenmesi gereken sonra,sonra yüklenmesi gereken js dosyası önce yüklenmez.

            //bundles.Add(new ScriptBundle("~/myscripts").Include(
            //    "~/Scripts/myscripts/jvm.js",
            //    "~/Scripts/myscripts/example.js",
            //    "~/Scripts/myscripts/app.js"
            //    ));

            //Direkt myscripts Folder'ı altındakileri ekle dersen Alfabetik sıraya göre ekler ve bu öncelik sıranızı etkiledeği için sorun yaratır.
            //Dikkat eger Script ifadenizde Jquery ifadesi görürse Mvc bunu öncelikli sayıp basta ekler geriye kalanları alfabetik olarak sıralar.
            bundles.Add(new ScriptBundle("~/myscripts").Include(
                "~/Scripts/myscripts/*.js"));



            BundleTable.EnableOptimizations = true;
        }
    }
}
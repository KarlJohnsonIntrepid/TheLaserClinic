using System.Reflection;
using System.Web;
using System.Web.Optimization;

namespace TheLaserClinc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

           // BundleTable.EnableOptimizations = false;
            CacheBuster();

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                      "~/js/jquery-1.12.4.js",
                      "~/Scripts/jquery.validate*",
                       "~/js/bootstrap.min.js",
                        "~/js/bootsnav.js",
                         "~/js/parallax.js",
                          "~/js/scrollto.js",
                           "~/js/jquery-scrolltofixed-min.js",
                           "~/js/jquery-SmoothScroll-min.js",
                           "~/js/jquery.counterup.js",
                           "~/js/gallery.js",
                            "~/js/wow.min.js",
                             "~/js/slider.js",
                              "~/js/video-player.js",
                               "~/js/timepicker.js",
                               "~/js/script.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/style.css",
                      "~/css/responsive.css"));
        }

        public static void CacheBuster()
        {
            string versionNumber = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Styles.DefaultTagFormat = string.Format("<link href='{{0}}?v={0}' rel='stylesheet'/>", versionNumber);
            Scripts.DefaultTagFormat = string.Format("<script src='{{0}}?v={0}'></script>", versionNumber);
        }
    }
}



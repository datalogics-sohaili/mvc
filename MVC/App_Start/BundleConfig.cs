using System.Web;
using System.Web.Optimization;

namespace MVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Site.css",
                      "~/Content/leftsidebar.css",
                      "~/Content/theme.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
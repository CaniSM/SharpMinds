using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(Sharpminds.Website.App_Start.SharpmindsBundleConfig), "RegisterBundles")]

namespace Sharpminds.Website.App_Start
{
    public class SharpmindsBundleConfig
    {
        public static void RegisterBundles()
        {
            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/sharpminds").Include("~/Scripts/SharpMinds/sharpminds*"));
            BundleTable.Bundles.Add(new StyleBundle("~/Content/sharpminds").Include("~/Content/docs.css", "~/Content/sharpminds.css"));

        }
    }
}

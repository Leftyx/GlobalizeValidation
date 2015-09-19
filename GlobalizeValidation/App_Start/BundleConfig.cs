using System.Web;
using System.Web.Optimization;

namespace GlobalizeValidation
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryplugins").Include(
                        "~/Scripts/jquery.cookie.js",
                        "~/Scripts/jquery.form.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/globalisation").Include(
                        "~/Scripts/cldr.js",
                        "~/Scripts/cldr/event.js",
                        "~/Scripts/cldr/supplemental.js",
                        "~/Scripts/globalize.js",
                        "~/Scripts/globalize/number.js",
                        "~/Scripts/globalize/plural.js",
                        "~/Scripts/globalize/currency.js",
                        "~/Scripts/globalize/date.js",
                        "~/Scripts/globalize/message.js",
                        "~/Scripts/globalize/relative-time.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            Bundle applicationScriptBundle = new ScriptBundle("~/bundles/application");

            applicationScriptBundle.Include(
                "~/Content/Application.js",
                "~/Content/Home.Index.js"
            );

            bundles.Add(applicationScriptBundle);

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace PersonalSiteMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/template").Include(
                        "~/Content/js/vendor/modernizr-3.5.0.min.js",
                        "~/Content/js/vendor/jquery-1.12.4.min.js",
                        "~/Content/js/popper.min.js",
                        "~/Content/js/bootstrap.min.js",
                        "~/Content/js/owl.carousel.min.js",
                        "~/Content/js/isotope.pkgd.min.js",
                        "~/Content/js/ajax-form.js",
                        "~/Content/js/waypoints.min.js",
                        "~/Content/js/jquery.counterup.min.js",
                        "~/Content/js/imagesloaded.pkgd.min.js",
                        "~/Content/js/scrollIt.js",
                        "~/Content/js/jquery.scrollUp.min.js",
                        "~/Content/js/wow.min.js",
                        "~/Content/js/nice-select.min.js",
                        "~/Content/js/jquery.slicknav.min.js",
                        "~/Content/js/jquery.magnific-popup.min.js",
                        "~/Content/js/plugins.js",
                        "~/Content/js/slick.min.js",
                        "~/Content/js/vendor/typed.js/typed.js",
                        "~/Content/js/contact.js",
                        "~/Content/js/jquery.ajaxchimp.min.js",
                        "~/Content/js/jquery.form.js",
                        "~/Content/js/jquery.validate.min.js",
                        "~/Content/js/mail-script.js",
                        "~/Content/js/main.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                        "~/Content/css/owl.carousel.min.css",
                        "~/Content/css/magnific-popup.css",
                        "~/Content/css/fontawesome.css",
                        "~/Content/css/themify-icons.css",
                        "~/Content/css/nice-select.css",
                        "~/Content/css/flaticon.css",
                        "~/Content/css/gijgo.css",
                        "~/Content/css/animate.css",
                        "~/Content/css/slick.css",
                        "~/Content/css/slicknav.css",
                        "~/Content/css/style.css"
                      ));
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace SemProjectWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Content/css").Include(
                   
                   "~/Content/font-awesome.min.css",
                   "~/Content/bootstrap.min.css",
                   "~/Content/flaticon.css",
                   "~/Content/linearicons.css",
                   "~/Content/owl.carousel.min.css",
                   "~/Content/jquery-ui.min.css",
                   "~/Content/nice-select.css",
                   "~/Content/magnific-popup.css",
                   "~/Content/slicknav.min.css",
                    "~/css/style.css"));

            bundles.Add(new StyleBundle("~/Content/booking").Include(
                "~/css/booking.css"
                ));
            bundles.Add(new StyleBundle("~/Content/login").Include(
                                  "~/img/icons/favicon.ico",
                                  "~/img/icons/favicon.ico",
                                  "~/fonts/font-awesome-4.7.0/css/font-awesome.min.css", 
                                  "~/fonts/Linearicons-Free-v1.0.0/icon-font.min.css",
                                  "~/Scripts/vendor/animate/animate.css",
                                  "~/Scripts/vendor/css-hamburgers/hamburgers.min.css",
                                  "~/Scripts/vendor/animsition/css/animsition.min.css",
                                  "~/Scripts/vendor/select2/select2.min.css",
                                  "~/Scripts/vendor/daterangepicker/daterangepicker.css",
                                  "~/css/util.css",
                                  "~/css/main.css" ));
            bundles.Add(new StyleBundle("~/Content/reg").Include(
                    "~/fonts/material-icon/css/material-design-iconic-font.min.css",
                    "~/css/style1.css"));   
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/jsp2").Include(
                         "~/Scripts/vendor/jquery/jquery-3.2.1.min.js",
                         "~/Scripts/vendor/animsition/js/animsition.min.js",
                          "~/Scripts/vendor/bootstrap/js/popper.js",
                           "~/Scripts/vendor/bootstrap/js/bootstrap.min.js",
                            "~/Scripts/vendor/select2/select2.min.js",
                           "~/Scripts/vendor/daterangepicker/moment.min.js",
                           "~/Scripts/vendor/daterangepicker/daterangepicker.js",
                           "~/Scripts/vendor/countdowntime/countdowntime.js",
                           "~/js/main.js"
            ));
            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(

                        "~/Scripts/jquery-3.3.1.min.js,",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery.magnific-popup.min.js",
                        "~/Scripts/jquery-ui.min.js",
                        "~/Scripts/jquery.nice-select.min.js",
                        "~/Scripts/jquery.slicknav.js",
                        "~/Scripts/owl.carousel.min.js",
                        "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
        }
    }
 }


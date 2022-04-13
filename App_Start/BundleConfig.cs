using System.Web;
using System.Web.Optimization;

namespace EducationManager
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Add css AdminLTE
            bundles.Add(new StyleBundle("~/AdminLTE/css").Include(
                    "~/Content/plugins/fontawesome-free/css/all.min.css",
                       "~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                       "~/Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                       "~/Content/plugins/jqvmap/jqvmap.min.css",
                       "~/Content/dist/css/adminlte.min.css",
                       "~/Content/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                       "~/Content/plugins/daterangepicker/daterangepicker.css",
                       "~/Content/plugins/summernote/summernote-bs4.min.css"
                ));
            // Add Js AdminLTE
            bundles.Add(new ScriptBundle("~/AdminLTE/js").Include(
                       "~/Content/plugins/jquery/jquery.min.js",
                         "~/Content/plugins/jquery-ui/jquery-ui.min.js",
                         "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                         "~/Content/plugins/chart.js/Chart.min.js",
                         "~/Content/plugins/sparklines/sparkline.js",
                         "~/Content/plugins/jqvmap/jquery.vmap.min.js",
                         "~/Content/plugins/jqvmap/maps/jquery.vmap.usa.js",
                         "~/Content/plugins/jquery-knob/jquery.knob.min.js",
                         "~/Content/plugins/moment/moment.min.js",
                         "~/Content/plugins/daterangepicker/daterangepicker.js",
                         "~/Content/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                         "~/Content/plugins/summernote/summernote-bs4.min.js",
                         "~/Content/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                         "~/Content/dist/js/adminlte.js",
                         "~/Content/dist/js/demo.js",
                         "~/Content/dist/js/pages/dashboard.js"
                ));

            //Add css Student
            bundles.Add(new StyleBundle("~/User/css").Include(
                    "~/Content/assets/fonts/fontawesome/fontawesome.css",
                    "~/Content/assets/libs/%40fancyapps/fancybox/dist/jquery.fancybox.min.css",
                    "~/Content/assets/libs/aos/dist/aos.css",
                    "~/Content/assets/libs/choices.js/public/assets/styles/choices.min.css",
                    "~/Content/assets/libs/flickity-fade/flickity-fade.css",
                    "~/Content/assets/libs/flickity/dist/flickity.min.css",
                    "~/Content/assets/libs/highlightjs/styles/vs2015.css",
                    "~/Content/assets/libs/jarallax/dist/jarallax.css",
                    "~/Content/assets/libs/quill/dist/quill.core.css",
                    "~/Content/assets/css/theme.min.css"
                ));
            // Add Js Student
            bundles.Add(new ScriptBundle("~/User/js").Include(
                    "~/Content/assets/libs/jquery/dist/jquery.min.js",
                    "~/Content/assets/libs/bootstrap/dist/js/bootstrap.bundle.min.js",
                    "~/Content/assets/libs/%40fancyapps/fancybox/dist/jquery.fancybox.min.js",
                    "~/Content/assets/libs/choices.js/public/assets/scripts/choices.min.js",
                    "~/Content/assets/libs/aos/dist/aos.js",
                    "~/Content/assets/libs/countup.js/dist/countUp.min.js",
                    "~/Content/assets/libs/dropzone/dist/min/dropzone.min.js",
                    "~/Content/assets/libs/flickity/dist/flickity.pkgd.min.js",
                    "~/Content/assets/libs/flickity-fade/flickity-fade.js",
                    "~/Content/assets/libs/highlightjs/highlight.pack.min.js",
                    "~/Content/assets/libs/imagesloaded/imagesloaded.pkgd.min.js",
                    "~/Content/assets/libs/isotope-layout/dist/isotope.pkgd.min.js",
                    "~/Content/assets/libs/jarallax/dist/jarallax.min.js",
                    "~/Content/assets/libs/jarallax/dist/jarallax-video.min.js",
                    "~/Content/assets/libs/jarallax/dist/jarallax-element.min.js",
                    "~/Content/assets/libs/parallax-js/dist/parallax.min.js",
                    "~/Content/assets/libs/quill/dist/quill.min.js",
                    "~/Content/assets/libs/smooth-scroll/dist/smooth-scroll.min.js",
                    "~/Content/assets/libs/typed.js/lib/typed.min.js",
                    "~/Content/assets/js/theme.min.js"

                ));
        }
    }
}

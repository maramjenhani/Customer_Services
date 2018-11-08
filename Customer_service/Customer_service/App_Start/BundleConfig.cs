using System.Web;
using System.Web.Optimization;

namespace Customer_service
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //admin side
            bundles.Add(new ScriptBundle("~/bundles/admin/js").Include(
                        "~/assets/vendor/jquery/jquery.min.js", "~/assets/vendor/bootstrap/js/bootstrap.min.js", "~/assets/vendor/metisMenu/metisMenu.min.js", "~/assets/vendor/raphael/raphael.min.js", "~/assets/vendor/morrisjs/morris.min.js", "~/assets/data/morris-data.js", "~/assets/dist/js/sb-admin-2.js"));

            bundles.Add(new StyleBundle("~/Content/admin/css").Include(
                       "~/assets/vendor/metisMenu/metisMenu.min.css",
                       "~/assets/vendor/bootstrap/css/bootstrap.min.css", "~/assets/dist/css/sb-admin-2.css", "~/assets/vendor/morrisjs/morris.css", "~/assets/vendor/font-awesome/css/font-awesome.min.css"));

            //client side
            bundles.Add(new ScriptBundle("~/client/js").Include(
                        "~/assets/js/jquery/jquery-2.2.4.min.js","~/assets/js/popper.min.js","~/assets/js/bootstrap.min.js","~/assets/js/plugins.js","~/assets/js/active.js"));
            bundles.Add(new StyleBundle("~/client/css").Include(
                     "~/assets/css/core-style.css",
                     "~/assets/style.css"));
        }
    }
}

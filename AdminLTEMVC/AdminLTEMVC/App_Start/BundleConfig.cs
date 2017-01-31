using System.Web;
using System.Web.Optimization;

namespace AdminLTEMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
           
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*")); ;


            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            //Style Bundles
            /*
             ORIGINALS
             *  <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">
                  <!-- Font Awesome -->
                  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css">
                  <!-- Ionicons -->
                  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
                  <!-- Theme style -->
                  <link rel="stylesheet" href="dist/css/AdminLTE.min.css">
                  <!-- AdminLTE Skins. Choose a skin from the css/skins
                       folder instead of downloading all of them to reduce the load. -->
                  <!-- <link rel="stylesheet" href="dist/css/skins/_all-skins.min.css"> -->
  
                  <link rel="stylesheet" href="dist/css/skins/skin-green.min.css">
                  <!-- iCheck -->
                  <link rel="stylesheet" href="plugins/iCheck/flat/blue.css">
                  <!-- Morris chart -->
                  <link rel="stylesheet" href="plugins/morris/morris.css">
                  <!-- jvectormap -->
                  <link rel="stylesheet" href="plugins/jvectormap/jquery-jvectormap-1.2.2.css">
                  <!-- Date Picker -->
                  <link rel="stylesheet" href="plugins/datepicker/datepicker3.css">
                  <!-- Daterange picker -->
                  <link rel="stylesheet" href="plugins/daterangepicker/daterangepicker.css">
                  <!-- bootstrap wysihtml5 - text editor -->
                  <link rel="stylesheet" href="plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css">
             */
            bundles.Add(new StyleBundle("~/bootstrap").Include(
                "~/bootstrap/css/bootstrap.min.css"
                ));

            bundles.Add(new StyleBundle("~/LTEBase").Include(
               "~/dist/css/AdminLTE.min.css",
               "~/dist/css/skins/skin-green.min.css",
               "~/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"
               ));
            bundles.Add(new StyleBundle("~/Plugins").Include(
               "~/plugins/iCheck/flat/blue.css",
               "~/plugins/morris/morris.css",
               "~/plugins/jvectormap/jquery-jvectormap-1.2.2.css",
               "~/plugins/datepicker/datepicker3.css",
               "~/plugins/daterangepicker/daterangepicker.css"
               ));
        
        }
    }
}

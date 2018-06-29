﻿using System.Web;
using System.Web.Optimization;

namespace BlueRibbonsReview
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/knockout-{version}.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/jquery-ui-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/javaScript").Include(
                        "~/Scripts/common/liveCreateUpdate.js",
                        "~/Scripts/common/characterLimit.js",
                        "~/Scripts/common/characterCount.js",
                        "~/Scripts/common/jQueryUI.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/sandstone.bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/themes/base/jquery-ui.css"));

            bundles.Add(new StyleBundle("~/Content/font-awesome").Include(
                       "~/Content/font-awesome.css",
                       "~/Content/font-awesome.min.css"));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPiServer.Cms.TinyMce.Core;
using Microsoft.Extensions.DependencyInjection;
using OptimizelyCMS.Models;

namespace OptimizelyCMS
{
    public static class TinyMCEServiceExtension
    {
        public static IServiceCollection AddTinyMceConfiguration(this IServiceCollection services)
        {
            //services.Configure<TinyMceConfiguration>(config =>
            //{
            //    config.Default()
            //        .AddEpiserverSupport()
            //        .Toolbar("styleselect")
            //        //.StyleFormats(
            //        //    new { title = "Image test 1", classes = "image-test1", block = "img" }
            //        //)
            //        ;
            //});
            //return services;

            services.Configure<TinyMceConfiguration>(config =>
            {
                config.For<StartPage>(t => t.SomeRichText)
                    .AddEpiserverSupport()
                    .AddPlugin(DefaultValues.EpiserverPlugins + " " + DefaultValues.TinyMcePlugins)
                    .Toolbar(DefaultValues.Toolbar + " styleselect")
                    .StyleFormats(
                        new { title = "Image test 1", classes = "image-test1", inline="img"}
                    )
                ;
            });
            return services;
        }
    }
}

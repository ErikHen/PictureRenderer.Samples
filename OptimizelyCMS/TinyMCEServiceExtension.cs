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
            services.Configure<TinyMceConfiguration>(config =>
            {
                config.For<StartPage>(t => t.SomeRichText)
                    .AddEpiserverSupport()
                    .AddPlugin(DefaultValues.EpiserverPlugins + " " + DefaultValues.TinyMcePlugins)
                    .Toolbar(DefaultValues.Toolbar + " styleselect")
                    .StyleFormats(
                        new { title = "Image test 4", classes = "image-test1", selector = "img" }
                    )
                    .Height(400)
                ;
            });
            return services;
        }
    }
}

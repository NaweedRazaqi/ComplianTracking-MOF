﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.UI.Utilities
{
    public static class LocalizationExtension
    {
        /// <summary>
        /// localize request according to {culture} route value.
        /// define supported cultures list, 
        /// define default culture for fallback,
        /// customize culture info e.g.: dat time format, digit shape,...
        /// </summary>
        /// <param name="services"></param>
        ///

        public static void ConfigureRequestLocalization(this IServiceCollection services)
        {
            var cultures = new CultureInfo[]
              {

                new CultureInfo("prs"),
                new CultureInfo("ps"),
                new CultureInfo("en")
                {
                     /* change calendar to Grgorian */
                    DateTimeFormat = { Calendar = new GregorianCalendar() },

                    /* change digit shape */
                    NumberFormat = { NativeDigits = "0 1 2 3 4 5 6 7 8 9".Split(" ") }
                }
              };

            services.Configure<RequestLocalizationOptions>(ops =>
            {
                ops.DefaultRequestCulture = new RequestCulture("prs");
                ops.SupportedCultures = cultures.OrderBy(x => x.EnglishName).ToList();
                ops.SupportedUICultures = cultures.OrderBy(x => x.EnglishName).ToList();

                // add RouteValueRequestCultureProvider to the beginning of the providers list. 
                ops.RequestCultureProviders.Insert(0,
                    new RouteValueRequestCultureProvider(cultures));
            });

        }
    }
}

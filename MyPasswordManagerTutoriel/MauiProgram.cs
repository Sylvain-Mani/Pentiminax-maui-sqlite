﻿using Microsoft.Extensions.Logging;
using MyPasswordManagerTutoriel.Data;
using MyPasswordManagerTutoriel.Views;

namespace MyPasswordManagerTutoriel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<LoginCredentialListPage>();
            builder.Services.AddTransient<LoginCredentialItemPage>();
            builder.Services.AddSingleton<Database>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
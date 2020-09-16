using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Factories;
using Application.Common.Interfaces;
using Application.Common.Services;
using Application.GameController;
using Application.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Common.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //Add Services To IOC Container
            services.AddTransient<IModelFactory, ModelFactory>();

            services.AddSingleton<IGame, Game>(); //Singleton because it has state
            services.AddTransient<IGameBuilder, GameBuilder>();
            services.AddTransient<IGameController, Director>();

            services.AddTransient<IValidationService, ValidationService>();
            services.AddTransient<IDiceService, DiceService>();

            return services;
        }
    }
}

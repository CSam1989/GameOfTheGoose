using Application.Common.DelegatesEvents;
using Application.Common.Factories;
using Application.Common.Interfaces.DelegatesEvents;
using Application.Common.Interfaces.Factories;
using Application.Common.Interfaces.GameController;
using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.services;
using Application.Common.Interfaces.Services;
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
            services.AddTransient<IGameService, GameService>();
            services.AddTransient<IWinnerService, WinnerService>();

            services.AddTransient<IMessageEvents, MessageEvents>();

            return services;
        }
    }
}
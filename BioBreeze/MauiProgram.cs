using BioBreeze.AnatomPages;
using BioBreeze.BotanicPages;
using BioBreeze.GeneticPages;
using BioBreeze.NutriPages;
using BioBreeze.ZooPages;
using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;

namespace BioBreeze
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton(AudioManager.Current);
            builder.Services.AddTransient<Creierul>();
            builder.Services.AddTransient<Muscle>();
            builder.Services.AddTransient<Ficatul>();
            builder.Services.AddTransient<Inima>();
            builder.Services.AddTransient<Limba>();
            builder.Services.AddTransient<Nasul>();
            builder.Services.AddTransient<Ochiul>();
            builder.Services.AddTransient<Piele>();
            builder.Services.AddTransient<Plamani>();
            builder.Services.AddTransient<SistemulCirculator>();
            builder.Services.AddTransient<SistemulDigestiv>();
            builder.Services.AddTransient<SistemulNervos>();
            builder.Services.AddTransient<SistemulReproductiv>();
            builder.Services.AddTransient<SistemulRespirator>();
            builder.Services.AddTransient<Skeleton>();
            builder.Services.AddTransient<Stomacul>();
            builder.Services.AddTransient<Urechea>();
            builder.Services.AddTransient<CVege>();
            builder.Services.AddTransient<EVege>();
            builder.Services.AddTransient<HVege>();
            builder.Services.AddTransient<ISVVege>();
            builder.Services.AddTransient<RFVege>();
            builder.Services.AddTransient<RVege>();
            builder.Services.AddTransient<TVege>();
            builder.Services.AddTransient<HPN>();
            builder.Services.AddTransient<HSN>();
            builder.Services.AddTransient<MN>();
            builder.Services.AddTransient<ADN>();
            builder.Services.AddTransient<Cromozomii>();
            builder.Services.AddTransient<EV>();
            builder.Services.AddTransient<G>();
            builder.Services.AddTransient<Gameti>();
            builder.Services.AddTransient<Amfibieni>();
            builder.Services.AddTransient<CAnimale>();
            builder.Services.AddTransient<EAnimale>();
            builder.Services.AddTransient<HAnimale>();
            builder.Services.AddTransient<Mamifere>();
            builder.Services.AddTransient<Moluste>();
            builder.Services.AddTransient<Nevertebrate>();
            builder.Services.AddTransient<Pasari>();
            builder.Services.AddTransient<Peste>();
            builder.Services.AddTransient<RAnimale>();
            builder.Services.AddTransient<Reptile>();
            builder.Services.AddTransient<SsiC>();
            builder.Services.AddTransient<TAnimale>();
            builder.Services.AddTransient<Vertebrate>();
            builder.Services.AddTransient<Viermi>();
            builder.Services.AddTransient<Artropode>();

            return builder.Build();
        }
    }
}

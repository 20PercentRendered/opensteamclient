using Autofac;
using Common.Autofac;
using Common.Managers;
using Common.Startup;
using Common.Utils;
using OpenSteamworks;
using System.Runtime.InteropServices;

namespace Common;

internal class CommonAutofacRegistrar : IAutofacRegistrar
{
    public static void Register(ref ContainerBuilder builder)
    {
        //TODO: this is something that the user should be able to pick. Needs a config system
        builder.Register(c => OpenSteamworks.SteamClient.ConnectionType.ExistingClient | OpenSteamworks.SteamClient.ConnectionType.NewClient).SingleInstance();
        
        builder.Register(c => new SteamClient(c.Resolve<Bootstrapper>().SteamclientLibPath, c.Resolve<SteamClient.ConnectionType>())).SingleInstance();
        builder.Register(c => new LoginManager()).SingleInstance();
    }   
}
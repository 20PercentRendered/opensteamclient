using Autofac;
using Common.Autofac;
using Common.Startup;
using Common.Utils;

namespace Common;

public static class StartupController {
    // Keeps bootstrapper from being GC'd
    internal static Bootstrapper? bootstrapper;
    public static async Task<IContainer> Startup<UIAutofacT>(IExtendedProgress<int> bootstrapperProgress) where UIAutofacT : IAutofacRegistrar {
        bootstrapper = new Bootstrapper();
        await bootstrapper.RunBootstrap(bootstrapperProgress);

        ContainerBuilder builder = new ContainerBuilder();
        builder.Register(c => bootstrapper);

        CommonAutofacRegistrar.Register(ref builder);
        UIAutofacT.Register(ref builder);

        return builder.Build();
    }
}
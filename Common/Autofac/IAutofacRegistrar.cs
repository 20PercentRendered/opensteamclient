using Autofac;

namespace Common.Autofac;

public interface IAutofacRegistrar
{
    abstract static void Register(ref ContainerBuilder builder);
}
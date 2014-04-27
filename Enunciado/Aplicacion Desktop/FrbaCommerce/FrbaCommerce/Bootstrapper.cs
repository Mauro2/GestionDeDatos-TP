namespace FrbaCommerce
{
    using System;
    using System.Windows.Forms;
    using Autofac;
    using FrbaCommerce.Core.Repositories;
    using FrbaCommerce.Core.Repositories.Providers;
    using FrbaCommerce.Core.Security;
    using FrbaCommerce.Core.Security.Providers;

    public static class Bootstrapper
    {
        static IContainer _container = null;

        public static void Register()
        {
            if (_container != null)
                return;

            var builder = new ContainerBuilder();

            builder.RegisterType<FrbaCommerce.Form1>();
            builder.RegisterType<FrbaCommerce.ABM_Rol.Listado>().Keyed<Form>(FormType.ListadoRol);
            builder.RegisterType<FrbaCommerce.ABM_Rol.Form1>().Keyed<Form>(FormType.AltaRol);
            builder.RegisterType<FrbaCommerce.Abm_Cliente.Form1>().Keyed<Form>(FormType.AltaCliente);

            builder.RegisterType<SqlRoleProvider>().As<IRoleProvider>();
            builder.RegisterType<SqlRoleRepository>().As<IRoleRepository>();

            // formFactory
            builder.Register<Func<FormType, Form>>(c => ft => _container.ResolveKeyed<Form>(ft));

            _container = builder.Build(Autofac.Builder.ContainerBuildOptions.Default);
        }

        public static T GetForm<T>()
            where T : Form
        {
            return _container.Resolve<T>();
        }
    }

    public enum FormType
    {
        ListadoRol,
        AltaRol,
        AltaCliente,
        AltaEmpresa
    }
}

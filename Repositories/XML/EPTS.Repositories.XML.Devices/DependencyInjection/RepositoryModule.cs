﻿
using EPTS.Repositories.XML.Devices.Repositories;
using Ninject.Modules;

namespace EPTS.Repositories.XML.Devices.DependencyInjection
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDataRepositories>()
                .To<DataRepositories>().WithConstructorArgument("filelocation", @"~\Infrastructure\Data\Devices.xml");
        }
    }
}

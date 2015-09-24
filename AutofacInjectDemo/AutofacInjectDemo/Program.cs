using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using IMo;
using Autofac;

namespace AutofacInjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //==dynamic load settings==
            var eMoudleAssemblyFileNames = InjectSettings.Default.EmoudleAssemblyFileNames;

            //==load assembly==
            var assList = new List<Assembly>();
            foreach (var ass in eMoudleAssemblyFileNames.Split(','))
            {
                assList.Add(Assembly.LoadFrom(ass));
            }

            //==autofac register process==
            var builder = new ContainerBuilder();
            foreach (var ass in assList)
            {
                builder.RegisterAssemblyTypes(ass).Where(t => t.Name.StartsWith("E")).AsImplementedInterfaces();
            }

            //==為了要實作命令設計模式，動態載入的Plugin，要透過以下程式碼給一個名稱，名稱就是類別名稱==

            //==為了要實作命令設計模式，動態載入的Plugin，要透過以下程式碼給一個名稱，名稱就是類別名稱==
            //builder.RegisterAssemblyTypes(assList.ToArray())
            //    .Where(t => t.IsAssignableTo<IEMoudle>())
            //    .AsImplementedInterfaces();
            //builder.RegisterAssemblyTypes(assList.ToArray()).Where(t => t.IsAssignableTo<IEMoudle>()).AsImplementedInterfaces();
            builder.RegisterType<IEMoudle>();


            //==actual process==
            using (var container = builder.Build())
            {
                //var e = container.Resolve<ETL>();
                //e.Run();

                //var e1 = container.ResolveNamed<IEMoudle>("E1");
                //e1.SaySomething();

                //var e2 = container.ResolveNamed<IEMoudle>("E2");
                //e2.SaySomething();

                var arrEModulesProcessName = InjectSettings.Default.EModuleProcess.Split(',');



                foreach (var eName in arrEModulesProcessName)
                {
                    var a = container.IsRegistered<IEMoudle>();
                    var eModule = container.ResolveKeyed<IEMoudle>(eName);

                    eModule.SaySomething();

                }

            }
        }
    }
}

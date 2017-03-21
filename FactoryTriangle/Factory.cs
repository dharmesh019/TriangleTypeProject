using InterfaceTriangle;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trangle_Repository;
using ValidationRepo;

namespace FactoryTriangleNameSpace
{

   public static class FactoryTriangle
    {
        private static IUnityContainer ObjCreationOfProjects = null;

        public static ITriangle  Create()
        {
            if (ObjCreationOfProjects == null)
            {
                ObjCreationOfProjects = new UnityContainer();
                ObjCreationOfProjects.RegisterType<ITriangle, TriangleRepo>("Triangle",
                                new InjectionConstructor(
                                    new Validations()));
               
            }
            return ObjCreationOfProjects.Resolve<ITriangle>("Triangle");
        }
    }
   
}

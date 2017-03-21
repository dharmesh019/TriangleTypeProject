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

        //Factory used to create Objects of the projects here 
        public static ITriangle  Create()
        {
            if (ObjCreationOfProjects == null)
            {
                ObjCreationOfProjects = new UnityContainer();
                //TriangleRepo is registered with Unity Container along with Validations class object is injected in it as it is required 
                ObjCreationOfProjects.RegisterType<ITriangle, TriangleRepo>("Triangle",
                                new InjectionConstructor(
                                    new Validations()));
               
            }
            return ObjCreationOfProjects.Resolve<ITriangle>("Triangle");
        }
    }
   
}

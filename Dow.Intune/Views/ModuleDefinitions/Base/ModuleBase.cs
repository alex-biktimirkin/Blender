using Microsoft.Practices.ServiceLocation;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dow.Intune.Views.ModuleDefinitions.Base
{
    public abstract class ModuleBase
    {
        protected IRegionManager RegionManager { get; set; }

        public ModuleBase()
        {
            RegionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
        }
    }
}

using Dow.Intune.Constants;
using Dow.Intune.Enums;
using Dow.Intune.Views.ModuleDefinitions.Base;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dow.Intune.Views.ModuleDefinitions
{
    public class ResultsScreen1Module : ModuleBase, IModule
    {
        public void Initialize()
        {
            RegionManager.RegisterViewWithRegion(Region.ResultsScreen1, typeof(ResultsScreen1));
        }
    }
}

using Sandbox.ModAPI;
using VRage.Game.Components;

namespace EconomyDroneBridge
{
    [MySessionComponentDescriptor(MyUpdateOrder.AfterSimulation)]
    public class EconomyDroneBridgeSession : MySessionComponentBase
    {
        public override void LoadData()
        {
            MyAPIGateway.Utilities.ShowMessage("EconomyDroneBridge", "Loaded.");
        }

        protected override void UnloadData()
        {
        }

        public override void UpdateAfterSimulation()
        {
        }
    }
}
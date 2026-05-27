using Sandbox.ModAPI;
using VRage.Game.Components;

namespace EconomyPbBridge
{
    [MySessionComponentDescriptor(MyUpdateOrder.AfterSimulation)]
    public class EconomyPbBridgeSession : MySessionComponentBase
    {
        public override void LoadData()
        {
            MyAPIGateway.Utilities.ShowMessage("EconomyPbBridge", "Loaded.");
        }

        protected override void UnloadData()
        {
        }

        public override void UpdateAfterSimulation()
        {
        }
    }
}

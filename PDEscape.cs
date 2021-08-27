using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace PocketDimensionEscape_Exiled
{
    public class PDEscape : Plugin<Config>
    {
        EventHandlers EventHandler = new EventHandlers();

        public override void OnEnabled()
        {
            base.OnEnabled();
            EventHandler = new EventHandlers();
            Player.EscapingPocketDimension += EventHandler.PocketDEscape;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            EventHandler = null;
            Player.EscapingPocketDimension -= EventHandler.PocketDEscape;
        }
    }
}

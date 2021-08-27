using Exiled.Events.EventArgs;
using Exiled.API.Features;
using System.Linq;

namespace PocketDimensionEscape_Exiled
{
    class EventHandlers
    {
        public void PocketDEscape(EscapingPocketDimensionEventArgs ev)
        {
            foreach (Player player in Player.List)
            {
                if (player.Role == RoleType.Scp106){
                    player.ShowHint("Someone escaped your pocket dimension!");
                    break;
                }
            }
        }
    }
}

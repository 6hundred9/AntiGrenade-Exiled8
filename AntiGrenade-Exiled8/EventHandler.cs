using Exiled.API.Enums;
using Exiled.API.Features.Items;
using Exiled.API.Features.Pickups.Projectiles;
using Exiled.Events.EventArgs.Player;

namespace AntiGrenade_Exiled8
{
    public class EventHandler
    {
        public static void UsingItem(UsingItemEventArgs ev)
        {
            if (ev.Item == Item.Create(ItemType.GrenadeHE))
            {
                ev.IsAllowed = false;
            }
        }
    }
}
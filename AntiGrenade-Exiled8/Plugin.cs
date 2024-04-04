using System;
using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace AntiGrenade_Exiled8
{
    public class Plugin : Plugin<Config>
    {
        public void OnEnabled()
        {
            Exiled.Events.Handlers.Player.UsingItem += EventHandler.UsingItem;
            base.OnEnabled();
        }

        public void OnDisabled()
        {
            Exiled.Events.Handlers.Player.UsingItem -= EventHandler.UsingItem;
            base.OnDisabled();
        }

        public string Name { get; } = "AntiGrenade";
        public string Prefix { get; } = "antiGrenade";
        public string Author { get; } = "6hundred9";
        public Version RequiredExiledVersion { get; } = new Version(8, 8, 0);
    }
}
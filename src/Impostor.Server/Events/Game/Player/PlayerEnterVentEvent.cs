using Impostor.Api.Events.Player;
using Impostor.Api.Games;
using Impostor.Api.Net;
using Impostor.Api.Net.Inner.Objects;

namespace Impostor.Server.Events.Player
{
    public class PlayerEnterVentEvent : IPlayerEnterVentEvent
    {
        public PlayerEnterVentEvent(IGame game, IClientPlayer clientPlayer, IInnerPlayerControl playerControl, uint ventId)
        {
            Game = game;
            ClientPlayer = clientPlayer;
            PlayerControl = playerControl;
            Vent = ventId;
        }

        public IGame Game { get; }

        public IClientPlayer ClientPlayer { get; }

        public IInnerPlayerControl PlayerControl { get; }
        
        public uint Vent { get; }
    }
}

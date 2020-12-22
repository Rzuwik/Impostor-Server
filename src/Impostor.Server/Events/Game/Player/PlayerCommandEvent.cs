using System;
using System.Linq;
using Impostor.Api.Events.Player;
using Impostor.Api.Games;
using Impostor.Api.Net;
using Impostor.Api.Net.Inner.Objects;

namespace Impostor.Server.Events.Player
{
    public class PlayerCommandEvent : IPlayerCommandEvent
    {
        public PlayerCommandEvent(IGame game, IClientPlayer clientPlayer, IInnerPlayerControl playerControl, string message)
        {
            Game = game;
            ClientPlayer = clientPlayer;
            PlayerControl = playerControl;
            Message = message;
            if (message.Contains(" "))
            {
                Command = message.Replace("/", string.Empty).Trim().Split(" ")[0];
                Args = message.Replace("/", string.Empty).Trim().Split(" ").Skip(1).ToArray();
            }
            else
            {
                Command = message.Replace("/", string.Empty);
                Args = new string[] {};
            }
        }

        public IGame Game { get; }

        public IClientPlayer ClientPlayer { get; }

        public IInnerPlayerControl PlayerControl { get; }

        public string Message { get; }

        public string Command { get; }

        public string[] Args { get; }
    }
}

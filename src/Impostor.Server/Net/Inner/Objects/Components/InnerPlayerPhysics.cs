using System;
using System.Threading.Tasks;
using Impostor.Api;
using Impostor.Api.Events.Managers;
using Impostor.Api.Innersloth;
using Impostor.Api.Net;
using Impostor.Api.Net.Messages;
using Impostor.Server.Events.Player;
using Impostor.Server.Net.State;
using Microsoft.Extensions.Logging;

namespace Impostor.Server.Net.Inner.Objects.Components
{
    internal partial class InnerPlayerPhysics : InnerNetObject
    {
        private readonly ILogger<InnerPlayerPhysics> _logger;
        private readonly InnerPlayerControl _playerControl;
        private readonly IEventManager _eventManager;
        private readonly Game _game;

        public InnerPlayerPhysics(ILogger<InnerPlayerPhysics> logger, InnerPlayerControl playerControl, IEventManager eventManager, Game game)
        {
            _logger = logger;
            _playerControl = playerControl;
            _eventManager = eventManager;
            _game = game;
        }

        public override async ValueTask<bool> HandleRpc(ClientPlayer sender, ClientPlayer? target, RpcCalls call, IMessageReader reader)
        {
            if (call != RpcCalls.EnterVent && call != RpcCalls.ExitVent)
            {
                _logger.LogWarning("{0}: Unknown rpc call {1}", nameof(InnerPlayerPhysics), call);
                return false;
            }

            if (!sender.IsOwner(this))
            {
                throw new ImpostorCheatException($"Client sent {call} to an unowned {nameof(InnerPlayerControl)}");
            }

            if (target != null)
            {
                throw new ImpostorCheatException($"Client sent {call} to a specific player instead of broadcast");
            }

            if (!sender.Character.PlayerInfo.IsImpostor)
            {
                throw new ImpostorCheatException($"Client sent {call} as crewmate");
            }

            var ventId = reader.ReadPackedUInt32();
            var ventEnter = call == RpcCalls.EnterVent;

            sender.Character.PlayerInfo.InVent = ventEnter;

            await _eventManager.CallAsync(new PlayerVentEvent(_game, _game.GetClientPlayer(this.OwnerId), _playerControl, (VentLocation)ventId, ventEnter));
            return false;
        }

        public override ValueTask<bool> SerializeAsync(IMessageWriter writer, bool initialState)
        {
            throw new NotImplementedException();
        }

        public override ValueTask DeserializeAsync(IClientPlayer sender, IClientPlayer? target, IMessageReader reader, bool initialState)
        {
            throw new NotImplementedException();
        }
    }
}

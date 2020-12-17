using Impostor.Api.Innersloth;
using Impostor.Api.Net;
using Impostor.Api.Net.Inner.Objects;

namespace Impostor.Api.Events.Player
{
    public interface IPlayerVentEvent : IPlayerEvent
    {
        /// <summary>
        ///     Gets get the id of the used vent.
        /// </summary>
        public VentLocation VentId { get; }

        /// <summary>
        ///     Gets a value indicating whether the vent was entered or exited.
        /// </summary>
        public bool VentEnter { get; }
    }
}

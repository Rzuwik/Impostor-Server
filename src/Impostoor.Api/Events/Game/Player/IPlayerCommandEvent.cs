namespace Impostor.Api.Events.Player
{
    public interface IPlayerCommandEvent : IPlayerEvent
    {
        string Message { get; }
    }
}

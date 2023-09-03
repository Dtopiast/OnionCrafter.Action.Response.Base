namespace OnionCrafter.Action.Response.Base
{
    /// <summary>
    /// Interface for action response message.
    /// </summary>
    public interface IActionResponseMessage
    {
        /// <summary>
        /// Gets the message associated with the action response.
        /// </summary>
        public string Message { get; protected set; }
    }
}
namespace Monotonless.Interfaces
{
    /// <summary>
    /// The robot that makes keyboard actions.
    /// </summary>
    public interface IKeyboardRobot
    {
        /// <summary>
        /// Parses the text and replaces the control words with the actions, such as the alt key. After this list of actions is parsed,
        /// this method sends the text as if through the keyboard to the currently highlighted application and control.
        /// </summary>
        /// <param name="text">The supplied text to be parsed and sent.</param>
        void SendText(string text);

        /// <summary>
        /// Sends raw text with no parsing to the currently highlighted application and control.
        /// </summary>
        /// <param name="text">The text to send.</param>
        void SendRawText(string text);

    }
}

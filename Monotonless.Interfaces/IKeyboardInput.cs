namespace Monotonless.Interfaces
{
    /// <summary>
    /// An input to be sent from the keyboard robot.
    /// </summary>
    public interface IKeyboardInput
    {
        /// <summary>
        /// The value of the input to be sent.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Sends the value of the input.
        /// </summary>
        void Send();
    }
}

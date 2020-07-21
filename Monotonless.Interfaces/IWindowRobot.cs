namespace Monotonless.Interfaces
{
    /// <summary>
    /// Robot for running simple window processes.
    /// </summary>
    public interface IWindowRobot
    {
        /// <summary>
        /// Brings up the window by the supplied title.
        /// </summary>
        /// <param name="title">The supplied window title.</param>
        void SetForegroundWindow(string title);
    }
}

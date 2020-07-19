namespace Monotonless.Interfaces
{
    /// <summary>
    /// A part of the the user interface actions could be taken on.
    /// </summary>
    public interface IInteractable
    {
        /// <summary>
        /// Hovers the mouse to the location of the interactable.
        /// </summary>
        void Hover();

        /// <summary>
        /// Left clicks on the interactable.
        /// </summary>
        void LeftClick();

        /// <summary>
        /// Right clicks on the interactable.
        /// </summary>
        void RightClick();

        /// <summary>
        /// Double clicks on the iteractable.
        /// </summary>
        void DoubleClick();

        /// <summary>
        /// Left clicks on the interactable and sends parsed text to the location.
        /// </summary>
        /// <param name="text">The text to be parsed.</param>
        void SendText(string text);

        /// <summary>
        /// Left clicks on the interactable and sends raw text to the location.
        /// </summary>
        /// <param name="text">The text to be sent.</param>
        void SendRawText(string text);

        /// <summary>
        /// Waits until the interactable disappears from the screen, or until the supplied timeout
        /// is finished. Whichever is first.
        /// </summary>
        /// <param name="millisecondTimeout">The supplied timeout in milliseconds.</param>
        /// <returns>Whether the interactable disappeared before the timeout or not.</returns>
        bool WaitUntilDisappear(int millisecondTimeout);

        /// <summary>
        /// Waits until the interactable shows up on the screen, or until the supplied timeout
        /// is finished. Whichever is first.
        /// </summary>
        /// <param name="millisecondTimeout">The supplied timeout in milliseconds.</param>
        /// <returns>Whether the interactable shows on screen before the timeout or not.</returns>
        bool WaitUntilShowing(int millisecondTimeout);

        /// <summary>
        /// Left clicks the interactable and holds down the left click until it moves to the location
        /// supplied and then lets go of left click.
        /// </summary>
        /// <param name="destinationX">The X destination coordinate.</param>
        /// <param name="destinationy">The Y destination coordinate.</param>
        void DragToLocation(int destinationX, int destinationy);

        /// <summary>
        /// Left clicks the interactable and holds down the left click until it moves to the 
        /// supplied interactable's location and then lets go of left click.
        /// </summary>
        /// <param name="interactable">The supplied interactable.</param>
        void DragToLocation(IInteractable interactable);
    }
}

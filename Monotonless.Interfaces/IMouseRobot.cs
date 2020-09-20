namespace Monotonless.Interfaces
{
    /// <summary>
    /// The robot that makes mouse actions.
    /// </summary>
    public interface IMouseRobot
    {
        /// <summary>
        /// Gets the current X-Y coordinate of the mouse.
        /// </summary>
        /// <returns>An instance of <seealso cref="ScreenCoordinate"/></returns>
        ScreenCoordinate GetScreenCoordinate();

        /// <summary>
        /// Moves the cursor to the specified X-Y coordinate.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        void SetCursorPosition(int X, int Y);

        /// <summary>
        /// Moves the cursor to the specified location by the <see cref="ScreenCoordinate"/>
        /// </summary>
        /// <param name="screenCoordinate">The supplied position on screen.</param>
        void SetCursorPosition(ScreenCoordinate screenCoordinate);

        /// <summary>
        /// Left clicks at the current location. 
        /// </summary>
        void LeftClick();

        /// <summary>
        /// Left clicks at the supplied location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate</param>
        void LeftClick(int X, int Y);

        /// <summary>
        /// Left clicks at the supplied location.
        /// </summary>
        /// <param name="screenCoordinate">The supplied location.</param>
        void LeftClick(ScreenCoordinate screenCoordinate);

        /// <summary>
        /// Double clicks at the current location.
        /// </summary>
        void DoubleClick();

        /// <summary>
        /// Double clicks at the supplied location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        void DoubleClick(int X, int Y);

        /// <summary>
        /// Double clicks at the supplied location.
        /// </summary>
        /// <param name="screenCoordinate">The supplied location.</param>
        void DoubleClick(ScreenCoordinate screenCoordinate);

        /// <summary>
        /// Right clicks at the current location.
        /// </summary>
        void RightClick();

        /// <summary>
        /// Right clicks at the supplied location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        void RightClick(int X, int Y);

        /// <summary>
        /// Right clicks at the supplied location.
        /// </summary>
        /// <param name="screenCoordinate">The supplied location.</param>
        void RightClick(ScreenCoordinate screenCoordinate);

        /// <summary>
        /// Middle clicks at the current location.
        /// </summary>
        void MiddleClick();

        /// <summary>
        /// Middle clicks at the supplied location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        void MiddleClick(int X, int Y);

        /// <summary>
        /// Middle clicks at the supplied location.
        /// </summary>
        /// <param name="screenCoordinate">The supplied location.</param>
        void MiddleClick(ScreenCoordinate screenCoordinate);

        /// <summary>
        /// Left clicks at the first location, holds the button down, and moves to the second location where it lets go of the left click button.
        /// </summary>
        /// <param name="startX">The start X coordinate.</param>
        /// <param name="startY">The start Y coordinate.</param>
        /// <param name="endX">The end X coordinate.</param>
        /// <param name="endY">The end Y coordinate.</param>
        void DragAndDrop(int startX, int startY, int endX, int endY);

        /// <summary>
        /// Left clicks at the first location, holds the button down, and moves to the second location where it lets go of the left click button.
        /// </summary>
        /// <param name="start">The start location.</param>
        /// <param name="end">The end location.</param>
        void DragAndDrop(ScreenCoordinate start, ScreenCoordinate end);

    }
}

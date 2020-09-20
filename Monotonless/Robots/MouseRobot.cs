using Monotonless.Interfaces;
using System;
using System.Runtime.InteropServices;

namespace Monotonless.Robots
{
    /// <summary>
    /// The robot that is used to control mouse actions.
    /// </summary>
    public class MouseRobot : IMouseRobot
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out ScreenCoordinate lpMousePoint);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const int MOUSEEVENTF_MIDDLEUP = 0x40;

        /// <summary>
        /// Double clicks at the current location.
        /// </summary>
        public void DoubleClick()
        {
            var point = GetScreenCoordinate();
            MouseEventLeftClick(point.X, point.Y);
            MouseEventLeftClick(point.X, point.Y);
        }

        /// <summary>
        /// Double clicks at the supplied location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        public void DoubleClick(int X, int Y)
        {
            SetCursorPos(X, Y);
            MouseEventLeftClick(X, Y);
            MouseEventLeftClick(X, Y);
        }

        /// <summary>
        /// Double clicks at the supplied location.
        /// </summary>
        /// <param name="screenCoordinate">The supplied location.</param>
        public void DoubleClick(ScreenCoordinate screenCoordinate)
        {
            SetCursorPos(screenCoordinate.X, screenCoordinate.Y);
            MouseEventLeftClick(screenCoordinate.X, screenCoordinate.Y);
            MouseEventLeftClick(screenCoordinate.X, screenCoordinate.Y);
        }

        /// <summary>
        /// Left clicks at the start location to highlight, left clicks again and holds the button down, moves to the end location and lets go of the left click.
        /// </summary>
        /// <param name="startX">The start X coordinate.</param>
        /// <param name="startY">The start Y coordinate.</param>
        /// <param name="endX">The end X coordinate.</param>
        /// <param name="endY">The end Y coordinate.</param>
        public void DragAndDrop(int startX, int startY, int endX, int endY)
        {
            // Highlights the item to drag and drop.
            LeftClick(startX, startY);

            var highlightWaitTime = DateTime.Now;
            while (DateTime.Now.Subtract(highlightWaitTime).TotalMilliseconds < 500) { }

            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)startX, (uint)startY, 0, 0);
            SetCursorPos(endX, endY);

            var moveWaitTime = DateTime.Now;
            while (DateTime.Now.Subtract(moveWaitTime).TotalMilliseconds < 500) { }

            mouse_event(MOUSEEVENTF_LEFTUP, (uint)endX, (uint)endY, 0, 0);
        }

        /// <summary>
        /// Left clicks at the start location to highlight, left clicks again and holds the button down, moves to the end location and lets go of the left click.
        /// </summary>
        /// <param name="start">The start location.</param>
        /// <param name="end">The end location.</param>
        public void DragAndDrop(ScreenCoordinate start, ScreenCoordinate end)
        {
            // Highlights the item to drag and drop.
            LeftClick(start);

            var highlightWaitTime = DateTime.Now;
            while (DateTime.Now.Subtract(highlightWaitTime).TotalMilliseconds < 500) { }

            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)start.X, (uint)start.Y, 0, 0);
            SetCursorPos(end.X, end.Y);

            var moveWaitTime = DateTime.Now;
            while (DateTime.Now.Subtract(moveWaitTime).TotalMilliseconds < 500) { }

            mouse_event(MOUSEEVENTF_LEFTUP, (uint)end.X, (uint)end.Y, 0, 0);
        }

        /// <summary>
        /// Gets a <see cref="ScreenCoordinate"/> to signify the current location of the cursor.
        /// </summary>
        /// <returns>A <see cref="ScreenCoordinate"/> with the current location.</returns>
        public ScreenCoordinate GetScreenCoordinate()
        {
            var foundLocation = GetCursorPos(out ScreenCoordinate currentMouseLocation);
            if (!foundLocation) { currentMouseLocation = new ScreenCoordinate(0, 0); }
            return currentMouseLocation;
        }

        /// <summary>
        /// Left clicks at the current location
        /// </summary>
        public void LeftClick()
        {
            var currentLocation = GetScreenCoordinate();
            MouseEventLeftClick(currentLocation.X, currentLocation.Y);
        }

        /// <summary>
        /// Left clicks at the supplied location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        public void LeftClick(int X, int Y)
        {
            SetCursorPos(X, Y);
            MouseEventLeftClick(X, Y);
        }

        /// <summary>
        /// Left clicks at the supplied location.
        /// </summary>
        /// <param name="screenCoordinate">The specified location.</param>
        public void LeftClick(ScreenCoordinate screenCoordinate)
        {
            SetCursorPos(screenCoordinate.X, screenCoordinate.Y);
            MouseEventLeftClick(screenCoordinate.X, screenCoordinate.Y);
        }

        /// <summary>
        /// Middle clicks at the current location.
        /// </summary>
        public void MiddleClick()
        {
            var currentLocation = GetScreenCoordinate();
            MouseEventMiddleClick(currentLocation.X, currentLocation.Y);
        }

        /// <summary>
        /// Middle clicks at the supplied location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        public void MiddleClick(int X, int Y)
        {
            SetCursorPos(X, Y);
            MouseEventMiddleClick(X, Y);
        }

        /// <summary>
        /// Middle clicks at the supplied location.
        /// </summary>
        /// <param name="screenCoordinate">The supplied location.</param>
        public void MiddleClick(ScreenCoordinate screenCoordinate)
        {
            SetCursorPos(screenCoordinate.X, screenCoordinate.Y);
            MouseEventMiddleClick(screenCoordinate.X, screenCoordinate.Y);
        }

        /// <summary>
        /// Right clicks at the current location.
        /// </summary>
        public void RightClick()
        {
            var currentLocation = GetScreenCoordinate();
            MouseEventRightClick(currentLocation.X, currentLocation.Y);
        }

        /// <summary>
        /// Right clicks at the supplied location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        public void RightClick(int X, int Y)
        {
            SetCursorPos(X, Y);
            MouseEventRightClick(X, Y);
        }

        /// <summary>
        /// Right clicks at the supplied location.
        /// </summary>
        /// <param name="screenCoordinate">The supplied location.</param>
        public void RightClick(ScreenCoordinate screenCoordinate)
        {
            SetCursorPos(screenCoordinate.X, screenCoordinate.Y);
            MouseEventRightClick(screenCoordinate.X, screenCoordinate.Y);
        }

        /// <summary>
        /// Moves the cursor to the supplied location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        public void SetCursorPosition(int X, int Y)
        {
            SetCursorPos(X, Y);
        }

        /// <summary>
        /// Moves the cursor to the supplied location.
        /// </summary>
        /// <param name="screenCoordinate">The supplied location.</param>
        public void SetCursorPosition(ScreenCoordinate screenCoordinate)
        {
            SetCursorPos(screenCoordinate.X, screenCoordinate.Y);
        }

        private void MouseEventLeftClick(int x, int y)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
        }

        private void MouseEventRightClick(int x, int y)
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)x, (uint)y, 0, 0);
        }

        private void MouseEventMiddleClick(int x, int y)
        {
            mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, (uint)x, (uint)y, 0, 0);
        }
    }
}

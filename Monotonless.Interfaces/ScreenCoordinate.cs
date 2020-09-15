using System.Runtime.InteropServices;

namespace Monotonless.Interfaces
{
    /// <summary>
    /// An interface for a position on the screen.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ScreenCoordinate
    {
        /// <summary>
        /// The X coordinate of this position on screen.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// The Y coordinate of this position on screen.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Sets up the screen coordinate with the supplied X and Y coordinates.
        /// </summary>
        /// <param name="x">The supplied X coordinate.</param>
        /// <param name="y">The supplied Y coordinate.</param>
        public ScreenCoordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

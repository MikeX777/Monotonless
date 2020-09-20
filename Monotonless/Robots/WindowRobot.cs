using Monotonless.Interfaces;
using System;
using System.Runtime.InteropServices;

namespace Monotonless.Robots
{
    /// <summary>
    /// The robot that is used to control actions that have to do with windows.
    /// </summary>
    public class WindowRobot : IWindowRobot
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// Sets the foreground window based on the title of the window supplied.
        /// </summary>
        /// <param name="title">The supplied title of the window.</param>
        public void SetForegroundWindow(string title)
        {
            var window = FindWindow(null, title);
            SetForegroundWindow(window);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Monotonless.Interfaces
{
    /// <summary>
    /// The main enterence point for the program. Is used to automate actions that can take place on the computer.
    /// </summary>
    interface IAutomator
    {
        /// <summary>
        /// Searches for the provided image on the screen and will double click if it finds it.
        /// </summary>
        /// <param name="resourcePath">The path to the image.</param>
        void DoubleClickImage(string resourcePath);

        /// <summary>
        /// Searches for the image provided and creates a class that can be used for that resource.
        /// </summary>
        /// <param name="resourcePath">The path to the image.</param>
        /// <returns>A class for that resource with multiple methods on it.</returns>
        IActionPoint GetActionPoint(string resourcePath);

        /// <summary>
        /// Moves the mouse to a specified X and Y location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        void Hover(int X, int Y);

        /// <summary>
        /// Searches the screen for the supplied resource and moves the mouse to the center of that location.
        /// </summary>
        /// <param name="resourcePath">The supplied image path.</param>
        void Hover(string resourcePath);

        /// <summary>
        /// Left clicks a specified X and Y location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        void LeftClick(int X, int Y);

        /// <summary>
        /// Searches the screen for the supplied resource and left clicks the center of that location.
        /// </summary>
        /// <param name="resourcePath">The supplied image path.</param>
        void LeftClick(string resourcePath);

        /// <summary>
        /// Right clicks a specified X and Y location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        void RightClick(int X, int Y);

        /// <summary>
        /// Searches the screen for the supplied resource and right clicks the center of that location.
        /// </summary>
        /// <param name="resourcePath">The supplied image path.</param>
        void RightClick(string resourcePath);

        /// <summary>
        /// Double clicks a specified X and Y location.
        /// </summary>
        /// <param name="X">The supplied X coordinate.</param>
        /// <param name="Y">The supplied Y coordinate.</param>
        void DoubleClick(int X, int Y);

        /// <summary>
        /// Searches the screen for the supplied resource and double clicks the center of that location.
        /// </summary>
        /// <param name="resourcePath">The supplied image path.</param>
        void DoubleClick(string resourcePath);

        /// <summary>
        /// Uses the keyboard to send text with no Automator specific encoding.
        /// </summary>
        /// <param name="text">The text to be sent.</param>
        void SendRawText(string text);

        /// <summary>
        /// Uses the keyboard to send text with Automator specific encoding.
        /// </summary>
        /// <param name="text">The text to be sent.</param>
        void SendText(string text);

        /// <summary>
        /// Finds window by supplied title and brings that window to the foreground.
        /// </summary>
        /// <param name="title">The supplied window title.</param>
        void SetForegroundWindow(string title);

        /// <summary>
        /// Searches for the resource supplied and if found will make a <paramref name="actionPoint"/> for it to be used.
        /// </summary>
        /// <param name="actionPoint">The out paramter class of the resource found..</param>
        /// <param name="resourcePath">The supplied image path.</param>
        /// <returns>Whether or not it was able to find the supplied image path.</returns>
        bool TryGetActionPoint(out IActionPoint actionPoint, string resourcePath);

        /// <summary>
        /// Searches the screen for the supplied image resource. Will wait until it does not see it on the screen, or if the supplied timeout has been exceeded.
        /// Outputs a class <paramref name="actionPoint"/> based on the location of the found resource.
        /// </summary>
        /// <param name="actionPoint">A class generated at the location of the found resource.</param>
        /// <param name="resourcePath">The supplied path to the image.</param>
        /// <param name="millisecondTimeout">A timeout that will end the method if the image is still on screen.</param>
        /// <returns>Whether or not it was able to find the image, and if the image disappered by the end of the timeout.</returns>
        bool WaitUntilDisappear(out IActionPoint actionPoint, string resourcePath, int millisecondTimeout);

        /// <summary>
        /// Searches the screen for the supplied image resource. Will wait until it does not see it on the screen, or if the supplied timeout has been exceeded.
        /// </summary>
        /// <param name="resoucePath">The supplied path to the image.</param>
        /// <param name="millisecondTimeout">A timeout that will end the method if the image is still on screen.</param>
        /// <returns>Whether or not it was able to find the image, and if the image disappered by the end of the timeout.</returns>
        bool WaitUntilDisappear(string resoucePath, int millisecondTimeout);

        /// <summary>
        /// Searches the screen for a supplied resource and will continue to do so until it finds that resource, or the timeout has been passed. Once found,
        /// creates a class <paramref name="actionPoint"/> that can be used for other methods.
        /// </summary>
        /// <param name="actionPoint">The out parameter that can be used to call methods on the found resource.</param>
        /// <param name="resourcePath">The supplied image path.</param>
        /// <param name="millisecondTimeout">A timeout that is used to determine when the search is finished.</param>
        /// <returns>Whether or not it was able to find the resource by the end of the timeout.</returns>
        bool WaitUntilShowing(out IActionPoint actionPoint, string resourcePath, int millisecondTimeout);

        /// <summary>
        /// Searches the screen for a supplied resource and will continue to do so until it finds that resource, or the timeout has been passed.
        /// </summary>
        /// <param name="resoucePath">The supplied image path.</param>
        /// <param name="millisecondTimeout">>A timeout that is used to determine when the search is finished.</param>
        /// <returns>Whether or not it was able to find the resource by the end of the timeout.</returns>
        bool WaitUntilShowing(string resoucePath, int millisecondTimeout);

        /// <summary>
        /// Left clicks at the first location specified holds that, and then moves to the second location and let's go of left click.
        /// </summary>
        /// <param name="X1">The X coordinate of the start location.</param>
        /// <param name="Y1">The Y coordinate of the start location.</param>
        /// <param name="X2">The X coordinate of the end location.</param>
        /// <param name="Y2">The Y coordinate of the end location.</param>
        void DragAndDrop(int X1, int Y1, int X2, int Y2);

        /// <summary>
        /// Left clicks at the first <paramref name="startActionPoint"/>, holds left click down until it moves to the second <paramref name="endActionPoint"/>
        /// where it let's go of left click.
        /// </summary>
        /// <param name="startActionPoint">The starting left click location.</param>
        /// <param name="endActionPoint">The ending left click location.</param>
        void DragAndDrop(IActionPoint startActionPoint, IActionPoint endActionPoint);

        /// <summary>
        /// Right clicks at the first location specified holds that, and then moves to the second location and let's go of right click.
        /// </summary>
        /// <param name="X1">The X coordinate of the start location.</param>
        /// <param name="Y1">The Y coordinate of the start location.</param>
        /// <param name="X2">The X coordinate of the end location.</param>
        /// <param name="Y2">The y coordinate of the end location.</param>
        void RightClickDragAndDrop(int X1, int Y1, int X2, int Y2);

        /// <summary>
        /// right clicks at the first <paramref name="startActionPoint"/>, holds right click down until it moves to the second <paramref name="endActionPoint"/>
        /// where it let's go of right click.
        /// </summary>
        /// <param name="startActionPoint">The starting right click location.</param>
        /// <param name="endActionPoint">The ending right click location.</param>
        void RightClickDragAndDrop(IActionPoint startActionPoint, IActionPoint endActionPoint);

        /// <summary>
        /// Holds down the control button as it lefts clicks all the <paramref name="actionPoints"/>.
        /// </summary>
        /// <param name="actionPoints">The points to control click.</param>
        void ControlSelect(IEnumerable<IActionPoint> actionPoints);

        /// <summary>
        /// Holds down the shift key as it left clicks the first location <paramref name="start"/> and then left clicks the end location <paramref name="end"/>.
        /// </summary>
        /// <param name="start">The start location.</param>
        /// <param name="end">The end location.</param>
        void ShiftSelect(IActionPoint start, IActionPoint end);
    }
}

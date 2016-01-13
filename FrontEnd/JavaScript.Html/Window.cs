using System;
using JavaScript.Html.DOM;

namespace JavaScript.Html
{
    [RenameClass("")]
    public class Window
    {
        [RenameMember("window")]
        public readonly static Window WindowInstance;

        public readonly static Document Document;

        /// <summary>
        /// Returns a Boolean value indicating whether a window has been closed or not
        /// </summary>
        public readonly bool Closed;

        /// <summary>
        /// Sets or returns the default text in the statusbar of a window
        /// </summary>
        public string DefaultStatus;


        /// <summary>
        /// Returns the History object for the window
        /// </summary>
        public readonly History History;

        /// <summary>
        /// Sets or returns the inner height of a window's content area
        /// </summary>
        public uint InnerHeight;

        /// <summary>
        /// Sets or returns the inner width of a window's content area
        /// </summary>
        public uint InnerWidth;

        /// <summary>
        /// Returns the Location object for the window
        /// </summary>
        public readonly Location Location;

        /// <summary>
        /// Sets or returns the name of a window
        /// </summary>
        public string Name;

        /// <summary>
        /// Returns the Navigator object for the window
        /// </summary>
        public readonly Navigator Navigator;

        /// <summary>
        /// Returns a reference to the window that created the window
        /// </summary>
        public readonly Window Opener;

        /// <summary>
        /// Sets or returns the outer height of a window, including toolbars/scrollbars
        /// </summary>
        public uint OuterHeight;

        /// <summary>
        /// Sets or returns the outer width of a window, including toolbars/scrollbars
        /// </summary>
        public uint OuterWidth;

        /// <summary>
        /// Returns the pixels the current document has been scrolled (horizontally) from the upper left corner of the window
        /// </summary>
        public uint PageXOffset;

        /// <summary>
        /// Returns the pixels the current document has been scrolled (vertically) from the upper left corner of the window
        /// </summary>
        public int PageYOffset;

        /// <summary>
        /// Returns the parent window of the current window
        /// </summary>
        public readonly Window Parent;

        /// <summary>
        /// Returns the Screen object for the window
        /// </summary>
        public readonly Screen Screen;

        /// <summary>
        /// Returns the x coordinate of the window relative to the screen
        /// </summary>
        public readonly int ScreenLeft;

        /// <summary>
        /// Returns the y coordinate of the window relative to the screen
        /// </summary>
        public readonly int ScreenTop;

        /// <summary>
        /// Returns the x coordinate of the window relative to the screen
        /// </summary>
        public readonly int ScreenX;

        /// <summary>
        /// Returns the y coordinate of the window relative to the screen
        /// </summary>
        public readonly int ScreenY;

        /// <summary>
        /// Returns the current window
        /// </summary>
        public readonly Window Self;

        /// <summary>
        /// Sets the text in the statusbar of a window
        /// </summary>
        public string Status;

        /// <summary>
        /// Closes the current window
        /// </summary>
        public void Close()
        {
        }

        /// <summary>
        /// Sets focus to the current window
        /// </summary>
        public void Focus()
        {
        }

        /// <summary>
        /// Moves a window relative to its current position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void MoveBy(int x, int y)
        {
        }

        /// <summary>
        /// Moves a window to the specified position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void MoveTo(int x, int y)
        {
        }

        /// <summary>
        /// Prints the content of the current window
        /// </summary>
        public void Print()
        {
        }

        /// <summary>
        /// Resizes the window by the specified pixels
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void ResizeBy(int width, int height)
        {
        }

        /// <summary>
        /// Resizes the window to the specified width and height
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void ResizeTo(uint width, int height)
        {
        }

        /// <summary>
        /// Scrolls the content by the specified number of pixels
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void ScrollBy(int x, int y)
        {
        }

        /// <summary>
        /// Scrolls the content to the specified coordinates
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void ScrollTo(int x, int y)
        {
        }



        /// <summary>
        /// Returns the topmost browser window
        /// </summary>
        public static Window Top;

        /// <summary>
        /// Displays an alert box with a message and an OK button
        /// </summary>
        public static void Alert(string msg)
        {
        }

        /// <summary>
        /// Displays a dialog box with a message and an OK and a Cancel button
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool Confirm(string msg)
        {
            return false;
        }

        /// <summary>
        /// Displays a dialog box that prompts the visitor for input
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="defaultText"></param>
        /// <returns></returns>
        public static string Prompt(string msg, string defaultText = "")
        {
            return null;
        }

        /// <summary>
        /// 	Clears a timer set with setInterval()
        /// </summary>
        /// <param name="id"></param>
        public static void ClearInterval(int id)
        {
        }

        /// <summary>
        /// Clears a timer set with setTimeout()
        /// </summary>
        /// <param name="id"></param>
        public static void ClearTimeout(int id)
        {
        }

        /// <summary>
        /// Calls a function or evaluates an expression at specified intervals (in milliseconds)
        /// </summary>
        /// <param name="code"></param>
        /// <param name="millisec"></param>
        /// <returns></returns>
        public static int SetInterval(string code, uint millisec)
        {
            return 0;
        }

        /// <summary>
        /// Calls a function or evaluates an expression at specified intervals (in milliseconds)
        /// </summary>
        /// <param name="code"></param>
        /// <param name="millisec"></param>
        /// <returns></returns>
        public static int SetInterval(Delegate func, uint millisec)
        {
            return 0;
        }

        /// <summary>
        /// Calls a function or evaluates an expression after a specified number of milliseconds
        /// </summary>
        /// <returns></returns>
        public static int SetTimeout(string code, uint millisec)
        {
            return 0;
        }

        /// <summary>
        /// Calls a function or evaluates an expression after a specified number of milliseconds
        /// </summary>
        /// <param name="func"></param>
        /// <param name="millisec"></param>
        /// <returns></returns>
        public static int SetTimeout(Delegate func, uint millisec)
        {
            return 0;
        }

        /// <summary>
        /// Opens a new browser window
        /// </summary>
        /// <param name="url">Optional. Specifies the URL of the page to open. If no URL is specified, a new window with about:blank is opened</param>
        /// <param name="name">Optional. Specifies the target attribute or the name of the window. The following values are supported:
        /// _blank - URL is loaded into a new window. This is default
        /// _parent - URL is loaded into the parent frame
        /// _self - URL replaces the current page
        /// _top - URL replaces any framesets that may be loaded
        /// name - The name of the window
        /// </param>
        /// <param name="specs">Optional. A comma-separated list of items. The following values are supported:
        /// channelmode=yes|no|1|0	Whether or not to display the window in theater mode. Default is no. IE only
        /// directories=yes|no|1|0	Whether or not to add directory buttons. Default is yes. IE only
        /// fullscreen=yes|no|1|0	Whether or not to display the browser in full-screen mode. Default is no. A window in full-screen mode must also be in theater mode. IE only
        /// height=pixels	The height of the window. Min. value is 100
        /// left=pixels	The left position of the window
        /// location=yes|no|1|0	Whether or not to display the address field. Default is yes
        /// menubar=yes|no|1|0	Whether or not to display the menu bar. Default is yes
        /// resizable=yes|no|1|0	Whether or not the window is resizable. Default is yes
        /// scrollbars=yes|no|1|0	Whether or not to display scroll bars. Default is yes
        /// status=yes|no|1|0	Whether or not to add a status bar. Default is yes
        /// titlebar=yes|no|1|0	Whether or not to display the title bar. Ignored unless the calling application is an HTML Application or a trusted dialog box. Default is yes
        /// toolbar=yes|no|1|0	Whether or not to display the browser toolbar. Default is yes
        /// top=pixels	The top position of the window. IE only
        /// width=pixels	The width of the window. Min. value is 100
        /// </param>
        /// <param name="replace">Optional.Specifies whether the URL creates a new entry or replaces the current entry in the history list. The following values are supported:
        /// true - URL replaces the current document in the history list
        /// false - URL creates a new entry in the history list</param>
        /// <returns></returns>
        public static Window Open(string url, string name, string specs, bool replace)
        {
            return null;
        }

        /// <summary>
        /// Opens a new browser window
        /// </summary>
        /// <param name="url">Optional. Specifies the URL of the page to open. If no URL is specified, a new window with about:blank is opened</param>
        /// <param name="name">Optional. Specifies the target attribute or the name of the window. The following values are supported:
        /// _blank - URL is loaded into a new window. This is default
        /// _parent - URL is loaded into the parent frame
        /// _self - URL replaces the current page
        /// _top - URL replaces any framesets that may be loaded
        /// name - The name of the window
        /// </param>
        /// <param name="specs">Optional. A comma-separated list of items. The following values are supported:
        /// channelmode=yes|no|1|0	Whether or not to display the window in theater mode. Default is no. IE only
        /// directories=yes|no|1|0	Whether or not to add directory buttons. Default is yes. IE only
        /// fullscreen=yes|no|1|0	Whether or not to display the browser in full-screen mode. Default is no. A window in full-screen mode must also be in theater mode. IE only
        /// height=pixels	The height of the window. Min. value is 100
        /// left=pixels	The left position of the window
        /// location=yes|no|1|0	Whether or not to display the address field. Default is yes
        /// menubar=yes|no|1|0	Whether or not to display the menu bar. Default is yes
        /// resizable=yes|no|1|0	Whether or not the window is resizable. Default is yes
        /// scrollbars=yes|no|1|0	Whether or not to display scroll bars. Default is yes
        /// status=yes|no|1|0	Whether or not to add a status bar. Default is yes
        /// titlebar=yes|no|1|0	Whether or not to display the title bar. Ignored unless the calling application is an HTML Application or a trusted dialog box. Default is yes
        /// toolbar=yes|no|1|0	Whether or not to display the browser toolbar. Default is yes
        /// top=pixels	The top position of the window. IE only
        /// width=pixels	The width of the window. Min. value is 100
        /// </param>
        /// <returns></returns>
        public static Window Open(string url, string name, string specs)
        {
            return null;
        }

        /// <summary>
        /// Opens a new browser window
        /// </summary>
        /// <param name="url">Optional. Specifies the URL of the page to open. If no URL is specified, a new window with about:blank is opened</param>
        /// <param name="name">Optional. Specifies the target attribute or the name of the window. The following values are supported:
        /// _blank - URL is loaded into a new window. This is default
        /// _parent - URL is loaded into the parent frame
        /// _self - URL replaces the current page
        /// _top - URL replaces any framesets that may be loaded
        /// name - The name of the window
        /// </param>
        /// <returns></returns>
        public static Window Open(string url, string name)
        {
            return null;
        }

        /// <summary>
        /// Opens a new browser window
        /// </summary>
        /// <param name="url">Optional. Specifies the URL of the page to open. If no URL is specified, a new window with about:blank is opened</param>        
        /// <returns></returns>
        public static Window Open(string url)
        {
            return null;
        }

        /// <summary>
        /// Opens a new browser window
        /// </summary>
        /// <returns></returns>
        public static Window Open()
        {
            return null;
        }

        public readonly Storage LocalStorage;
        public readonly Storage SessionStorage;

        public static string Atob(string b64Text)
        {
            return null;
        }

        public static string Btoa(string text)
        {
            return null;
        }
    }
}

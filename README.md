![FlameSky](http://flamesky.weebly.com/uploads/1/4/5/8/14581514/editor/rounded-cornersflskynoshadow.png)

FlameSky is an open source browser based on the Sharp Browser project. It is written in C# WinForms on Visual Studio, and has FlameSky's edits to the existing Sharp Browser Project.
Released under the permissive MIT license.

## Features

- HTML5, CSS3, JS, HTML5 Video, WebGL 3D, etc
- Tabbed browsing
- Address bar (also opens Google)
- Back, Forward, Stop, Refresh
- Developer tools
- Search bar (also highlights all instances)
- Download manager
- Download Location Dialog (Asks where to download file)
- Popups
- Browsing History
- Quick launcher (For important, useful sites)
- Custom error pages
- Custom context menu
- Settings which allow customization of homepage, default search engine and has the option to not show splash screen at startup.
- Multiple tabs and Multiple windows
- Easily add vendor-specific branding, buttons or hotkeys
- View online & offline webpages
- Menu at the bottom left part of the page.

## Hotkeys

Hotkeys | Function
------------ | -------------
Ctrl+T		| Add a new tab
Ctrl+N		| Add a new window
Ctrl+W		| Close active tab
F5			| Refresh active tab
F12			| Open developer tools
Ctrl+Tab	| Switch to the next tab
Ctrl+Shift+Tab	| Switch to the previous tab
Ctrl+F		| Open search bar (Enter to find next, Esc to close)

## Code

- SharpBrowser uses CefSharp 51, NET Framework 4.5.2
- `MainForm.cs` - main web browser UI and related functionality
- `SplashScreen.cs` - splash screen which shows the logo, version number, name of the project.
- `Settings.cs` - web browser settings.
- `BrowserHistory.cs` - shows the browser history.
- `Handlers` - various handlers that we have registered with CefSharp that enable deeper integration between us and CefSharp
- `Data/JSON.cs` - fast JSON serializer/deserializer
- `bin` - Binaries are included in the `bin` folder due to the complex CefSharp setup required. Don't empty this folder.
- `bin/storage` - HTML and JS required for downloads manager and custom error pages

## Credits
- [Andrew Jose](https://github.com/andrewjoseofficial) - The FlameSky Open Source Project.
- [Robin Rodricks](https://github.com/robinrodricks) - SharpBrowser project.
- [Alex Maitland](https://github.com/amaitland) - CefSharp project, wrapper for CEF embeddable browser.
- [Ahmet Uzun](https://github.com/postacik) - Original browser project.

## Screenshots (To be uploaded. As of now these are the screenshots of SharpBrowser)

### Apple Homepage

![](https://github.com/sharpbrowser/SharpBrowser/raw/master/images/1.png)

### Google Maps

![](https://github.com/sharpbrowser/SharpBrowser/raw/master/images/2.png)

### Search Bar

![](https://github.com/sharpbrowser/SharpBrowser/raw/master/images/search.png)

### Downloads Tab

![](https://github.com/sharpbrowser/SharpBrowser/raw/master/images/3.png)

### Developer Tools

![](https://github.com/sharpbrowser/SharpBrowser/raw/master/images/4.png)

### Custom Error Pages

![](https://github.com/sharpbrowser/SharpBrowser/raw/master/images/error1.png)

![](https://github.com/sharpbrowser/SharpBrowser/raw/master/images/error2.png)


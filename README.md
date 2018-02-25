![FlameSky](http://flamesky.weebly.com/uploads/1/4/5/8/14581514/editor/rounded-cornersflskynoshadow.png)


# Flamesky (Web Browser)

Version in Progress: 5.0.0.0.1

The FlameSky web browser is developed by the contributors to FlameSky (those who commit code after FlameSky was forked from SharpBrowser) - The project's website is www.flamesky.weebly.com

The FlameSky project's goals are:
1. Create a browser that is advanced, and meets modern standards
2. Create a browser with a native anti porn feature (optional), and parental control feature 
3. Create a browser which will be have solutions to the needs other browsers do not meet. 
4. A browser that is well equipped with useful tools which will help users.
5. A browser which is user-centric.
6. A browser which will be useful and trustworthy that it can be confidently used by users as their main web browser.



FlameSky is maintained by Andrew Jose {who built FlameSky's earlier  proprietary versions (FlameSky 3.7 and below, and Cubicle Web Browser), before he made FlameSky open source)}

## Features

- HTML5, CSS3, JS, HTML5 Video, WebGL 3D, etc
- Flash (only with PPAI systemwwide installation of Flash)
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
- Drop Down Menu.
- Settings which allow customization of homepage, default search engine and has the option to not show splash screen at startup.
- Multiple tabs and Multiple windows
- View online & offline webpages
- PDF files supported
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

- FlameSky uses CefSharp 63, NET Framework 4.5.2
- `MainForm.cs` - main web browser UI and related functionality
- `SplashScreen.cs` - splash screen which shows the logo, version number, name of the project.
- `Settings.cs` - web browser settings.
- `BrowserHistory.cs` - shows the browser history.
- `Handlers` - various handlers that we have registered with CefSharp that enable deeper integration between us and CefSharp
- `Data/JSON.cs` - fast JSON serializer/deserializer
- `bin` - Binaries are included in the `bin` folder due to the complex CefSharp setup required. Don't empty this folder.
- `bin/storage` - HTML and JS required for downloads manager and custom error pages

## Credits
- Contributors to FlameSky
- [Andrew Jose](https://github.com/andrewjoseofficial) - Founding maintainer, who forked from SharpBrowser
- [Robin Rodricks](https://github.com/robinrodricks) - SharpBrowser project.
- [Alex Maitland](https://github.com/amaitland) - CefSharp project, wrapper for CEF embeddable browser.
- [Ahmet Uzun](https://github.com/postacik) - Original browser project.

## Maintainer, CEO and Founder
[Andrew Jose](https://github.com/andrewjoseofficial)



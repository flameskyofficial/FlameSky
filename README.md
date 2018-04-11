![FlameSky](http://flamesky.weebly.com/uploads/1/4/5/8/14581514/editor/rounded-cornersflskynoshadow.png)


# Flamesky (Web Browser)

Version in Progress: 5.0.0.1

Developer: [FlameSky Contributors](https://github.com/flameskyofficial/FlameSky/graphs/contributors)


The FlameSky web browser is developed by the contributors to FlameSky (those who commit code after FlameSky was forked from SharpBrowser) - The project's website is www.flamesky.weebly.com .    FlameSky capitalizes on the power of CefSharp and the simple UI of winforms to make a browser that is powerful, and loads fast. 



FlameSky is maintained by Andrew Jose {who built FlameSky's earlier  proprietary versions (FlameSky 3.7 and below, and Cubicle Web Browser), before he made FlameSky open source)}

# Who are contributors, and what is 'FlameSky Contributors'?
Because FlameSky is an open source project, it is built by volunteers who invest time in building the browser and exercising the skills (by contributing) simultaneously. Contributors include those listed in https://github.com/flameskyofficial/FlameSky/graphs/contributors . 

FlameSky Contributors is a collective identity for those who contribute. Due to the difficulty in accrediting everyone individual by individual, this collective identity is used

# What is the rendering Engine we use?
We use CefSharp a wrapper of the Chromium browser in Windows Forms

# What is the language FlameSky is mainly written in?
Winforms C#

# Why is SharpBrowser considered a 'FlameSky Contributor'?

Sharpbrowser, is considered a contributor, because this software was a fork of their software until FlameSky ended its relationship as a fork of SharpBrowser.


# What role does FlameSky Organization play?
FlameSky Organization is just the administrators of FlameSky. Andrew Jose, is the CEO of FlameSky (CEO is the admin). His job is to market this software as much as possible.

## Features

- HTML5, CSS3, JS, HTML5 Video, WebGL 3D, etc
- Flash (only with PPAI systemwwide installation of Flash)
- Tabbed browsing
- Address bar (also opens Google)
- Back, Forward, Stop, Refresh
- Auto Update 
- Developer tools
- Parental Controls (with password protection for settings and erasing history)
- Sticky notes
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
- `updater.xml` - This file in our GitHub helps to ensure that the Updater functions.

## Credits
- [FlameSky Contributors](https://github.com/flameskyofficial/FlameSky/graphs/contributors) - The volunteers who contributed code to this project
- [Andrew Jose](https://github.com/andrewjoseofficial) - Founding maintainer, who forked from SharpBrowser
- [Robin Rodricks](https://github.com/robinrodricks) - SharpBrowser project.
- [Alex Maitland](https://github.com/amaitland) - CefSharp project, wrapper for CEF embeddable browser.
- [Ahmet Uzun](https://github.com/postacik) - Original browser project.

## Maintainer, CEO and Founder
[Andrew Jose](https://github.com/andrewjoseofficial)



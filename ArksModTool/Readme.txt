==
=== Arks Mod Tool
=== Version 1.2n
==

A mod utility tool to provide various
client-side game adjustments for
Phantasy Star Online 2.

This project is strictly the work of a
fan and is not affiliated with Sega or
any other game development organization.

As a developer, I respect the rights
administered to Sega as both the developer
and publisher of the game and will cease
development on this project immediately
if requested to do so by an appropriate
authority.


                         ~Jason Lim

==
=== Usage
==

- Launch Arks Mod Tool and choose your
  preferred settings.

- Launch PSO2 and wait for the status
  indicator on the mod tool to read
  "Connected"

==
=== Dependencies
==

- Microsoft Visual C++ Redistributable 2013

- Microsoft .NET Framework 2014

==
=== Known Bugs
==

- Talking to the Extreme Quest Administrator
  NPC Pudding to manually obtain your daily
  Extreme Quest Pass with "Hide Screen
  Nofications" ticked will cause the game
  to soft lock.

- PSO2 appears to have a hard asset limit
  built into the game. If too many assets
  appear onscreen at once, some parts of
  ingame models may appear absent.

- Color adjustments will only be applied
  on graphics settings greater than 1.

==
=== Notes
==

- Usually, the mod tool must be running
  before launching PSO2. In these cases,
  the mod tool cannot connect to PSO2 while
  it is already running.

- If attempting to run the mod tool
  causes it to throw an error and close,
  it may be a compatibility issue with
  the Microsoft Visual C++ Redistributable
  or the Microsoft .NET Framework. Try
  redownloading those two and see if it
  helps.

- The option to disable far culling
  currently only disables first stage far
  culling. Game objects will still vanish
  after exceeding the second stage boundary
  approximately 2 map grid spaces away.
  Terrain will still show up properly
  beyond this boundary though.
  
- Similarly, occlusion culling is still
  enabled meaning objects and terrain may
  still pop in if the occluding volume of
  an object is larger than its visible
  geometry.

==
=== Version History
==

v1.2n:

- Retargeted for client version 4.0302.0

v1.2m:

- Retargeted for client version 4.0301.2

v1.2l:

- Retargeted for client version 4.0301.1

v1.2k:

- Retargeted for client version 4.0301.0

v1.2j:

- Retargeted for client version 4.0201.2

v1.2i:

- Retargeted for client version 4.0201.1
- Added options for controlling game
  color balance settings.
- Moved SharpDX dependencies into app as
  embedded resources.

v1.2h:

- Retargeted for client version 4.0102.0
- Re-added game adjustment to prevent the
  log window from being shown when a boss
  battle begins.
- Added minimize-to-tray and close-to-tray
  options for the app.

v1.2g:

- Retargeted for client version 4.0101.3

v1.2f:

- Retargeted for client version 4.0101.2

v1.2e:

- Retargeted for client version 4.0101.1

v1.2d:

- Retargeted for client version 4.0101.0
- Removed log window patch that prevents
  the log window from being hidden when
  viewing an EQ results screen.

v1.2c:

- Retargeted for client version 4.0001.3

v1.2b:

- Retargeted for client version 4.0001.2

v1.2a:

- Retargeted for client version 4.0001.1
- Added buttons for reverting camera settings
  to default values

v1.2:

- Retargeted for client version 4.0001.0
- Added settings for adjusting the ingame
  camera.
- Added a game adjustment to prevent the
  log window from being shown when a boss
  battle begins

v1.1f:

- Retargeted for client version 3.1002.0

v1.1e:

- Retargeted for client version 3.1000.2

v1.1d:

- Retargeted for client version 3.1001.1

v1.1c:

- Retargeted for client version 3.1001.0

v1.1b:

- Retargeted for client version 3.0902.1

v1.1a:

- Retargeted for client version 3.0902.0

v1.1:

- Retargeted for client version 3.0901.0
- Added option to toggle off screen-wide
  notificaitons.
- Added option to toggle off Emergency Code
  visuals.

v1.0c:

- Retargeted for anonymous 3.0801.1 update.
- Fixed bug in far culling patch that caused
  certain terrain objects to stop rendering.

v1.0b:

- Retargeted for client version 3.0801.1
- Added new app icon.
- Increased hotkey XInput polling rate.
- Increased pso2.exe scan rate.

v1.0:

- Initial Release

==
=== Credits
==

- Special thanks to pso-world.com user
  Gama for the awesome app icon.

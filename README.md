Hello there, welcome to my game, totally not replicated from Godot's [Your First 2D Game Tutorial](https://docs.godotengine.org/en/stable/getting_started/first_2d_game/index.html), Escape the Creeps. Now there is a choice to make when running the game. There are three ways of running the game. This folder contians the Godot executable that can be used to run the game, a directory of executables that were build from Godot, and all the necessary source files for you to build the game yourself.

# Running from Godot Executable
The easiest way to run the game is probably to use the Godot executable. All you have to do is run the "Godot_v4.3-stable_mono_\<your_system_type\>.exe" executable from the games's root folder (the one containing this file). This should immmediately launch the game in DEBUG mode.

# Running from Game Executables
The executables for this game are located in the folder ./bin/\<your_system_type\>. Hopefully they should run using whatever method you like running an executable the best. If not you can follow the directions bellow to build an executable for your system (hopefully).

# Building the Game Yourself

## Downloads
### Godot Engine
This folder also contains a few versions of Godot that should, hopefully, be able to run on your system. They can be found in the ./godot_editor/\<whatever describes your system best\> folder. You just need to make sure you have a .NET sdk installed too. To do so follow the instructions in the [.NET Section](#net-60425).

If you need to download the Godot Engine yourself, it can be downloaded from https://godotengine.org/. It is probably best to use the version of Godot that I created the game with, which was 4.3 (current version as of writting). Whatever version you download, you will need to download the .NET version so it has C# support. 

That is everything. The file downloaded should be a zip folder that when extracted gives the Godot executable that can be ran immediately, as long as a .NET SDK is installed (if one isn't refer to the [.NET Section](#net-60425)), so no installation necessary.

### .NET 6.0.425
Make sure you have a .NET SDK installed on your system. The easiest way to do this is to run the command: `dotnet --version`.

When creating the game I used the version 6.0.425 (lastest of major version 6 as of writing). I did not test other versions, as using major version 6 was recommened by Godot, and will not promise that using other versions will work.

If you need to download the SDK, it can be found here: https://dotnet.microsoft.com/en-us/download/dotnet/6.0

## Opening Game in Godot for the First Time
Run the Godot executable through your prefered method (through your file manager, terminal, or shortcut). Then click the import button. Then navigate to the game's folder and open it's project.godot file. Finally click the Import & Edit button. This should automajically open the game in Godot's editor and add the game to yor project library.

## Running
Once the game has been opened in Godot it can be run from there using the play button.

You can also do some more setup to build the game and run it fromm an executable, as explained in the next section, [Building](#building).

### Building
To build the game make sure it is open in the Godot editor. At the top click the "Project" group drop down, then the "Export..." option from the list. This will open the Export menu.

If you are building for the first time, the menu will probably complain that there aren't any Exprot Templates. The easiest way to deal with this is to click the Manage Export Templates link, and have it download and intstall them automatically. When building I downloaded from the "Best available mirror" and clicked the "Download and Install" button.

Once you are ready to export, in the export menu, add a preset using the "Add..." button, and select whichever system you want to target. Then I left the default options alone, and clicked the "Export Project..." button. Godot will ask were you want the executable to go, put it were ever. I usually create a ./bin/ folder. Then click save.

Finally you should have a runable executable! Go to were ever you decided to have Godot build the game, and run the executable in whatever way you prefer.

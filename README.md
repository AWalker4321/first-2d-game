Hello there, welcome to my game, totally not replicated from Godot's [Your First 2D Game Tutorial](https://docs.godotengine.org/en/stable/getting_started/first_2d_game/index.html), Escape the Creeps, with a few additions. Those being a Main Menu with a mute button. Now there is a choice to make when running the game. There are three ways of running the game. The easiest way is by locating the executable that aligns with your system's description the best and running that in whatever way you prefer (It is the executable plain executable file, not the console file or .sh file). The other two ways include downloading the Godot executable **with .NET support**, then either placing the executable in the game's root folder (the one that contains this file) or somewhere else. If you place the Godot executable in this game's root folder then it will automagically run the game when the executable is ran. If the Godot executable is placed elsewhere it will ask you to import the project then open it in the editor.


# Running from Game Executables
The executables for this game are located in the folder ./bin/\<the_path_that_describes_your_system_the_best\>. Hopefully they should run using whatever method you like running an executable the best. If not you can follow the directions bellow to build an executable for your system (hopefully) or just download the Godot executable **with .NET support** and it with that.

# Running from Godot Executable
To run the game using the Godot executable **with .NET support**, you will first need to follow the [downloading steps](#godot-engine). Once you have an executable downloaded, place it in this game's root directory and finally run it. Once ran it should immedately run the game.

# Building the Game Yourself

## Downloads
### Godot Engine
To download the Godot Engine yourself, go to [Godot's website](https://godotengine.org/). It is probably best to use the version of Godot that I created the game with, which was 4.3 (current version as of writting). Whatever version you download, you will need to download the .NET version so it has C# support. 

You will also need to make sure you have a .NET sdk installed. To do so follow the instructions in the [.NET Section](#net-60425).

That is everything. The file downloaded should be a zip folder that when extracted gives the Godot executable that can be ran immediately, as long as a .NET SDK is installed (if one isn't refer to the [.NET Section](#net-60425)), so no installation necessary.

### .NET 6.0.425
Make sure you have a .NET SDK installed on your system. The easiest way to do this is to run the command: `dotnet --version`.

When creating the game I used the version 6.0.425 (lastest of major version 6 as of writing). I did not test other versions, as using major version 6 was recommened by Godot, and I will not promise that using other versions will work.

If you need to download the SDK, it can be found here: https://dotnet.microsoft.com/en-us/download/dotnet/6.0

## Opening Game in Godot Editor for the First Time
Run the Godot executable through your prefered method (through your file manager, terminal, or shortcut). Then click the import button. Then navigate to the game's folder and open it's project.godot file. Finally click the Import & Edit button. This should automajically open the game in Godot's editor and add the game to yor project library.

## Running
Once the game has been opened in Godot it can be run from there using the play button.

You can also do some more setup to build the game and run it fromm an executable, as explained in the next section, [Building](#building).

### Building
To build the game make sure it is open in the Godot editor. At the top click the "Project" group drop down, then the "Export..." option from the list. This will open the Export menu.

If you are building for the first time, the menu will probably complain that there aren't any Exprot Templates. The easiest way to deal with this is to click the Manage Export Templates link, and have it download and intstall them automatically. When building I downloaded from the "Best available mirror" and clicked the "Download and Install" button.

Once you are ready to export, in the export menu, add a preset using the "Add..." button, and select whichever system you want to target. Then I left the default options alone, and clicked the "Export Project..." button. Godot will ask were you want the executable to go, put it were ever. I usually create a ./bin/ folder. Then click save.

Finally you should have a runable executable! Go to were ever you decided to have Godot build the game, and run the executable in whatever way you prefer.

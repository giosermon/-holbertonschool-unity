Project: Unity Assests UI
In this project we'll review how to work with Unity's assests UI elements.

General
What is an Asset and how to import and use them
How to import images to use in a user interface
What is a Sprite
How is a Sprite different from a Texture
How to use the Sprite Editor
What is 9-slicing
How to create a Slider
How to create a Toggle
How to swap button images
How to use PlayerPrefs and what are they used for

Requirements
General
A README.md file, at the root of the folder of the project
Use Unity’s default .gitignore in your holbertonschool-unity directory
Push the entire project folder 0x06-unity-assets_ui to your repo
Scenes and project assets such as Scripts must be organized as described in the tasks
In your scripts, all your public classes and their members should have XML documentation tags
In your scripts, all your private classes and members should be documented but without XML documentation tags



Task 0: Create two more Scenes in 0x06-unity-assets_ui. For each new scene, create a new path of platforms for the Player to navigate through.
Task 1: Download the Google font “Changa” and place in a Changa folder into a new folder called Fonts in the Assets folder (the final path should be Assets/Fonts/Changa/<.ttf files>). All text should use this font, so change TimerText‘s font as well.
Download these images into a folder called UI in the Textures folder. Set their Texture Type to Sprite (2D and UI).

Create a new Scene called MainMenu.

Task 2: Create a new Scene called Options.
Task 3: Create a new C# script called MainMenu.cs. In the MainMenu scene, script the level buttons scene so that choosing Level01, Level02, or Level03 loads the corresponding scene.
Task 4: Inside the Level01 Scene, create a new Canvas and using the image as a guide, create a pause screen.
Task 5: Create a new C# script called PauseMenu.cs. Add a method to this script so that when the player presses Esc while playing the game, the game should pause and the PauseCanvas should become active. The timer should also pause.
Task 6: In the PauseMenu and PauseMenu.cs, script the RestartButton so that it reloads the level scene that the player is currently on.
Task 7: n the CameraController.cs script, add the ability to invert the Y axis.
Create a public bool called isInverted.

Task 8: In Options and OptionsMenu.cs, script it so that checking the InvertYToggle in the menu and applying the changes reverses the camera/mouse movements in the level scene.
Task 9: In the Level01 Scene, create a new Canvas and using the image as a guide, create a win screen.
Task 10: Edit WinTrigger.cs so that when the player touches the flag, WinCanvas becomes active.
Task 11: Create three builds of all scenes above in the Builds directory.

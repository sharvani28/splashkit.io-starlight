using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window titled "Underwater Adventure" with dimensions 1000x800
OpenWindow("Underwater Adventure", 1000, 800);

// Clear the screen
ClearScreen();

// Load the underwater scene bitmap
Bitmap underwaterScene = new Bitmap("underwater_scene", "underwater_scene.jpg");

// Draw the underwater scene bitmap at coordinates (0, 0)
DrawBitmap(underwaterScene, 0, 0);

// Draw text labels for different elements of the scene
DrawText("Colourful Fish", Color.Red, "arial", 23, 140, 100);

// Draw triangles pointing at each element
DrawLine(Color.Red, 180, 120, 205, 155); // Arrow pointing at "Colourful fish"
FillTriangle(Color.Red, 185, 150, 210, 140, 210, 160); // Arrowhead

// Refresh the screen to display the changes
RefreshScreen();

// Pause for 5000 milliseconds (5 seconds) to observe the result
Delay(5000);

CloseAllWindows();


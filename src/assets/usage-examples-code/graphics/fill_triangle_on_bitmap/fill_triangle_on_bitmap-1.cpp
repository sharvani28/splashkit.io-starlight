#include "splashkit.h"

int main()
{
    // Open a window titled "Underwater Adventure" with dimensions 800x600
    open_window("Underwater Adventure", 1000, 800);

    clear_screen();

    // Load the underwater scene bitmap
    bitmap underwaterScene = load_bitmap("underwater_scene", "underwater_scene.jpg");


    // Draw the underwater scene bitmap at coordinates (0, 0)
    draw_bitmap(underwaterScene, 0, 0);

    // Draw text labels for different elements of the scene
    draw_text("Colourful Fish", COLOR_RED, "arial", 23, 140, 100);
    

    // Draw triangles pointing at each element
    draw_line(COLOR_RED, 180, 120, 205, 155); // Arrow pointing at "Colourful fish"
    fill_triangle(COLOR_RED, 185, 150, 210, 140, 210, 160); // Arrowhead

    // Refresh the screen to display the changes
    refresh_screen();
    
    // Pause for 5000 milliseconds (5 seconds) to observe the result
    delay(50000);
    
    return 0;
}
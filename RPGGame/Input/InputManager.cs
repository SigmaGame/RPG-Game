using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RPGGame;

public static class InputManager
{
    private static KeyboardState _keyboard, _oldKeyboard;
    private static MouseState _mouse, _oldMouse;

    /// <summary>
    /// Updates Input states.
    /// </summary>
    public static void Update()
    {
        _oldMouse = _mouse;
        _oldKeyboard = _keyboard;

        _mouse = Mouse.GetState();
        _keyboard = Keyboard.GetState();
    }

    /// <summary>
    /// Gets whether a key is held down.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns><c>true</c> if the key is pressed, <c>false</c> otherwise.</returns>
    public static bool GetKey(Keys key) => _keyboard.IsKeyDown(key);
    
    /// <summary>
    /// Gets whether a key is pressed for the current frame.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns><c>true</c> if the key is a new press, <c>false</c> otherwise.</returns>
    public static bool GetKeyPress(Keys key) => _keyboard.IsKeyDown(key) && _oldKeyboard.IsKeyUp(key);
    
    /// <summary>
    /// Gets whether a key is released for the current frame.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns><c>true</c> if the key is a new release, <c>false</c> otherwise.</returns>
    public static bool GetKeyRelease(Keys key) => _keyboard.IsKeyUp(key) && _oldKeyboard.IsKeyDown(key);

    /// <summary>
    /// Gets the current mouse position relative to the top-right corner of the window.
    /// </summary>
    /// <returns>The mouse's position.</returns>
    public static Point GetMouseAbsolute() => _mouse.Position;
    
    /// <summary>
    /// Gets how much the mouse has moved since the last frame.
    /// </summary>
    /// <returns>The mouse's movement changed relative to the last frame.</returns>
    public static Point GetMouseDelta() => _mouse.Position - _oldMouse.Position;
    
    /// <summary>
    /// Gets whether a mouse button is held down.
    /// </summary>
    /// <param name="button">The mouse button to check.</param>
    /// <returns><c>true</c> if the button is pressed, <c>false</c> otherwise.</returns>
    public static bool GetClick(MouseButtons button) => _mouse.IsButtonDown(button);
    
    /// <summary>
    /// Gets whether a mouse button is pressed for the current frame.
    /// </summary>
    /// <param name="button">The button to check.</param>
    /// <returns><c>true</c> if the button is a new press, <c>false</c> otherwise.</returns>
    public static bool GetClickPress(MouseButtons button) => _mouse.IsButtonDown(button) && _oldMouse.IsButtonUp(button);
    
    /// <summary>
    /// Gets whether a mouse button is released for the current frame.
    /// </summary>
    /// <param name="button">The button to check.</param>
    /// <returns><c>true</c> if the button is a new release, <c>false</c> otherwise.</returns>
    public static bool GetClickRelease(MouseButtons button) => _mouse.IsButtonUp(button) && _oldMouse.IsButtonDown(button);
}

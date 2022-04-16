
using UnityEngine;
using System;
[Serializable]
public class ControllerButton
{
    KeyCode joystickButtonCode;
    /// <summary>
    /// The first frame a button is pressed
    /// </summary>
    public bool IsPressed{ get; private set; }
    /// <summary>
    /// While a button is held down
    /// </summary>
    public bool IsHolding { get; private set; }
    /// <summary>
    /// The first frame after a button is let go
    /// </summary>
    public bool IsReleased { get; private set; }
    /// <summary>
    /// The button is currently not pressed
    /// </summary>
    public bool IsReady { get; private set; }

    public void Refresh()
    {
        if (Input.GetKeyDown(joystickButtonCode))
        {
            IsPressed = true;
            IsHolding = false;
            IsReleased = false;
            IsReady = false;
        }
        else if (Input.GetKey(joystickButtonCode))
        {
            IsPressed = false;
            IsHolding = true;
            IsReleased = false;
            IsReady = false;
        }
        else if (Input.GetKeyUp(joystickButtonCode))
        {
            IsPressed = false;
            IsHolding = false;
            IsReleased = true;
            IsReady = false;
        }
        else
        {
            IsPressed = false;
            IsHolding = false;
            IsReleased = false;
            IsReady = true;
        }
    }
    public ControllerButton(KeyCode joystickCode)
    {
        joystickButtonCode = joystickCode;
    }
}

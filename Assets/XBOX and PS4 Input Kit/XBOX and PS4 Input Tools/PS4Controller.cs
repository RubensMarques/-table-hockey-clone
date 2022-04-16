using UnityEngine;
using System;
[Serializable]

public class PS4Controller : Controller
{
    public ControllerButton Square { get; }
    public ControllerButton X { get; }
    public ControllerButton Circle { get; }
    public ControllerButton Triangle { get; }
    public ControllerButton L1 { get; }
    public ControllerButton R1 { get; }
    public ControllerButton L2 { get; }
    public ControllerButton R2 { get; }
    public ControllerButton Share { get; }
    public ControllerButton Options { get; }
    public ControllerButton LeftStickClick { get; }
    public ControllerButton RightStickClick { get; }
    public ControllerButton PSButton { get; }
    public ControllerButton TouchpadButton { get; }
    KeyCode[][] ps4KeyCodes;
    public PS4Controller(int index)
    {
        playerIndex = index;
        axisPlayerIndex = index + 1;

        ps4KeyCodes = new KeyCode[4][];
        ps4KeyCodes[0] = new KeyCode[] { KeyCode.Joystick1Button0, KeyCode.Joystick1Button1, KeyCode.Joystick1Button2, KeyCode.Joystick1Button3, KeyCode.Joystick1Button4, KeyCode.Joystick1Button5, KeyCode.Joystick1Button6, KeyCode.Joystick1Button7, KeyCode.Joystick1Button8, KeyCode.Joystick1Button9, KeyCode.Joystick1Button10, KeyCode.Joystick1Button11, KeyCode.Joystick1Button12, KeyCode.Joystick1Button13 };
        ps4KeyCodes[1] = new KeyCode[] { KeyCode.Joystick2Button0, KeyCode.Joystick2Button1, KeyCode.Joystick2Button2, KeyCode.Joystick2Button3, KeyCode.Joystick2Button4, KeyCode.Joystick2Button5, KeyCode.Joystick2Button6, KeyCode.Joystick2Button7, KeyCode.Joystick2Button8, KeyCode.Joystick2Button9, KeyCode.Joystick2Button10, KeyCode.Joystick2Button11, KeyCode.Joystick2Button12, KeyCode.Joystick2Button13 };
        ps4KeyCodes[2] = new KeyCode[] { KeyCode.Joystick3Button0, KeyCode.Joystick3Button1, KeyCode.Joystick3Button2, KeyCode.Joystick3Button3, KeyCode.Joystick3Button4, KeyCode.Joystick3Button5, KeyCode.Joystick3Button6, KeyCode.Joystick3Button7, KeyCode.Joystick3Button8, KeyCode.Joystick3Button9, KeyCode.Joystick3Button10, KeyCode.Joystick3Button11, KeyCode.Joystick3Button12, KeyCode.Joystick3Button13 };
        ps4KeyCodes[3] = new KeyCode[] { KeyCode.Joystick4Button0, KeyCode.Joystick4Button1, KeyCode.Joystick4Button2, KeyCode.Joystick4Button3, KeyCode.Joystick4Button4, KeyCode.Joystick4Button5, KeyCode.Joystick4Button6, KeyCode.Joystick4Button7, KeyCode.Joystick4Button8, KeyCode.Joystick4Button9, KeyCode.Joystick4Button10, KeyCode.Joystick4Button11, KeyCode.Joystick4Button12, KeyCode.Joystick4Button13 };
        buttons = new ControllerButton[14];
        for (int i = 0; i < buttons.Length; ++i)
        {
            buttons[i] = new ControllerButton(ps4KeyCodes[playerIndex][i]);
        }
        Square = buttons[0];
        X = buttons[1];
        Circle = buttons[2];
        Triangle = buttons[3];
        L1 = buttons[4];
        R1 = buttons[5];
        L2 = buttons[6];
        R2 = buttons[7];
        Share = buttons[8];
        Options = buttons[9];
        LeftStickClick = buttons[10];
        RightStickClick = buttons[11];
        PSButton = buttons[12];
        TouchpadButton = buttons[13];
        #region axisMapping
        axes = new int[8];
        axes[0] = 0;//lax
        axes[1] = 1;//lay
        axes[2] = 3;//rax
        axes[3] = 4;//ray
        axes[4] = 5;//akx
        axes[5] = 6;//aky
        axes[6] = 8;//l2a
        axes[7] = 9;//r2a
        #endregion axisMapping
    }
    int axisPlayerIndex;
    public void RefreshAxisValues() { 
        LeftAnalogX = Input.GetAxis("LeftAnalogX" + axisPlayerIndex);
        LeftAnalogY = (-1f * Input.GetAxis("LeftAnalogY" + axisPlayerIndex));
        RightAnalogX = Input.GetAxis("RightAnalogX" + axisPlayerIndex);
        RightAnalogY = (-1f * Input.GetAxis("RightAnalogY" + axisPlayerIndex));
        ArrowKeysX= Input.GetAxis("ArrowKeysX" + axisPlayerIndex);
        ArrowKeysY = Input.GetAxis("ArrowKeysY" + axisPlayerIndex);
        L2Axis = Input.GetAxis("L2Axis" + axisPlayerIndex);
        R2Axis = Input.GetAxis("R2Axis" + axisPlayerIndex);
    }
    public float LeftAnalogX { get; private set; }
    public float LeftAnalogY { get; private set; }
    public float RightAnalogX { get; private set; }
    public float RightAnalogY { get; private set; }
    public float ArrowKeysX { get; private set; }
    public float ArrowKeysY { get; private set; }
    public float L2Axis { get; private set; }
    public float R2Axis { get; private set; }
}
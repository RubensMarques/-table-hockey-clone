using UnityEngine;
using System;
[Serializable]
public class XboxController : Controller
{
    public ControllerButton A { get; }
    public ControllerButton B { get; }
    public ControllerButton X { get; }
    public ControllerButton Y { get; }
    public ControllerButton LeftBumper { get; }
    public ControllerButton RightBumper { get; }
    public ControllerButton LeftStickClick { get; }
    public ControllerButton RightStickClick { get; }
    public ControllerButton Back { get; }
    public ControllerButton Start { get; }

    KeyCode[][] xboxKeyCodes;
    public XboxController(int index)
    {
        playerIndex = index;
        axisPlayerIndex = index + 1;
        #region buttons
        xboxKeyCodes = new KeyCode[8][];
        xboxKeyCodes[0] = new KeyCode[] { KeyCode.Joystick1Button0, KeyCode.Joystick1Button1, KeyCode.Joystick1Button2, KeyCode.Joystick1Button3, KeyCode.Joystick1Button4, KeyCode.Joystick1Button5, KeyCode.Joystick1Button6, KeyCode.Joystick1Button7, KeyCode.Joystick1Button8, KeyCode.Joystick1Button9 };
        xboxKeyCodes[1] = new KeyCode[] { KeyCode.Joystick2Button0, KeyCode.Joystick2Button1, KeyCode.Joystick2Button2, KeyCode.Joystick2Button3, KeyCode.Joystick2Button4, KeyCode.Joystick2Button5, KeyCode.Joystick2Button6, KeyCode.Joystick2Button7, KeyCode.Joystick2Button8, KeyCode.Joystick2Button9 };
        xboxKeyCodes[2] = new KeyCode[] { KeyCode.Joystick3Button0, KeyCode.Joystick3Button1, KeyCode.Joystick3Button2, KeyCode.Joystick3Button3, KeyCode.Joystick3Button4, KeyCode.Joystick3Button5, KeyCode.Joystick3Button6, KeyCode.Joystick3Button7, KeyCode.Joystick3Button8, KeyCode.Joystick3Button9 };
        xboxKeyCodes[3] = new KeyCode[] { KeyCode.Joystick4Button0, KeyCode.Joystick4Button1, KeyCode.Joystick4Button2, KeyCode.Joystick4Button3, KeyCode.Joystick4Button4, KeyCode.Joystick4Button5, KeyCode.Joystick4Button6, KeyCode.Joystick4Button7, KeyCode.Joystick4Button8, KeyCode.Joystick4Button9 };
        xboxKeyCodes[4] = new KeyCode[] { KeyCode.Joystick5Button0, KeyCode.Joystick5Button1, KeyCode.Joystick5Button2, KeyCode.Joystick5Button3, KeyCode.Joystick5Button4, KeyCode.Joystick5Button5, KeyCode.Joystick5Button6, KeyCode.Joystick5Button7, KeyCode.Joystick5Button8, KeyCode.Joystick5Button9 };
        xboxKeyCodes[5] = new KeyCode[] { KeyCode.Joystick6Button0, KeyCode.Joystick6Button1, KeyCode.Joystick6Button2, KeyCode.Joystick6Button3, KeyCode.Joystick6Button4, KeyCode.Joystick6Button5, KeyCode.Joystick6Button6, KeyCode.Joystick6Button7, KeyCode.Joystick6Button8, KeyCode.Joystick6Button9 };
        xboxKeyCodes[6] = new KeyCode[] { KeyCode.Joystick7Button0, KeyCode.Joystick7Button1, KeyCode.Joystick7Button2, KeyCode.Joystick7Button3, KeyCode.Joystick7Button4, KeyCode.Joystick7Button5, KeyCode.Joystick7Button6, KeyCode.Joystick7Button7, KeyCode.Joystick7Button8, KeyCode.Joystick7Button9 };
        xboxKeyCodes[7] = new KeyCode[] { KeyCode.Joystick8Button0, KeyCode.Joystick8Button1, KeyCode.Joystick8Button2, KeyCode.Joystick8Button3, KeyCode.Joystick8Button4, KeyCode.Joystick8Button5, KeyCode.Joystick8Button6, KeyCode.Joystick8Button7, KeyCode.Joystick8Button8, KeyCode.Joystick8Button9 };

        buttons = new ControllerButton[10];
        for (int i = 0; i < buttons.Length; ++i)
        {
            buttons[i] = new ControllerButton(xboxKeyCodes[playerIndex][i]);
        }
        A = buttons[0];
        B = buttons[1];
        X = buttons[2];
        Y = buttons[3];
        LeftBumper = buttons[4];
        RightBumper = buttons[5];
        Back = buttons[6];
        Start = buttons[7];
        LeftStickClick = buttons[8];
        RightStickClick = buttons[9];
        #endregion buttons
        #region axisMapping
        axes = new int[9];
        axes[0] = 0;//lsx
        axes[1] = 1;//lsy
        axes[2] = 3;//rsx
        axes[3] = 4;//rsy
        axes[4] = 5;//dpx
        axes[5] = 6;//dpy
        axes[6] = 8;//lt
        axes[7] = 9;//rt
        axes[8] = 2;//dt
        #endregion axisMapping

    }
    int axisPlayerIndex;
    public void RefreshAxisValues()
    {
        LeftStickX = Input.GetAxis("LeftStickX" + axisPlayerIndex);
        LeftStickY = (-1f * Input.GetAxis("LeftStickY" + axisPlayerIndex));
        RightStickX= Input.GetAxis("RightStickX" + axisPlayerIndex);
        RightStickY = (-1f * Input.GetAxis("RightStickY" + axisPlayerIndex));
        DPadX = Input.GetAxis("DPadX" + axisPlayerIndex);
        DPadY = Input.GetAxis("DPadY" + axisPlayerIndex);
        LeftTrigger = Input.GetAxis("LeftTrigger" + axisPlayerIndex);
        RightTrigger = Input.GetAxis("RightTrigger" + axisPlayerIndex);
        DualTrigger = Input.GetAxis("DualTrigger" + axisPlayerIndex);
    }
    public float LeftStickX { get; private set; }
    public float LeftStickY { get; private set; }
    public float RightStickX { get; private set; }
    public float RightStickY { get; private set; }
    public float DPadX { get; private set; }
    public float DPadY { get; private set; }
    public float LeftTrigger { get; private set; }
    public float RightTrigger { get; private set; }
    public float DualTrigger { get; private set; }
}
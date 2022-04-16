using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller
{
    public ControllerButton[] buttons;
    protected int[] axes;
    public int playerIndex=0;
}

using UnityEngine;

public class ControllerDetector : MonoBehaviour
{
    public static int NumberOfConnectedControllers { get; private set; }
    public static bool[] ThisControllerIsConnected { get; private set; }
    private float timer = 0;
    private void Awake()
    {
        ThisControllerIsConnected = new bool[12];
        for (int i = 0; i < ThisControllerIsConnected.Length; ++i)
            ThisControllerIsConnected[i] = false;
    }
    void Start()
    {
        NumberOfConnectedControllers = 0;
        string[] names = Input.GetJoystickNames();
        for (int i = 0; i < names.Length; ++i)
        {
            if (!string.IsNullOrEmpty(names[i]))
            {
                ThisControllerIsConnected[i] = true;
                NumberOfConnectedControllers++;
            }
        }
    }
    void Update()
    {
        timer += Time.deltaTime;
        while (timer > 2f)
        {
            timer = 0f;
            string[] names = Input.GetJoystickNames();
            if (names.Length > 0)
                for (int i = 0; i < names.Length; ++i)
                {
                    if (string.IsNullOrEmpty(names[i]))
                    {
                        if (ThisControllerIsConnected[i] == true)
                        {
                            ThisControllerIsConnected[i] = false;
                            NumberOfConnectedControllers--;
                        }
                    }
                    else
                    {
                        if (ThisControllerIsConnected[i] == false)
                        {
                            ThisControllerIsConnected[i] = true;
                            NumberOfConnectedControllers++;
                        }
                    }
                }
        }
    }
}

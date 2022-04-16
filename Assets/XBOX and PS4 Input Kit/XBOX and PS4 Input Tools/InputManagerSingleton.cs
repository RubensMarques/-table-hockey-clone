using UnityEngine;
public class InputManagerSingleton : MonoBehaviour
{
    void Awake()
    {
        InputManager.Initialize();
    }
    void Update()
    {
        InputManager.UpdateControllers();
    }
}

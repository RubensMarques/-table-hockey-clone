using UnityEngine;
using UnityEngine.UI;
public class CounterOfPlayers : MonoBehaviour
{
    private Text countText;
    private int numberOfPlayers = 0;
    private void Start()
    {
        countText = GetComponent<Text>();
    }
    void Update()
    {
        if (numberOfPlayers != ControllerDetector.NumberOfConnectedControllers)
        {
            numberOfPlayers = ControllerDetector.NumberOfConnectedControllers;
            if (numberOfPlayers != 1)
                countText.text = numberOfPlayers + " players are connected.";
            else
                countText.text = numberOfPlayers + " player is connected.";

        }
    }
}

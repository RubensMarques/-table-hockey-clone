using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameController : MonoBehaviour
{
    public static GameController instance;
    public int scoreboard1, scoreboard2;
    public TextMeshProUGUI sb1, sb2;
    public GameObject goal;
    

    
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        RefreshScreen();
    }

    // Update is called once per frame
    void Update()
    {
        RefreshScreen();
    }

    public void Restart()
    {
        SceneManager.LoadScene("partida");
        goal.SetActive(false);
        
    }

    public void RefreshScreen()
    {
        
        sb1.text = scoreboard1.ToString();
        sb2.text = scoreboard2.ToString();
    }



}

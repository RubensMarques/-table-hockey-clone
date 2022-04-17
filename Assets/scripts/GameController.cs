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
    public GameObject[] win;



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
        if (scoreboard1 == 2 || scoreboard2 == 2)
        {
            if(scoreboard1 == 2)
            {
                win[0].SetActive(true);
            }
            else
            {
                win[1].SetActive(true);
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("partida");
        
        
    }

    public void RefreshScreen()
    {
        
        sb1.text = scoreboard1.ToString();
        sb2.text = scoreboard2.ToString();
    }

    public void Congratulations()
    {
        SceneManager.LoadScene("final");
    }



}

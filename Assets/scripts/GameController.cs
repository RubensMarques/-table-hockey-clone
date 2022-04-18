using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameController : MonoBehaviour
{
    
    public static GameController instance;
    public int scoreboard1, scoreboard2, scoreForWin;
    public TextMeshProUGUI sb1Text, sb2Text, sfwText;
    public GameObject goal, SFW;
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
        FinalGame();
    }

    public void FinalGame()
    {
        if ((scoreboard1 == scoreForWin || scoreboard2 == scoreForWin) && scoreForWin != 0)
        {

            if (scoreboard1 == scoreForWin)
            {
                win[0].SetActive(true);
            }
            else
            {
                win[1].SetActive(true);
            }
        }

        if (scoreForWin < 1)
        {
            scoreForWin = 1;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("partida");
       
    }
    

    public void RefreshScreen()
    {
        
        sb1Text.text = scoreboard1.ToString();
        sb2Text.text = scoreboard2.ToString();
        sfwText.text = scoreForWin.ToString();
    }

    public void Begin()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("partida");
    }

    

    public void More()
    {
        scoreForWin++;
    }
    
    public void Less()
    {

        scoreForWin--;

    }

    public void closeSFW()
    {
        SFW.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }


}

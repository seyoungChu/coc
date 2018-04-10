using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour
{
    public Text point;
    public Text Life;
    public Text GameState;

    public static int myPoint = 0;
    public static int myLife = 3;

    public enum GAMESTATE
    {
        BEGIN,
        PLAYING,
        FINISH
    }

    public GAMESTATE myGameState = GAMESTATE.BEGIN;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        SetPointText();
        SetLifeText();
    }

    // Update is called once per frame
    void Update()
    {
        switch (myGameState)
        {
            case GAMESTATE.BEGIN:
                GameState.text = "PRESS GAME";
                if (Input.GetMouseButtonDown(0))
                {
                    myGameState = GAMESTATE.PLAYING;
                    SceneManager.LoadScene("Main");
                }
                break;
            case GAMESTATE.PLAYING:
                GameState.text = string.Empty;
                if (GameControl.myPoint > 500)
                {
                    GameControl.myPoint = 0;
                    SetPointText();
                    myGameState = GAMESTATE.FINISH;
                    SceneManager.LoadScene("Finish");
                }
                break;
            case GAMESTATE.FINISH:
                GameState.text = "Finish Game!";
                if (Input.GetMouseButtonDown(0))
                {
                    myGameState = GAMESTATE.PLAYING;
                    SceneManager.LoadScene("Main");
                }
                break;
        }


    }

    public void AddPoint(int addPoint)
    {
        myPoint += addPoint;
        SetPointText();
    }

    private void SetPointText()
    {
        point.text = "Point: " + myPoint.ToString();
    }

    private void SetLifeText()
    {
        Life.text = "Life: " + myLife.ToString();   
    }
}

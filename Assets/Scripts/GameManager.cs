using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Editor.SceneManagement;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject startButton;
    public Player player;
    public TMP_Text gameOverCountDown;
    public float countTimer = 5;

    void Start()
    {
        gameOverCountDown.GameObject.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.isDead){
            gameOverCountDown.GameObject.SetActive(true);
            countTimer -= Time.unscaledDeltaTime;
        }
        gameOverCountDown.text = "Restarting in: " + (countTimer).ToString("0");
        if(countTimer < 0){
            RestartGame();
        }
    }

    public void StartGame(){
        startButton.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver(){
        Time.TimeScale = 0;
    }

    public void RestartGame(){
        EditorSceneManager.LoadScene(0);
    }

}

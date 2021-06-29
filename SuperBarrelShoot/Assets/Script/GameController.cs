using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instanceGameController;

    public GameObject gameOverText;
    public bool gameOver;
    public float scrollSpeed = -1.5f;

    //Puntuacion
    public int score;
    public Text scoreText;


    private void Awake()
    {
        if(GameController.instanceGameController == null)
        {
            GameController.instanceGameController = this;
        }
        else if(GameController.instanceGameController != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("GameController ha sido instanciado por segunda vez ERROR!");
        }
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if(gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void PlayerScored()
    {
        if (gameOver) return;
        score++;
        scoreText.text = "Score: " + score;
    }
    public void PlayerDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    private void OnDestroy()
    {
        if(GameController.instanceGameController == this)
        {
            GameController.instanceGameController = null;
        }
    }
}

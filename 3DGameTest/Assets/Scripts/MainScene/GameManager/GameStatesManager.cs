using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatesManager : MonoBehaviour {
    
    private bool gameHasEnded;

    private const float restartDelay = 1f;

    public GameObject gameOverUI;
    
    public void EndGame() {
        if (!gameHasEnded) {
            Debug.Log("game over");
            gameHasEnded = true;
            Invoke(nameof(GameOver), restartDelay);
        }
    }

    public void GameOver() {
        gameOverUI.SetActive(true);
        Invoke(nameof(loadRestartScene), 1.5f);
    }

    private void loadRestartScene() {
        SceneManager.LoadScene("RestartScene");
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatesManager : MonoBehaviour {
    
    private bool gameHasEnded;

    private const float restartDelay = 1f;
    
    public void EndGame() {
        if (!gameHasEnded) {
            Debug.Log("game over");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart() {
        SceneManager.LoadScene("MainScene");
    }
}

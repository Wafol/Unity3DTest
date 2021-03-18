using UnityEngine;
using UnityEngine.SceneManagement;

namespace RestartScene {
    public class QuitRestart : MonoBehaviour {

        public void Quit() {
            Debug.Log("Quit");
            Application.Quit();
        }

        public void Restart() {
            SceneManager.LoadScene("MainScene");
        }
    
    }
}

using UnityEngine;

namespace Player {
    public class PlayerCollision : MonoBehaviour {

        public PlayerMovement plMovement;
    
        private void OnCollisionEnter(Collision collision) {
            if (collision.collider.CompareTag("Obstacle")) {
                plMovement.enabled = false;
                FindObjectOfType<GameStatesManager>().EndGame();
            }
        }
    
    }
}

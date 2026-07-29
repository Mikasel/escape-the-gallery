using UnityEngine;

namespace Manager
{
    public class GameDirector : MonoBehaviour
    {
        public Player player;
        public EnemyManager enemyManager;
        public LevelManager levelManager;
        private void Start()
        {
            RestartLevel();
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                RestartLevel();
            }
        }

        private void RestartLevel()
        {
            levelManager.RestartLevel();
            enemyManager.RestartEnemyManager();
            player.RestartPlayer();
        }

        public void LevelCompleted()
        {
            enemyManager.StopEnemies();
        }

        public void LevelFailed()
        {
            enemyManager.StopEnemies();
            print("failed");
        }
    }
}

using UnityEngine;

namespace Manager
{
    public class GameDirector : MonoBehaviour
    {
        public EnemyManager enemyManager;
        public LevelManager levelManager;

        private void Start()
        {
            levelManager.RestartLevel();
        }

        public void LevelCompleted()
        {
            enemyManager.StopEnemies();
        }

        public void LevelFailed()
        {
            enemyManager.StopEnemies();
        }
    }
}

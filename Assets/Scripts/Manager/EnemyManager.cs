using System.Collections.Generic;
using Elements;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Player player;
    public Enemy enemyPrefab;
    public List<Enemy> enemies;
    public Vector2 enemyCount;

    public void RestartEnemyManager()
    {
        DeleteEnemies();
        GenerateEnemies();
    }

    private void GenerateEnemies()
    {
        var randomEnemyCount = Random.Range(enemyCount.x, enemyCount.y);
        for (int i = 0; i < randomEnemyCount; i++)
        {
            var enemyXPos = Random.Range(-4.5f, 4.4f);;
            var newEnemy = Instantiate(enemyPrefab);
            newEnemy.transform.position = new Vector3(enemyXPos, 0, i*2 + 3);
            enemies.Add(newEnemy);
            newEnemy.StartEnemy(player); 
        }
        
    }

    private void DeleteEnemies()
    {
        foreach (var e in enemies )
        {
            Destroy(e.gameObject);
        }
        enemies.Clear();
        
    }
    
    public void StopEnemies()
    {
        foreach (var e in enemies)
        {
            e.Stop();
        }
    }
}

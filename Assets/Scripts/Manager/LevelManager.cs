using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject door;
    public GameObject collectiblePrefab;
    public List<GameObject> collectibles;
    public void RestartLevel()
    {
        DeactivateDoor();
        RandomizeDoorPosition();
        DeleteCollectible();
        GenerateCollectible();
        
    }

    private void GenerateCollectible()
    {
        var newCollectible = Instantiate(collectiblePrefab);
        newCollectible.transform.position = new Vector3(Random.Range(-4f,4f), 0, 15);
        collectibles.Add(newCollectible);
    }

    private void DeleteCollectible()
    {
        foreach (var e in collectibles)
        {
            Destroy(e);
        }
        collectibles.Clear();
    }

    private void RandomizeDoorPosition()
    {
        var pos = door.transform.position;
        pos.x = Random.Range(-4.15f, 3.32f);
        door.transform.position = pos;
    }

    private void DeactivateDoor()
    {
        door.SetActive(false);
    }

    public void AppleCollected()
    {
        door.SetActive(true);
    }
}

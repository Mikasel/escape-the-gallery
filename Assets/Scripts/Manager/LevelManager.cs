using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject door;
    public void RestartLevel()
    {
        ActivateDoor();
        RandomizeDoorPosition();
    }

    private void RandomizeDoorPosition()
    {
        var pos = door.transform.position;
        pos.x = Random.Range(-4.15f, 3.32f);
        door.transform.position = pos;
    }

    private void ActivateDoor()
    {
        door.SetActive(false);
    }

    public void AppleCollected()
    {
        door.SetActive(true);
    }
}

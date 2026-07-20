using System;
using UnityEngine;

public class denemEnemy : MonoBehaviour
{
    public deneme deneme;
    private float speed = 1;

    // Update is called once per frame
    void Update()
    {
        if (deneme.isYellowCollected)
        {
            var direction = (deneme.transform.position - transform.position).normalized;
            transform.position += direction * (speed * Time.deltaTime);
        }
        
    }
}

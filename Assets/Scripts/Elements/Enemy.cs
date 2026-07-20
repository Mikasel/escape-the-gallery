using UnityEngine;

namespace Elements
{
    public class Enemy : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        public Player player;
        public float speed = 1;

        private void Update()
        {
            if (player.isAppleCollected)
            {
                var direction = (player.transform.position - transform.position).normalized;
                transform.position += direction * (speed * Time.deltaTime);
            }
        }

        public void Stop()
        {
            speed = 0;
        }
    }
}

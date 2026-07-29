using UnityEngine;
using UnityEngine.AI;

namespace Elements
{
    public class Enemy : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private Player _player;
        public float speed = 1;
        private Rigidbody _rb;
        public NavMeshAgent navMeshAgent;
        private Animator _animator;
        private bool _isWalking;

        public void StartEnemy(Player player)
        {
            _player = player;
            _rb = GetComponent<Rigidbody>();
            _animator = GetComponentInChildren<Animator>();
        }

        private void Update()
        {
            if (_player.isAppleCollected)
            {
                /*var direction = (_player.transform.position - transform.position).normalized;
                direction.y = 0;
                _rb.position += direction * (speed * Time.deltaTime);*/
                navMeshAgent.destination = _player.transform.position;
                if (!_isWalking)
                {
                    _isWalking = true;
                _animator.SetTrigger("Walk");
                }
            }
        }

        public void Stop()
        {
            navMeshAgent.speed = 0;
            _animator.SetTrigger("Idle");
        }
    }
}

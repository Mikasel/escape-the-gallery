using System;
using Manager;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody _rb;
    public bool isAppleCollected;
    public GameDirector gameDirector;
    private bool _isCharacterWalking;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void RestartPlayer()
    {
        gameObject.SetActive(true);
        _rb = GetComponent<Rigidbody>();
        _rb.position = Vector3.zero;
        isAppleCollected = false;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            gameDirector.levelManager.AppleCollected();
            isAppleCollected = true;
        }

        if (other.CompareTag("Door") && isAppleCollected)
        {
            gameDirector.LevelCompleted();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            gameDirector.LevelFailed();
        }    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }

    private void MovePlayer()
    {
        var direction = Vector3.zero;
        /*wasd kontrolleri*/ 
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 6;
            SetWalkAnimationSpeed(2);
        }
        else
        {
            speed = 3;
            SetWalkAnimationSpeed(1);
        }
            
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        if (direction.magnitude < .1f)
        {
            TriggerIdleAnimation();
        }
        else
        {
            TriggerWalkAnimation();
        }
        transform.LookAt(transform.position + direction);
        _rb.linearVelocity = direction.normalized * speed;
    }

    void TriggerWalkAnimation()
    {
        if (!_isCharacterWalking)
        {
            animator.SetTrigger("Walk");
            _isCharacterWalking = true;
        }
    }
    void TriggerIdleAnimation()
    {
        if (_isCharacterWalking)
        {
            animator.SetTrigger("Idle");
            _isCharacterWalking = false;
        }
    }

    void SetWalkAnimationSpeed(float s)
    {
        animator.SetFloat("WalkSpeedMultiplier", s);
    }
}

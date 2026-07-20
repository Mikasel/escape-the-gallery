using System;
using Manager;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody _rb;
    public bool isAppleCollected;
    public GameDirector gameDirector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            gameDirector.LevelFailed();
        }

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

    // Update is called once per frame
    void Update()
    {
        var direciton = Vector3.zero;
        /*wasd kontrolleri*/ 
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 6;
        }
        else
        {
            speed = 3;
        }
            
        if (Input.GetKey(KeyCode.W))
        {
            direciton += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direciton += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direciton += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direciton += Vector3.right;
        } 
        _rb.linearVelocity = direciton.normalized * speed;
        
        
        
        /*flappy bird mekaniği
       /*transform.position += Vector3.forward * speed * Time.deltaTime;
       if (Input.GetMouseButton(0))
       {
           transform.position += Vector3.up * speed * Time.deltaTime;
       }
       else
       {
           transform.position += Vector3.down * speed * Time.deltaTime;
       }*/
    }
}

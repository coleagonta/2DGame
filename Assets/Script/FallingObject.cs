using System;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Serialization;

public class FallingObject : MonoBehaviour
{
    public int maxMissedCount = 3;
    public PlayerController playerController;
    
    public int lives = 3;
    public  GameObject hp1;
    public  GameObject hp2;
    public  GameObject hp3;
    public void Start()
    
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            playerController.missedCount++;
            Debug.Log("Missed Count: " + playerController.missedCount);
                //Destroy(other.gameObject);

            if (playerController.missedCount >= maxMissedCount)
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene("GameOver");
            }

            if (playerController.missedCount == 1)
            {
               
                Destroy(hp1);
            }
            if (playerController.missedCount == 2)
            {
               
                Destroy(hp2);
            }
            if (playerController.missedCount == 3)
            {
                
                Destroy(hp3);
            }
            
        }
    }
}
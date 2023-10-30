using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public static int health;
    public GameObject Heart1, Hearth2, Hearth3;
    void Start()
    {
        Heart1.SetActive(true);
        Heart1.SetActive(true);
        Heart1.SetActive(true);
        health = 3;
    }
    
    void Update()
    {
        switch (health)
        {
            case 3 :
                Heart1.SetActive(true);
                Heart1.SetActive(true);
                Heart1.SetActive(true);
                break;
            case 2 :
                Heart1.SetActive(true);
                Heart1.SetActive(true);
                Heart1.SetActive(false);
                break;
            case 1 :
                Heart1.SetActive(true);
                Heart1.SetActive(false);
                Heart1.SetActive(false);
                break;
            case 0 :
                Heart1.SetActive(false);
                Heart1.SetActive(false);
                Heart1.SetActive(false);
                break;
            
                
        }
        
        {
            
        }
        
    }
}

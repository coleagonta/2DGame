using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private int coinCount = 0;
    public int missedCount = 0;
    public int takeCoin = 0;
    public int maxCoin = 5;
    public TextMeshProUGUI coinCountText;
    

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime;
        transform.Translate(movement);

        float xPosition = Mathf.Clamp(transform.position.x, -8f, 8f);
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("FallingObject"))
        {
            coinCount++; 
            Debug.Log(("Take Coin : " + coinCount));
            UpdateCoinCountText(); 
            Destroy(other.gameObject);
            if (coinCount >= maxCoin)
            {
                Debug.Log("You Win");
                SceneManager.LoadScene("YouWin");
                
            }
        }
    }
    
    void UpdateCoinCountText()
    {
        if (coinCountText != null)
        {
            coinCountText.text =  coinCount.ToString();
        }
    }
}
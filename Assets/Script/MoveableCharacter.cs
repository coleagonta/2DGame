using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private int coinCount = 0;
    public TextMeshProUGUI coinCountText; // Поле для текста

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
            UpdateCoinCountText(); 
            Destroy(other.gameObject);
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
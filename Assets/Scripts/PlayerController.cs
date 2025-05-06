using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
       

    }

    void OnTriggerEnter(Collider other)
    {
        
            Debug.Log("You Win!");
            Time.timeScale = 0; // Pauses the game
        
    }


}

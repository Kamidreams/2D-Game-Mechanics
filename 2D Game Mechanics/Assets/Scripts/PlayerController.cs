using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public GameObject ExplosionFX;
    private Rigidbody2D _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2(horizontalInput, verticalInput);
        _playerRb.AddForce(direction * speed);
    }

     private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Wall"))
        {
            Instantiate(ExplosionFX, other.transform.position, ExplosionFX.transform.rotation);
            Destroy(other.gameObject);
        }
    }
}

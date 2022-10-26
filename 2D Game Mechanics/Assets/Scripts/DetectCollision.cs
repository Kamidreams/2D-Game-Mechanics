using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObject PlayerFX;
    public GameObject EnemyFX;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Instantiate(PlayerFX, other.transform.position, PlayerFX.transform.rotation);
            Destroy(other.gameObject);
        }
    }
}

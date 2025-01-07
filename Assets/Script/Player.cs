using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
                
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

       
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            print("Game over");
            transform.position = startPos;
        }
    }
}

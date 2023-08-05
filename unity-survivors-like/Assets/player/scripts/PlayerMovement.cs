using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var directionX = Input.GetAxisRaw("Horizontal");
        var directionY = Input.GetAxisRaw("Vertical");
        
        transform.position = new Vector3(
            transform.position.x + directionX * Time.fixedDeltaTime * movementSpeed,
            transform.position.y + directionY * Time.fixedDeltaTime * movementSpeed,
            transform.position.z
        );
    }
}
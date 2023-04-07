using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //declaring variables
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed); //movement
        transform.Rotate(Vector3.forward); //rotates back is right, forward is left
    }
}

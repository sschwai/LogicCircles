using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //declaring variables
    public float speed;
    public bool right;
    public string GameScene;

    void Start()
    {
        if (!right)
        {
            transform.Rotate(Vector3.back * 180);
        }
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed); //movement

        if (Input.GetKeyDown(KeyCode.Space))
        { Restart(); }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Collided with " + other.gameObject.name);
        DirectionalNode dn = other.GetComponent<DirectionalNode>();
        //Debug.Log("Changing player direction: " + dn.current);

        //check direction, rotation back is right, forward is left
        float rot = 0;
        Vector3 dir = Vector3.zero;
        if (dn.current == "right")
        {
            dir = Vector3.back;
            rot = 90;
        }
        if (dn.current == "left")
        {
            dir = Vector3.forward;
            rot = 90;
        }

        transform.Rotate(dir * rot);
    }

    void Restart()
    {
        SceneManager.LoadScene(GameScene);
    }
}

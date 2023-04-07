using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode : MonoBehaviour
{
    //declaring variables
    SpriteRenderer sr;
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;

    void Start()
    {
        //get our Sprite Renderer
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = left;
        SwitchSprite();
    }

    void Update()
    {
        
    }

    //logic to switch sprites
    void SwitchSprite()
    {
        if(current == "left")
        {
            Debug.Log("Choose Left");
            sr.sprite = left;
        }
        else if(current == "right")
        {
            Debug.Log("Choose Right");
            sr.sprite = right;
        }
        else
        {
            Debug.Log("Choose None");
            sr.sprite = none;
        }
    }
}

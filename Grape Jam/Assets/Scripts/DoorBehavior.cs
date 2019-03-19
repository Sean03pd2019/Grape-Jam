using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{

    public GameObject button;
    public Sprite Opened;

    private bool buttonState;


    private void Start()
    {
        buttonState = false;
    }

    // Update is called once per frame
    void Update()
    {
        buttonState = button.GetComponent<ButtonBehavior>().isPressed;
        if (buttonState)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Opened;
        }
    }
}

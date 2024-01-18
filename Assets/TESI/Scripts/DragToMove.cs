using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragToMove : MonoBehaviour
{
    private Touch touch;
    private float speedModifier; //controls how fast model will move

    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.001f; //increase de value to make objetc move faster
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0) // when a finger is touching the screen
        {
            touch = Input.GetTouch(0);

            if(touch.phase==TouchPhase.Moved) //when move gesture is performed
            {

                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifier, transform.position.y, transform.position.z + touch.deltaPosition.y * speedModifier);

            }
        }
    }
}

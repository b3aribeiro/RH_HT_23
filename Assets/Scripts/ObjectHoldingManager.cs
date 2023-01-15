using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHoldingManager : MonoBehaviour
{
    public bool buttonPressed;//is the button on the controller held down right now
    public GameObject touchingObject;//which object are we currently touching

    public void onButtonPressed()
    {
        buttonPressed = true;
        //print ("BTEST: BUTTON PRESS TRUE");   
    }

    public void onButtonReleased()
    {
        buttonPressed = false;
        //print ("BTEST: BUTTON PRESS FALSE");   
    }
}

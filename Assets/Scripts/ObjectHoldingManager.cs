using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHoldingManager : MonoBehaviour
{
    public bool buttonPressed;//is the button on the controller held down right now
    public GameObject touchingObject;//which object are we currently touching

    public void onButtonPressed()
    {
        //buttonPressed = true;
        print ("BTEST: PRESS SHOULD BE TRUE BUT IS: " + buttonPressed);   
        print ("BTEST: AND OBJECT NAME FOR PRESSED: " + touchingObject.name);   
    }

    public void onButtonReleased()
    {
        //buttonPressed = false;
        print ("BTEST: BUTTON PRESS SHOULD BE FALSE BUT IS: " + buttonPressed);   
        print ("BTEST: AND OBJECT NAME IS FOR RELEASED: " + touchingObject.name);   
    }

}

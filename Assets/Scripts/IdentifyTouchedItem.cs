using System.Collections;
using System.Collections.Generic;
using Sngty;
using UnityEngine;

public class IdentifyTouchedItem : MonoBehaviour
{
    public ObjectHoldingManager objectHoldingManager;

    public ExampleCommunicatorScript exampleCommunicatorScript;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Objects" && objectHoldingManager.buttonPressed == true){
            objectHoldingManager.touchingObject = other.gameObject;
            exampleCommunicatorScript.SendMessageAsHolding(objectHoldingManager.touchingObject.name);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
       if(objectHoldingManager.buttonPressed == false){
            objectHoldingManager.touchingObject = null;
        }
    }


}

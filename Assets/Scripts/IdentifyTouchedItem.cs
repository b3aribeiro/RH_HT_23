using System.Collections;
using System.Collections.Generic;
using Sngty;
using UnityEngine;

public class IdentifyTouchedItem : MonoBehaviour
{
    public ObjectHoldingManager objectHoldingManager;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Objects"){
            objectHoldingManager.touchingObject = other.gameObject;
            //mySingularityManager.sendMessage(objectHoldingManager.touchingObject.name + "\n", myDevice);
            print ("BTEST: TRIGGER ENTER IS:" + objectHoldingManager.touchingObject.name);  
        } else {
            objectHoldingManager.touchingObject = null;
        }
    }
}

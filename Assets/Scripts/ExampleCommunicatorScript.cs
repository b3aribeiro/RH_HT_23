using System.Collections;
using System.Collections.Generic;
using Sngty;
using UnityEngine;

public class ExampleCommunicatorScript : MonoBehaviour
{
    public SingularityManager mySingularityManager;
    DeviceSignature myDevice;

    public ObjectHoldingManager objectHoldingManager;

    public bool isHolding = false;
    public CheckCollisionWithItem checkCollisionWithItem;
    
    
    // Start is called before the first frame update
    void Start()
    {
       List<DeviceSignature> pairedDevices = mySingularityManager.GetPairedDevices();
       //DeviceSignature myDevice = new DeviceSignature();
       myDevice = new DeviceSignature();

        //If you are looking for a device with a specific name (in this case exampleDeviceName):
        for (int i = 0; i < pairedDevices.Count; i++)
        {
            if (pairedDevices[i].name == "Kitchen-ESP32")
            {
                myDevice = pairedDevices[i];
                //Do stuff to connect to the device here
                mySingularityManager.ConnectToDevice(myDevice);
                break;
            }
        }

        if (!myDevice.Equals(default(DeviceSignature)))
        {

        }
    }

    public void SendMessageAsHolding(string message)
    {

        if(objectHoldingManager.buttonPressed == true && objectHoldingManager.touchingObject != null){
            print ("here");       
        }
        
        // if(isHolding == true && (message == "OBJ1_HOLD" || message == "OBJ2_HOLD" || message == "OBJ3_HOLD")) 
        // {
        //     mySingularityManager.sendMessage(message + "\n", myDevice);
        // } 
    }

    // public void SendMessageAsRelasing(string message)
    // {
      
    //     if (message == "OBJ1_RELEASE" || message == "OBJ2_RELEASE" || message == "OBJ3_RELEASE")
    //     {
    //         mySingularityManager.sendMessage(message + "\n", myDevice);
    //     }
    
    // }
}

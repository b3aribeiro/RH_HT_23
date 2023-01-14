using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisionWithItem : MonoBehaviour
{
    public ExampleCommunicatorScript _exampleComm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
     {
         print("ISHOLDING VALUE IS: " + _exampleComm.isHolding);
         print("HAS COLLIDED WITH TRIGGER");
         if (other.gameObject.CompareTag("Objects"))
         {
            print("INSIDE COMPARETAG IF FOR ENTER")
            _exampleComm.isHolding = true;
            print("ISHOLDING SET TO TRUE");
             
         } 
     }

     public void OnTriggerExit (Collider other)
     {
        print("HAS EXITED WITH TRIGGER");
         if (other.gameObject.CompareTag("Objects"))
         {
            print("INSIDE COMPARETAG IF FOR EXIT")
            _exampleComm.isHolding = false;
             print("ISHOLDING SET TO FALSE");
         } 
     }
}

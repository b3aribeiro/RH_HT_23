using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisionWithItem : MonoBehaviour
{
    public ExampleCommunicatorScript _exampleComm;
    public bool isHoldingButItsDifferent = false;

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
         //print("BTEST: ISHOLDING VALUE IS: " + _exampleComm.isHolding);
         print("BTEST: ISHOLDING VALUE IS: " + isHoldingButItsDifferent);
         print("BTEST: HAS COLLIDED THE TRIGGER");
         if (other.gameObject.CompareTag("Objects"))
         {
            print("BTEST: INSIDE COMPARETAG IF FOR ENTER");
            //_exampleComm.isHolding = true;
            isHoldingButItsDifferent = true;
            print("BTEST: ISHOLDING SET TO TRUE");
             
         } 
     }

     public void OnTriggerExit (Collider other)
     {
        print("BTEST: HAS EXITED THE TRIGGER");
         if (other.gameObject.CompareTag("Objects"))
         {
            print("BTEST: INSIDE COMPARETAG IF FOR EXIT");
            _exampleComm.isHolding = false;
             print("BTEST: ISHOLDING SET TO FALSE");
         } 
     }
}

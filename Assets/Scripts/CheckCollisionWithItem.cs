using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisionWithItem : MonoBehaviour
{
    public ExampleCommunicatorScript _exampleComm;
    public bool isHoldingButItsDifferent = false;
    public ObjectHoldingManager objectHoldingManager;

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
         print("BTEST: HAS COLLIDED THE TRIGGER"); //ENTERED
         if (other.gameObject.CompareTag("Objects"))
         {
            print("BTEST: INSIDE COMPARETAG IF FOR ENTER"); //ENTERED
            //_exampleComm.isHolding = true;
            isHoldingButItsDifferent = true;
            //GlobalVariable.holdingState = true;
            print("holding state enter is" + isHoldingButItsDifferent);
             
         } 
     }

     public void OnTriggerExit (Collider other)
     {
        print("BTEST: HAS EXITED THE TRIGGER");
         if (other.gameObject.CompareTag("Objects"))
         {
            print("BTEST: INSIDE COMPARETAG IF FOR EXIT");
            _exampleComm.isHolding = false;
            //GlobalVariable.holdingState = false;
             print("BTEST: ISHOLDING SET TO FALSE");
         } 
     }
}

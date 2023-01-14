using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisionWithItem : MonoBehaviour
{
    public GameObject leftItem, middleItem, rightItem;

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
        Debug.Log(other);
         if (other.gameObject.CompareTag("Objects"))
         {
             Physics.IgnoreCollision(other, GetComponent<Collider>());
             
         } else {
            print("didnt");
         }
     }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positioncheck : MonoBehaviour
{
   public GameObject head;
   public GameObject left;
   public GameObject right;

    // Update is called once per frame
    void Update()
    {
    var headPosition = head.transform.position;
    var handRPosition= right.transform.position;
    var handLPosition = left.transform.position;
    }
}

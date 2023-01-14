using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject changeThis; //gameobject whose color we will change to red
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = changeThis.GetComponent<Renderer>();
    }

    public void ChangeObjectColor(){
        rend.material.SetColor("_Color", Color.red);
    }
}

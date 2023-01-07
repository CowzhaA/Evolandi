using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingObject : MonoBehaviour
{
    // Variables
    public GameObject objectToPull; // The variable managing the objects that can be pulled
    public bool isPulling; // The variable managing the state of the player wheter he should be able to pull or not
    public float pullForce = 10f; // The variable managing the pull force 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isPulling = true;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            isPulling = false;
        }

        PullObject();
    }


    void PullObject()
    {
        if (isPulling)
        {
            // apply a force to the object in the direction of the player character
            objectToPull.GetComponent<Rigidbody>().AddForce(transform.forward * pullForce);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingObject : MonoBehaviour
{

    public GameObject objectToPush; // // The variable managing the objects that can be pushed
    public bool isPushing; // The variable managing the state of the player wheter he should be able to pull or not
    public float pushForce = 10f; // The variable managing the pull force 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isPushing = true;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            isPushing = false;
        }

        PushObject();
    }


    void PushObject()
    {
        if (isPushing)
        {
            // apply a force to the object in the opposite direction of the player character
            objectToPush.GetComponent<Rigidbody>().AddForce(-transform.forward * pushForce);
        }
    }

}

using UnityEngine;
using System.Collections;

public class Stand : MonoBehaviour {

    private Transform stand;
    void Update()
    {
 GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
    }

	// Use this for initialization
void OnCollisionEnter(Collision collision) {
        /* Quaternion startRotation = transform.rotation;
         Quaternion endRotation = new Quaternion(0.0f, transform.rotation.y, 0.0f, transform.rotation.w);
         transform.rotation = Quaternion.Slerp(startRotation, endRotation, Time.deltaTime * 2f);*/
       
      

      
    }
}

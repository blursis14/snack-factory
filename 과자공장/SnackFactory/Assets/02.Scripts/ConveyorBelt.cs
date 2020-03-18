using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ConveyorBelt : MonoBehaviour {

    public GameObject belt;
    public Transform endpoint;
    public float speed;

    void OnTriggerStay(Collider other)
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position,endpoint.position,speed*Time.deltaTime);
    }
}

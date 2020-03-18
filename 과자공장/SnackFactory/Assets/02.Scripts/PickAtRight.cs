using UnityEngine;
using System.Collections;
using System.Linq;

public class PickAtRight : MonoBehaviour {
    private GameObject item;
    public GameObject tempParent;
    public Transform guide;

    private bool carrying;
    public bool fourToSix;
    public Transform sixStart;

	// Use this for initialization
	void Start () {
       // item = GameObject.FindWithTag("snack");
        carrying = false;
        fourToSix = false;
        //item.GetComponent<Rigidbody>().useGravity = true;

	}
	
	// Update is called once per frame
	void Update () {
        findNearestItem();
	if((Input.GetKeyDown("c")&&Vector3.Distance(item.transform.position,guide.transform.position)<=1.5f))
        {
            if(carrying==false)
            {
                pickup();
            }
            else if(carrying==true&&fourToSix==true)
            {
                drop();
            }
        }
	}
    void pickup()
    {
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.position = guide.transform.position;
       // item.transform.rotation = guide.transform.rotation;
        item.transform.parent = tempParent.transform;
        carrying = true;
    }
    void drop()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.parent = null;
        if(fourToSix==true)
        {
            item.transform.position = sixStart.transform.position;
        }
        carrying = false;
    }
    void findNearestItem()
    {
        item = GameObject.FindGameObjectsWithTag("snack").Aggregate((o1, o2) =>
         Vector3.Distance(o1.transform.position, this.transform.position) >
         Vector3.Distance(o2.transform.position, this.transform.position) ? o2 : o1);
    }
}

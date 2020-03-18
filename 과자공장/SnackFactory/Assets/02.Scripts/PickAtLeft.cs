using UnityEngine;
using System.Collections;
using System.Linq;

public class PickAtLeft : MonoBehaviour {
    private GameObject item;
    public GameObject tempParent;
    public Transform guide;
    private float power = 50;
    private Vector3 velocity;
    private bool carrying;
    public bool oneToThree;
    public bool fiveToEnd;
    public Transform threeStart;
    public Transform end;

	// Use this for initialization
	void Start () {
       // item = GameObject.FindWithTag("snack");
        carrying = false;
        oneToThree = false;
        fiveToEnd = false;
        velocity = (end.transform.position)*power;
        //item.GetComponent<Rigidbody>().useGravity = true;
	}
	
	// Update is called once per frame
	void Update () {
        findNearestItem();
        if((Input.GetKeyDown("z")&&Vector3.Distance(item.transform.position,guide.transform.position)<=1.5f))
        {
            if(carrying==false)
            {
                pickup();
            }
            else if(carrying==true&&oneToThree==true)
            {
                drop();
            }
            else if(carrying==true&&fiveToEnd==true)
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
      //  item.transform.rotation = guide.transform.rotation;
        item.transform.parent = tempParent.transform;
        carrying = true;
    }
    void drop()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.parent = null;
        if(oneToThree==true)
        {
            item.transform.position = threeStart.transform.position;
        }
        else if(fiveToEnd==true)
        {
           // velocity = velocity * power;
            item.GetComponent<Rigidbody>().AddForce(velocity);
            Destroy(item, 0.7f);
            
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

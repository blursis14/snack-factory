using UnityEngine;
using System.Collections;
using System.Linq;

public class PickAtCenter : MonoBehaviour {
    private GameObject item;
    public GameObject tempParent;
    public Transform guide;
   
    public bool twoToOne;
    public bool threeToFour;
    public bool sixToFive;
    public Transform oneStart;
    public Transform fourStart;
    public Transform fiveStart;
    
    

    // Use this for initialization
    void Start()
    {
        //item = GameObject.FindWithTag("snack"); 
        twoToOne = true;
        threeToFour =false;
        sixToFive = false;
       // item.GetComponent<Rigidbody>().useGravity = true;
    }
    // Update is called once per frame
    void Update()
    {
        findNearestItem();
       if ((Input.GetKeyDown("x") && Vector3.Distance(item.transform.position,guide.transform.position)<=1.5f))
        {
          
            pickup(); drop();

        }
                
      

    }
    void pickup()
    {
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.position = guide.transform.position;
       // item.transform.rotation = guide.transform.rotation;
        item.transform.parent = tempParent.transform;
        
    }
    void drop()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.parent = null;
        if (twoToOne == true)
        {
            item.transform.position = oneStart.transform.position;
          
            
        }
        else if (threeToFour == true)
        {
            item.transform.position = fourStart.transform.position;
           
          
        }
        else if (sixToFive == true)
        {
            item.transform.position = fiveStart.transform.position;
          
          
        }
        
    }
    void findNearestItem()
    {
        item=GameObject.FindGameObjectsWithTag("snack").Aggregate((o1, o2) =>
        Vector3.Distance(o1.transform.position, this.transform.position) >
        Vector3.Distance(o2.transform.position, this.transform.position) ? o2 : o1);

    }
}

using UnityEngine;
using System.Collections;

public class CenterMid : MonoBehaviour {

    private PickAtCenter pick;
    public GameObject centerMan;
    public float speed=5;
    public Transform cmPosition;

    // Update is called once per frame
    public void OnClickCenterMid()
    {
        pick = GameObject.Find("CenterMan").GetComponent<PickAtCenter>();
     
       centerMan.transform.position = cmPosition.position;
        pick.twoToOne = false;
        pick.threeToFour = true;
        pick.sixToFive = false;
    }
   
}

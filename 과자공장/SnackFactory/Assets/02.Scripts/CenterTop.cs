using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CenterTop : MonoBehaviour {

    public PickAtCenter pick;
    public GameObject centerMan;
    public float speed;
    public Transform ctPosition;
	
	// Update is called once per frame
	public void OnClickCenterTop () {
        pick = GameObject.Find("CenterMan").GetComponent<PickAtCenter>();
        //centerMan.transform.position = Vector3.MoveTowards(centerMan.transform.position, ctPosition.position, speed * Time.deltaTime);
        centerMan.transform.position = ctPosition.position;
        pick.twoToOne = true;
        pick.threeToFour = false;
        pick.sixToFive = false;
	}
}

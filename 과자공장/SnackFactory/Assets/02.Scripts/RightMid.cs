using UnityEngine;
using System.Collections;

public class RightMid : MonoBehaviour {
    public PickAtRight pick;
    public GameObject rightMan;
    public Transform rmPosition;
	
    public void OnClickRightMid()
    {
        pick = GameObject.Find("RightMan").GetComponent<PickAtRight>();
        rightMan.transform.position = rmPosition.position;
        pick.fourToSix = false;

    }
}

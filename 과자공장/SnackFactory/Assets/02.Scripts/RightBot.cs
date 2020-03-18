using UnityEngine;
using System.Collections;

public class RightBot : MonoBehaviour {
    public PickAtRight pick;
    public GameObject RightMan;
    public Transform rbPosition;

    public void OnClickRightBot()
    {
        pick = GameObject.Find("RightMan").GetComponent<PickAtRight>();
        RightMan.transform.position = rbPosition.position;
        pick.fourToSix = true;
    }
}

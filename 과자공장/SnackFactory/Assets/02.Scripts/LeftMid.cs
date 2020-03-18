using UnityEngine;
using System.Collections;

public class LeftMid : MonoBehaviour {

    public PickAtLeft pick;
    public GameObject leftMan;
    //public float speed;
    public Transform lmPosition;


	public void OnClickLeftMid()
    {
        pick = GameObject.Find("LeftMan").GetComponent<PickAtLeft>();
        leftMan.transform.position = lmPosition.position;
        pick.oneToThree = true;
        pick.fiveToEnd = false;
    }
}

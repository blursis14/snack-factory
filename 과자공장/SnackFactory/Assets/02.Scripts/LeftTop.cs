using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LeftTop : MonoBehaviour {

    public PickAtLeft pick;
    public GameObject leftMan;
    //public float speed;
    public Transform ltPosition;

	public void OnClickLeftTop()
    {
        pick = GameObject.Find("LeftMan").GetComponent<PickAtLeft>();
        leftMan.transform.position = ltPosition.position;
        pick.oneToThree = false;
        pick.fiveToEnd = false;

    }
}

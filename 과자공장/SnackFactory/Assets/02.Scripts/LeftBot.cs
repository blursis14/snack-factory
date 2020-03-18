using UnityEngine;
using System.Collections;

public class LeftBot : MonoBehaviour {

    public PickAtLeft pick;
    public GameObject leftMan;
    //public float speed;
    public Transform lbPosition;

    public void OnClickLeftBot()
    {
        pick = GameObject.Find("LeftMan").GetComponent<PickAtLeft>();
        leftMan.transform.position = lbPosition.position;
        pick.fiveToEnd = true;
        pick.oneToThree = false;
    }

}

using UnityEngine;
using System.Collections;

public class CenterBot : MonoBehaviour {
   public PickAtCenter pick;
    public GameObject centerMan;
    //public float speed;
    public Transform cbPosition;

    // Update is called once per frame
    public void OnClickCenterBot()
    {
        pick = GameObject.Find("CenterMan").GetComponent<PickAtCenter>();
        //centerMan.transform.position = Vector3.MoveTowards(centerMan.transform.position, cbPosition.position, speed * Time.deltaTime);클릭시에만쪼꼼움직이게돼서일단제치고
        centerMan.transform.position = cbPosition.position;
        pick.twoToOne = false;
        pick.threeToFour = false;
        pick.sixToFive = true;
    }
}

using UnityEngine;
using System.Collections;

public class CreateSnack : MonoBehaviour {

    public Transform inputPosition;
    public GameObject item;
    private float period;
    private float timer;
   
	// Use this for initialization
	void Start () {
       
        period = 13f;
        InvokeRepeating("NextPeriod", 10f,10f );
        Instantiate(item, inputPosition.position, inputPosition.rotation);
        timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= period)
        {
            timer = 0f;
            Create();
        }
    }
    void Create()
    {
        Instantiate(item, inputPosition.position, inputPosition.rotation);

    }
    void NextPeriod()
    {
        period -= 1f;
        
    }

}

using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

     
	void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject, 0f);
        GetComponent<SceneTrans1>().SceneGameover();
    }
}

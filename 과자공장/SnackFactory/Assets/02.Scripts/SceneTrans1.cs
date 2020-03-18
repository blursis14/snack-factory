using UnityEngine;
using System.Collections;

public class SceneTrans1 : MonoBehaviour {

	public void SceneMenu()
    {
        Application.LoadLevel("menu");
    }

    public void Scene06()
    {
        Application.LoadLevel("07");
    }
    
    public void SceneGameover()
    {
        Application.LoadLevel("gameover");
    }
}

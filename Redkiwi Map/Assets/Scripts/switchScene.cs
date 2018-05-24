using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour {

    // Change the Scene when called inside unity. This can also be attached to a specific object.
    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown (KeyCode.P))
        {
            SceneManager.LoadScene("introductionScene");
        }
    }
}

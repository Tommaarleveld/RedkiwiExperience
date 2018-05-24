using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour {

    private PlayerController playerController;

    // Change the Scene when called inside unity. This can also be attached to a specific object.
    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    // Use this for initialization
    void Start () {
        playerController = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown (KeyCode.P))
        {
            playerController.savePlayerPosition(); 
            SceneManager.LoadScene("introductionScene");
        }
    }
}

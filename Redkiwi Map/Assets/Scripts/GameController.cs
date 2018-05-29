using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    private PlayerController playerController;
    public GameObject player;

	// Use this for initialization
	void Start () {
        playerController = FindObjectOfType<PlayerController>();

        player.gameObject.transform.position = playerController.getLastPlayerPostion();
	}
	
	// Update is called once per frame  
	void Update () {
		
	}

    void OnApplicationQuit()
    {
        playerController.savePlayerPosition();
    }
}

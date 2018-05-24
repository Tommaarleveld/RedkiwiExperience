using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Vector3 playerPosition;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        playerPosition = this.transform.position;
    }

    public Vector3 getLastPlayerPostion()
    {
        float x = PlayerPrefs.GetFloat("playerPositionX");
        float y = PlayerPrefs.GetFloat("playerPositionY");
        float z = PlayerPrefs.GetFloat("playerPositionZ");

        Vector3 lastPlayerPostition = new Vector3(x,y,z);

        return lastPlayerPostition;
    }

    public void savePlayerPosition()
    {
        PlayerPrefs.SetFloat("playerPositionX", playerPosition.x);
        PlayerPrefs.SetFloat("playerPositionY", playerPosition.y);
        PlayerPrefs.SetFloat("playerPositionZ", playerPosition.z);
    }
}

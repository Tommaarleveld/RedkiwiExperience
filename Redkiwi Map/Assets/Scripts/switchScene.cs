using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour {

    private PlayerController playerController;
    private Collider2D playerCollider, myCollider;
    private GameObject player, child;
    private string sceneName;

    // Change the Scene when called inside unity. This can also be attached to a specific object.
    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    // Use this for initialization
    void Start () {
        playerController = FindObjectOfType<PlayerController>();

        if (this.transform.childCount > 0)
        {
            child = this.transform.GetChild(0).gameObject;
            child.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
            child.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 50; 
        }
    
        if (GameObject.Find("Player") != null)
        {
            player = GameObject.Find("Player");
            playerCollider = player.GetComponent<Collider2D>();
        }
        myCollider = this.GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown (KeyCode.P))
        {
            playerController.savePlayerPosition(); 
            SceneManager.LoadScene("introductionScene");
        }

        checkCollision();
    }

    public void Back()
    {
        SceneManager.LoadScene("Scene");
    }

    public void checkCollision()
    {
        if (playerCollider != null)
        {
            if (playerCollider.bounds.Intersects(myCollider.bounds))
            {
                child.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (transform.childCount > 0)
                    {
                        sceneName = transform.GetChild(1).name;

                        playerController.savePlayerPosition();
                        SceneManager.LoadScene(sceneName);
                    }
                }
            }
            else
            {
                if (child != null)
                {
                    child.SetActive(false);
                }
            }
        }
    }
}

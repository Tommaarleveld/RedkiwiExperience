using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour {

    private GameObject vacanyText;
    private Collider2D playerCollider, vacancyCollider;
    private bool pageEnabled = false;

    public GameObject player, vacany;

	// Use this for initialization
	void Start () {
        playerCollider = player.GetComponent<Collider2D>();
        vacancyCollider = vacany.GetComponent<Collider2D>();

        vacanyText = vacany.transform.GetChild(0).gameObject;
        vacanyText.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
        vacanyText.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 50;

        GameObject text = vacanyText.transform.GetChild(1).gameObject;

        text.gameObject.GetComponent<MeshRenderer>().sortingLayerName = "Foreground";
        text.gameObject.GetComponent<MeshRenderer>().sortingOrder = 60;
	}
	
	// Update is called once per frame
	void Update () {
        checkCollision();

        if (pageEnabled == true)
        {
            openWebPage();
        }
	}

    private void checkCollision()
    {
        if (playerCollider.bounds.Intersects(vacancyCollider.bounds))
        {
            vacanyText.SetActive(true);
            if (Input.GetKeyDown("e"))
            {
                pageEnabled = true;
                ToDoList.task5 = true;
            }
        }
        else
        {
            vacanyText.SetActive(false);    
        }
    }

    private void openWebPage()
    {
        pageEnabled = false;
        Application.OpenURL("https://www.redkiwi.nl/werken-bij-redkiwi/");    
        ToDoList.task5 = true;
    }
}

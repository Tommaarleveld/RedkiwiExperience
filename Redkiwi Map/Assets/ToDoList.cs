using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDoList : MonoBehaviour {

    public static bool toDoListIsOpen = false;

    public GameObject toDoListUI;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.T)){
            if(toDoListIsOpen){
                Resume();
            }else{
                Pause();
            }
        }
	}

    void Pause(){
        toDoListUI.SetActive(true);
        Time.timeScale = 0f;
        toDoListIsOpen = true;
    }

    public void Resume(){
        toDoListUI.SetActive(false);
        Time.timeScale = 1f;
        toDoListIsOpen = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToDoList : MonoBehaviour {

    public static bool toDoListIsOpen = false;

    public static bool task1 = false;
    public static bool task2 = false;
    public static bool task3 = false;
    public static bool task4 = false;
    public static bool task5 = false;

    public GameObject toDoListUI;

    public Toggle toDoListTask1;
    public Toggle toDoListTask2;
    public Toggle toDoListTask3;
    public Toggle toDoListTask4;
    public Toggle toDoListTask5;
	
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

        if(task1){
            toDoListTask1.isOn = true;
        }
        if(task2){
            toDoListTask2.isOn = true;
        }
        if(task3){
            toDoListTask3.isOn = true;
        }
        if (task4)
        {
            toDoListTask4.isOn = true;
        }
        if (task5)
        {
            toDoListTask5.isOn = true;
        }
    }

    public void Resume(){
        toDoListUI.SetActive(false);
        Time.timeScale = 1f;
        toDoListIsOpen = false;
    }
}

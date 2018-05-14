using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Animator animator;

	private Vector2 direction;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		GetInput ();
		Move ();
	}

	public void Move(){
		//Makes sure that the player moves
		transform.Translate (direction*speed*Time.deltaTime);

		if (direction.x != 0 || direction.y != 0) {
			//Animates the players movement
			AnimateMovement (direction);
		} 
		else {
			animator.SetLayerWeight (1, 0);
		}


	}

	private void GetInput(){

		direction = Vector2.zero;

		if (Input.GetKey (KeyCode.W)) {
			direction += Vector2.up;
		}
		if (Input.GetKey (KeyCode.A)) {
			direction += Vector2.left;
		}
		if (Input.GetKey (KeyCode.S)) {
			direction += Vector2.down;
		}
		if (Input.GetKey (KeyCode.D)) {
			direction += Vector2.right;
		}
	}

	public void AnimateMovement(Vector2 direction){
		animator.SetLayerWeight (1, 1);

		//Sets the animation paramater so that the player faces the correct direction
		animator.SetFloat ("x", direction.x);
		animator.SetFloat ("y", direction.y);
	}
}

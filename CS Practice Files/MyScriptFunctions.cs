using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

	//used to print form multiple places from same function
	void Awake (){
		Debug.Log ("Printed from awake");
	}

	// Use this for initialization
	void Start () {

		//using the four types
		printSomething ();
		printArgument ("printed from argumet");
		printArgument ("The value returned: " + returnTheValue());
		Debug.Log ("The value of the two numbers is: " + calculateTwoNumbers(3,6));
		//showing reuse of same functions multiple times
		Debug.Log ("The value of the two numbers is: " + calculateTwoNumbers(10,4));
		Debug.Log ("The value of the two numbers is: " + calculateTwoNumbers(3,2));
		Debug.Log ("The value of the two numbers is: " + calculateTwoNumbers(4,6));

	}

	/*
	 *  4 types of functions:
	 * 1. takes no argument and returns no value
	 * 2. takes argument and returns no value
	 * 3. takes no argument and returns value
	 * 4. takes argument and return value
	 * 
	 * uses void if returnd nothing. 
	 * uses the type returning if returns value
	*/


	//(type 1) function called to print log to screen
	void printSomething(){
		Debug.Log ("Printed from function");
	}

	//(type 2) function called to print log to screen
	void printArgument(string message){
		Debug.Log (message);
	}

	//(type 3) function called to return value
	int returnTheValue() {
		return 2;
	}

	//(type 4) function called to return value after taking value
	int calculateTwoNumbers (int a, int b) {
		int c = a + b;
		return c;
		// this works to: return a + b;
	}


	// Update is called once per frame
	void Update () {

	}

}//end of file

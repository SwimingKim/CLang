using UnityEngine;
using System.Collections;

public class LogicalOperator : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int age = 19;
		if (age < 20 || age>=65) {
			Debug.Log ("할인대상입니다");
		} 

		if (age >= 30 && age < 40) {
			Debug.Log ("30대입니다");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

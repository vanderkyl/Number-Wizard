using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberGenerator : MonoBehaviour {

	public Text text;
	public int number;
	// Use this for initialization
	void Start () {
		number = 500;
		text.text = "Is this your number?\n\n" + number;
	}
	
	// Update is called once per frame
	void Update () {

	}
}

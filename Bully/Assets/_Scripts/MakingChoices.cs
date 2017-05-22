using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MakingChoices : MonoBehaviour {

	private GameObject bully;
	public Canvas options;
	public Text one, two, three;
	// Use this for initialization
	void Start () {
		bully = GameObject.Find ("Trigger_Bully");
		options.enabled = false;
		//one = GetComponent<Text> ();
	//	two = GetComponent<Text> ();
		//three = GetComponent<Text> ();
	}

	void OnTriggerEnter(Collider c)
	{
		if(c.transform.name.Equals("Player"))
			options.enabled = true;
	}
		
	
	// Update is called once per frame
	void Update () {
		int state = bully.GetComponent<Bully_Interaction_Trigger> ().state;

		if (state == 0) {
			//do nothing
		} else if (state == 1) {
			one.text = "1. Smarter than you!";
			two.text = "2. Move it already";
			three.text = "3. I'm gonna get a teacher";
		} else if (state == 2) {
			one.text = "1. Move it!";
			two.text = "2. She's not letting me through";
			three.text = "3. No.  I'm sorry.  Please let me through";
		} else if (state == 3) {
			one.text = "1. Fine! I'll find another way.";
			two.text = "2. Teacher! She's not letting me through.";
			three.text = "3. Just move already!";
		} else if (state == 4) {
			one.text = "1. Excuse me, she's not letting me through.";
			two.text = "2. I rather be a tattletale than a bully";
			three.text = "3. Why do you have to be so mean?";
		} else if (state == 5) {
			one.text = "1. Why do you have to be so mean?";
			two.text = "2. I rather be a bully than a tattletale";
			three.text = "3. Ok, I will";
		} else if (state == 6) {
			one.text = "1. You have our places mixed up";
			two.text = "2. If you weren't so mean, I would want to be your friend";
			three.text = "3. Excuse me, she's being mean";
		} else if (state == 7) {
			one.text = "1. Well nobody likes a bully!";
			two.text = "2. That's not true.  You're just being mean.";
			three.text = "3. Teacher, she's not letting me through";
		} else if (state == 8) {
			one.text = "1. Teacher, she's not letting me through";
			two.text = "2. I don't want to, but your not letting me through";
			three.text = "3. Just move already!";
		} else if (state == 9) {
			one.text = "1. Well I really like this dress!";
			two.text = "2. No, I got it from Macy's.  They have really cute stuff there";
			three.text = "3. What's that supposed to mean?";
		} else if (state == 10) {
			one.text = "1. It would look even better on you! You're so pretty!";
			two.text = "2. I like it and that's all that matters";
			three.text = "3. Take that back!";
		} else if (state == 11) {
			one.text = "1. WE should go shopping together. They had dresses that would look good on you!";
			two.text = "2. This is my favorite! Take that back!";
			three.text = "3. Teacher, she's being mean";
		} else if (state == 12) {
			one.text = "1. You're the one wearing something ugly!";
			two.text = "2. It's not ugly. I think it's cute!";
			three.text = "3. Teacher, she said my dress is ugly!";
		}
			
	}

	void OnTriggerExit(Collider c)
	{
		options.enabled = false;
	}
}

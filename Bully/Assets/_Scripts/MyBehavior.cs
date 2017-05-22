using UnityEngine;
using System.Collections;

public class MyBehavior : MonoBehaviour {

	public int answer = 0;
	private float delay,clipDelay;
	private GameObject bully;
	private AudioSource victimSpeak;
	public AudioClip victimClip;

	void Start () 
	{
		delay = Time.time;
		bully = GameObject.Find ("Trigger_Bully");

		victimSpeak = GetComponent<AudioSource> ();
	}
	
	void Update ()
	{
		//saves 1 as answer and goes through next answer 1 branch ->could fix by giving all diff numbers
		int state = bully.GetComponent<Bully_Interaction_Trigger> ().state;
		//bool transition1 = GetComponent<ChoiceTransitionScript> ().transitionOne;
		//bool transition2 = GetComponent<ChoiceTransitionScript> ().transitionTwo;
		//bool transition3 = GetComponent<ChoiceTransitionScript> ().transitionThree;
		//check state first
		//each state has three answers lead to different routes
		//If state = ?
		//if answer 1
		//else if 2...
		if (state == 0) {
			if (Input.GetKey("1")) {
				answer = 1;
				victimClip = (AudioClip)Resources.Load ("Victim Stupid Face");
				Response ();

				//delay = Time.time + 5;
			} 
			else if (Input.GetKey ("2") ) {
				answer = 2;
				delay = Time.time + 5;
				victimClip = (AudioClip)Resources.Load ("Victim Tell a Teacher");
				Response ();
			} 
			else if (Input.GetKey ("3")) {
				answer = 3;
				delay = Time.time + 5;
				victimClip = (AudioClip)Resources.Load ("Victim No Picked it Myself");
				Response ();
			}
		}
		if (state == 1) {
			if (Input.GetKey ("1") ) {
				answer = 4;
				victimClip = (AudioClip)Resources.Load ("Victim Smarter Than You");
				delay = Time.time + 5;
				Response ();
			}
			else if (Input.GetKey ("2") ) {
				answer = 5;
				victimClip = (AudioClip)Resources.Load ("Victim Just Move already"); //had one said just let me through need to find
				delay = Time.time + 5;
				Response ();
			}
			else if (Input.GetKey ("3") ) {
				answer = 6;
				victimClip = (AudioClip)Resources.Load ("Victim Get a Teacher");
				delay = Time.time + 5;
				Response ();
			}
		}
		if (state == 2) {
			if (Input.GetKey ("1") ) {
				answer = 7;
				victimClip = (AudioClip)Resources.Load ("Victim Move It");
				delay = Time.time + 5;
				Response ();
			} 
			else if (Input.GetKey ("2") ) {
				answer = 8;
				victimClip = (AudioClip)Resources.Load ("Victim She's not letting me through");
				delay = Time.time + 5;
				Response ();
			}
			else if (Input.GetKey ("3") ) {
				answer = 9;
				victimClip = (AudioClip)Resources.Load ("Victim No Sorry Please Let Me Through");
				delay = Time.time + 5;
				Response ();
			}
		}
		if (state == 3) 
		{
			if (Input.GetKey ("1") ) {
				answer = 10;
				victimClip = (AudioClip)Resources.Load ("Victim Another Way");
				delay = Time.time + 5;
				Response ();
			}
			else if (Input.GetKey ("2") ) {
				answer = 11;
				victimClip = (AudioClip)Resources.Load ("Victim Teacher She's not Letting Me Through");
				delay = Time.time + 5;
				Response ();
			} 
			else if (Input.GetKey ("3") ) {
				answer = 12;
				victimClip = (AudioClip)Resources.Load ("Victim Just Move already");
				delay = Time.time + 5;
				Response ();
			}
		}
		if (state == 4)
		{
			if (Input.GetKey ("1") ) {
				answer = 13;
				victimClip = (AudioClip)Resources.Load ("Victim Excuse Me");
				delay = Time.time + 5;
				Response ();
			}
			else if (Input.GetKey ("2") ) {
				answer = 14;
				victimClip = (AudioClip)Resources.Load ("Victim Rather Be a Tattletale");
				delay = Time.time + 5;
				Response ();
			} 
			else if (Input.GetKey ("3") ) {
				answer = 15;
				victimClip = (AudioClip)Resources.Load ("Victim Why so Mean");
				delay = Time.time + 5;
				Response ();
			}
		}
		if (state == 5) {
			if (Input.GetKey ("1") ) {
				answer = 16;
				victimClip = (AudioClip)Resources.Load ("Victim Why so Mean");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("2") ) 
			{
				answer = 17;
				victimClip = (AudioClip)Resources.Load ("Victim Rather Be a Tattletale");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("3") ) {
				answer = 18;
				victimClip = (AudioClip)Resources.Load ("Victim Ok I Will");
				delay = Time.time + 5;
				Response ();
			}
		}
		if (state == 6) {
			if (Input.GetKey ("1") ) {
				answer = 19;
				victimClip = (AudioClip)Resources.Load ("Victim Places Mixed");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("2") ) {
				answer = 20;
				victimClip = (AudioClip)Resources.Load ("Victim If you Weren't Mean");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("3") ) {
				answer = 21;
				victimClip = (AudioClip)Resources.Load ("Victim Excuse Me");
				delay = Time.time + 5;
				Response ();
			}
		}
		if (state == 7) {
			if (Input.GetKey ("1") ) {
				answer = 22;
				victimClip = (AudioClip)Resources.Load ("Victim Nobody Likes a Bully");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("2") ) {
				answer = 23;
				victimClip = (AudioClip)Resources.Load ("Victim Not True");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("3") ) {
				answer = 24;
				victimClip = (AudioClip)Resources.Load ("Victim Teacher She's not Letting Me Through");
				delay = Time.time + 5;
				Response ();
			}
		}
		if (state == 8) {
			if (Input.GetKey ("1") ) {
				answer = 25;
				victimClip = (AudioClip)Resources.Load ("Victim Teacher She's not Letting Me Through");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("2") ) {
				answer = 26;
				victimClip = (AudioClip)Resources.Load ("Victim I don't want to");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("3") ) {
				answer = 27;
				victimClip = (AudioClip)Resources.Load ("Victim Move already");
				delay = Time.time + 5;
				Response ();
			}
		}
		if (state == 9) {
			if (Input.GetKey ("1") ) {
				answer = 28;
				victimClip = (AudioClip)Resources.Load ("Victi I really Like Dress");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("2") ) {
				answer = 29;
				victimClip = (AudioClip)Resources.Load ("Victim Macy's");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("3")) {
				answer = 30;
				victimClip = (AudioClip)Resources.Load ("Victim What's that supposed To Mean");
				delay = Time.time + 5;
				Response ();
			}
		}
		if (state == 10) {
			if (Input.GetKey ("1")) {
				answer = 31;
				victimClip = (AudioClip)Resources.Load ("Victim Look Better On You");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("2")) {
				answer = 32;
				victimClip = (AudioClip)Resources.Load ("Victim I like it and that's all that matters");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("3")) {
				answer = 33;
				victimClip = (AudioClip)Resources.Load (""); // idk where it went?
				delay = Time.time + 5;
				Response ();
			}
		}
		if (state == 11) {
			if (Input.GetKey ("1") ) {
				answer = 34;
				victimClip = (AudioClip)Resources.Load ("");//gone
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("2") ) {
				answer = 35;
				victimClip = (AudioClip)Resources.Load ("");//gone
				Response ();
				delay = Time.time + 5;
			} else if (Input.GetKey ("3")) {
				answer = 36;
				victimClip = (AudioClip)Resources.Load ("Victim Excuse Me");
				delay = Time.time + 5;
				Response ();
			}
		}
		if (state == 12) {
			if (Input.GetKey ("1")) {
				answer = 37;
				victimClip = (AudioClip)Resources.Load ("Victim You're the one wearing something ugly");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("2")) {
				answer = 38;
				victimClip = (AudioClip)Resources.Load ("Victim it's not ugly");
				delay = Time.time + 5;
				Response ();
			} else if (Input.GetKey ("3") ) {
				answer = 39;
				victimClip = (AudioClip)Resources.Load ("Victim She said my dress is ugly");
				delay = Time.time + 5;
				Response ();
			}
		}
	}
	void Response(){
		if (victimClip != null)
		{
			//clipDelay = 8.2f;
			if (!victimSpeak.isPlaying)
			{
				victimSpeak.PlayOneShot(victimClip);

				//StartCoroutine(ExecuteAfterTime(clipDelay));
			}
		}
	}
}

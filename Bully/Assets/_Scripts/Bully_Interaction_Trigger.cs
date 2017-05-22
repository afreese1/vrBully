using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Bully_Interaction_Trigger : MonoBehaviour 
{
	public AudioClip bullyClip, laughterClip;
	private AudioSource bullySpeak, kidsSpeak;
	private float clipDelay;

	//public int ans=0;
	//private GameObject victim;

	public int state = 0;

	void Start()
	{
		GameObject bully = GameObject.Find("RigHead");
		bullySpeak = bully.GetComponent<AudioSource>();

		GameObject kids = GameObject.Find("Bip01Head");
		kidsSpeak = kids.GetComponent<AudioSource>();

		//victim = GameObject.Find ("Player");

		clipDelay = 0.0f;
		state = 0;
	}

	//void Update()
	//{
	//	ans = victim.GetComponent<ChoiceTransitionScript> ().answer;
	//}

	void OnTriggerEnter(Collider c) //have to keep moving in and out of trigger in order to progress conversation.  is there a way to more smoothly progress convo with bully?
	{
		Debug.Log("State: " + state);
		if (c.transform.name.Equals ("Player"))
		{
			//int ans = c.transform.GetComponent<ChoiceTransitionScript> ().answer;
			int ans = c.transform.GetComponent<MyBehavior>().answer;

			if (state == 0 && ans == 0) {	
				bullyClip = (AudioClip)Resources.Load ("Bully School Main");
				//state++;
			} else if (state == 0 && ans == 1) {
				bullyClip = (AudioClip)Resources.Load ("Bully So smart");
				state = 1;
			} else if (state == 0 && ans == 2) {
				bullyClip = (AudioClip)Resources.Load ("Bully Fine Tell on Me Tattletale");
				state = 5;
			} else if (state == 0 && ans == 3) {
				bullyClip = (AudioClip)Resources.Load ("Bully Target");
				state = 9;
			}
			else if (state == 1 && ans == 4) {
				bullyClip = (AudioClip)Resources.Load ("Bully Little Miss Perfect");
				state = 2;
			}
			else if (state == 1 && ans == 5) {
				bullyClip = (AudioClip)Resources.Load ("Bully You're Not Going Anywhere");
				state = 3;
			}
			else if (state == 1 && ans == 6) {
				bullyClip = (AudioClip)Resources.Load ("Bully Fine Tell on Me Tattletale");
				state = 4;
			}
			else if (state == 5 && ans == 16) {
				bullyClip = (AudioClip)Resources.Load ("Bully Put You in Your Place");
				state = 6;
			}
			else if (state == 5 && ans == 17) {
				bullyClip = (AudioClip)Resources.Load ("Bully Nobody Likes a Tattletale");
				state = 7;
			}
			else if (state == 5 && ans == 18) {
				bullyClip = (AudioClip)Resources.Load ("Bully Are you Serious");
				state = 8;
			}
			else if (state == 9 && ans == 28) {
				bullyClip = (AudioClip)Resources.Load ("Bully Doesn't Look Good");
				state = 10;
			}
			else if (state == 9 && ans == 29) {
				bullyClip = (AudioClip)Resources.Load ("Bully Obviously Don't Since You're Wearing That");
				state = 11;
			}
			else if (state == 9 && ans == 30) {
				bullyClip = (AudioClip)Resources.Load ("Bully Dress is Ugly");
				state = 12;
			}
			else if (state == 2 && ans == 7) {
				bullyClip = (AudioClip)Resources.Load ("");
				//fight teacher breaks up sent to pincipal
				state = 13;
			}
			else if (state == 2 && ans == 8) {
				//teacher is there a problem
				bullyClip = (AudioClip)Resources.Load ("Bully She Called Me Dumb");
				//teacher
				state = 14;
			}
			else if (state == 2 && ans == 9) {
				bullyClip = (AudioClip)Resources.Load ("Bully Not a Chance");
				//teacher
				state = 15;			}
			else if (state == 3 && ans == 10) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 16;
			}
			else if (state == 3 && ans == 11) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 17;
			}
			else if (state == 3 && ans == 12) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 18;
			}
			else if (state == 4 && ans == 13) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 19;
			}
			else if (state == 4 && ans == 14) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 20;
			}
			else if (state == 4 && ans == 15) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 21;
			}
			else if (state == 6 && ans == 19) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 22;
			}
			else if (state == 6 && ans == 20) {
				bullyClip = (AudioClip)Resources.Load ("Bully Really");
				state = 23;
				//"good ending"
			}
			else if (state == 6 && ans == 21) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 24;
			}
			else if (state == 7 && ans == 22) {
				bullyClip = (AudioClip)Resources.Load ("");
				//push
				//teacher
				state = 25;
			}
			else if (state == 7 && ans == 23) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 26;
			}
			else if (state == 7 && ans == 24) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 27;
			}
			else if (state == 8 && ans == 25) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 28;
			}
			else if (state == 8 && ans == 26) {
				bullyClip = (AudioClip)Resources.Load ("Bully Fine");
				state = 29;
				//end without teacher interaction
				//lets through
			}
			else if (state == 8 && ans == 27) {
				//bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 30;
			}
			else if (state == 10 && ans == 31) {
				bullyClip = (AudioClip)Resources.Load ("Bully Play Date");
				state = 31;
				//"good ending"
			}
			else if (state == 10 && ans == 32) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 32;
			}
			else if (state == 10 && ans == 33) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 33;
			}
			else if (state == 11 && ans == 34) {
				bullyClip = (AudioClip)Resources.Load ("Bully Sounds Fun");
				state = 34;
			}
			else if (state == 11 && ans == 35) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 35;
			}
			else if (state == 11 && ans == 36) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 36;
			}
			else if (state == 12 && ans == 37) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 37;

			}
			else if (state == 12 && ans == 38) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 38;

			}
			else if (state == 12 && ans == 39) {
				bullyClip = (AudioClip)Resources.Load ("");
				//teacher
				state = 39;

			}
			else
				bullyClip = null;

			if (bullyClip != null)
			{
				clipDelay = 8.2f;
				if (!bullySpeak.isPlaying)
				{
					bullySpeak.PlayOneShot(bullyClip);
					StartCoroutine(ExecuteAfterTime(clipDelay));
				}
			}
		}


	}

	IEnumerator ExecuteAfterTime(float time)
	{
		yield return new WaitForSeconds(time);

		laughterClip = (AudioClip) Resources.Load("Giggle");

		if (!kidsSpeak.isPlaying)
			kidsSpeak.PlayOneShot(laughterClip);
		
	}
}

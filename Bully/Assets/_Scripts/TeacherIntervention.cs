using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TeacherIntervention : MonoBehaviour {

	private GameObject triggerTeacher;
	private Animator anim;

	public AudioClip teacherClip;
	private AudioSource teacherSpeak;

	private GameObject bully;

	void Start()
	{
		triggerTeacher = GameObject.Find("Teacher");
		anim = triggerTeacher.GetComponent<Animator>() as Animator;
		teacherSpeak = triggerTeacher.GetComponent<AudioSource> ();
		bully = GameObject.Find ("Trigger_Bully");
	}


	void OnTriggerEnter(Collider c)
	{
		if (c.transform.name.Equals ("Teacher"))
		{
			anim.SetTrigger("StopTrigger");
			anim.SetBool("Stop", true);
		}
			
	}


	void Update(){ //teacher continuously responds since in update, but technically only needs to call once after interactions with bully (make own method?)


		int state = bully.GetComponent<Bully_Interaction_Trigger> ().state;
		if (state == 13)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Principal's Office");
			//StartCoroutine (pause ());
			//SceneManager.LoadScene ("PrincipalOffice");
			state = 41;
		}
		else if (state == 14) 
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Problem");
			//victim
			//bully
			teacherClip = (AudioClip)Resources.Load ("Teacher Nicer to each other");
			state = 40;
		} 
		else if (state == 15) 
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Hurry Along");
			state = 40;
		} 
		else if (state == 16) 
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Hurry Along");
			state = 40;
		}
		else if (state == 17)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Chat");
			state = 40;
		}
		else if (state == 18) 
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Principal's Office");
			state = 41;
		} 
		else if (state == 19) 
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Chat");
			state = 40;
		}
		else if (state == 20)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Hurry Along");
			state = 40;
		}
		else if (state == 21) 
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Hurry Along");
			state = 40;
		}
		else if (state == 22)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Principal's Office");
			state = 41;
		}
		else if (state == 24) 
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Chat");
			state = 40;
		}
		else if (state == 25)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Principal's Office");
			state = 41;
		} 
		else if (state == 26) 
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Hurry Along");
			state = 40;
		} 
		else if (state == 27)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Chat");
			state = 40;
		} 
		else if (state == 28)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Chat");
			state = 40;
		} 
		else if (state == 30) 
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Principal's Office");
			state = 41;
		} 
		else if (state == 32) 
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Hurry Along");
			//"good end" confidence when dealing with bully
			state = 40;
		}
		else if (state == 33)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Principal's Office");
			state = 41;
		} 
		else if (state == 35)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Principal's Office");
			state = 41;
		} 
		else if (state == 36) 
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Chat");
			state = 40;
		} 
		else if (state == 37)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Nicer to each other");
			state = 40;
		} 
		else if (state == 38)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Hurry Along");
			state = 40;
		} 
		else if (state == 39)
		{
			teacherClip = (AudioClip)Resources.Load ("Teacher Chat");
			state = 40;
		}
		else
			teacherClip = null; 
			

		if (!teacherSpeak.isPlaying) {
			teacherSpeak.PlayOneShot (teacherClip);
			StartCoroutine (delayTransition (state));
		}
		
	}

	IEnumerator delayTransition(int state)
	{
		yield return new WaitForSeconds(4.0f);

		//Destroy (teacherClip);

		if (state == 41)
			SceneManager.LoadScene ("PrincipalOffice");
		else if (state==40)
			SceneManager.LoadScene ("School");
		

	}
}

using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public int coins;
	//public AudioSource mainmusic;
	public int enemyscount;
	public GameObject path1;

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start() {
		coins = 0;
		enemyscount = 0;
		//mainmusic.Play(); 
	}

	// OnTriggerEnter is called when the Collider "collided" enters the trigger.
	protected void OnTriggerEnter(Collider collided) {

		// Check for collision with coins
		if (collided.gameObject.tag == "Coin") {  
			
			Destroy(collided.gameObject);
			if (coins == 0 ) 
			{
				HUD.Message("You got first coin!");
			}
			if (coins == 9)
			{
				HUD.Message("Mission accompLished!");
			}
			else
            {
				HUD.Message("You got another coin!");

			}
			coins++;
			HUD.UpdateCoinCount(coins);
		}
		if (collided.gameObject.name == "Powerup1")
        {
			Destroy(collided.gameObject);
			Abilities.doubleJumpEnabled = true;
			HUD.Message("You got powerup!! You can jump higher!!");
        }
		if (collided.gameObject.name == "Powerup2")
		{
			Destroy(collided.gameObject);
			Abilities.spinAttackEnabled = true;
			HUD.Message("You got powerup!! You can spin Attack!!");
		}
		if (collided.gameObject.tag =="check")
        {
        if (coins == 10)
            {
				path1.SetActive(true);
            }

        }

	}
	}       
				
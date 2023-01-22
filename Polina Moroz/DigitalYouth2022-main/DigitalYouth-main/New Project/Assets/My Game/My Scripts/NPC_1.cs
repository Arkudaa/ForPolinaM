using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0", "Welcome stranger!", "1");
	    Speech.AddDialogue("1", "Collect coins here!", "2");
		Speech.AddDialogue("2","Find coins!", "3");
		Speech.AddDialogue("3","And move across the levels!");

	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){
		Speech.SetDialogue("0");
	}
}
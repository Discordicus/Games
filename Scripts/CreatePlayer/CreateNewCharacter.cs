using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour {
    private BasePlayer newPlayer;
    private bool isMageClass;
    private bool isWarriorClass;

	// Use this for initialization
	void Start () {
        newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
        if (GUILayout.Button("Create"))
        {
            if (isMageClass)
            {
                newPlayer.PlayerClass = new BaseMageClass();
            }
            else if (isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
            }
            newPlayer.PlayerLevel = 1;
            newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
            newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
            newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
            newPlayer.Strength = newPlayer.PlayerClass.Strength;

            Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("player level: " + newPlayer.PlayerLevel);
            Debug.Log("player Stamina: " + newPlayer.Stamina);
            Debug.Log("player Endurance: " + newPlayer.Endurance);
            Debug.Log("player Intellect: " + newPlayer.Intellect);
            Debug.Log("player Strength: " + newPlayer.Strength);


        }
    }
}

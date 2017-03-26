using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class SlimeStuff : MonoBehaviour {
   
 
    // Get the player, and his code
    GameObject player;
    PlayerController playerScript;

    // Use this for initialization
    void Start()
    {
        // find the player object
        player = GameObject.Find("Player");
        // gain access to this script
        playerScript = player.GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.UnloadSceneAsync("Overworld Scene");
            SceneManager.LoadSceneAsync("Battle Scene");
        }
    }

  
}


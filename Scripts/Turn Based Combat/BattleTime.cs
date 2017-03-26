using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class BattleTime : MonoBehaviour {

    
	// Use this for initialization
	void Start ()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("Battle", LoadSceneMode.Additive);
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        
    }
}

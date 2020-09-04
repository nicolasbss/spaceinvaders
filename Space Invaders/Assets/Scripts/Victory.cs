using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject aliens;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if( player == null) {
            
            SceneManager.LoadScene(3);
        }
        else if(aliens.transform.childCount == 0)
        {
            SceneManager.LoadScene(2);
        }
   
    }
}

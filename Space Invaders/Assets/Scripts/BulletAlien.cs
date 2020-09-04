using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAlien : MonoBehaviour
{   

    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.down * speed * Time.deltaTime;

    }

    void onBecameInvisivle()
    {
        Destroy(gameObject);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {   
                    
        
            SoundManager.PlaySound("gameOver");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }

        if (collision.tag == "Base")
        {   
            Destroy(gameObject);
        }
    }
}

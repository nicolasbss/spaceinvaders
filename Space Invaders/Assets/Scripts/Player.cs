using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   

    public float speed = 25.0f;
    private float bound = 8;

    private int lifes = 2;

    public GameObject bullet;

    public float wait = 0.3f;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dh =  Input.GetAxis("Horizontal");
        if (( gameObject.transform.position.x > -bound || dh > 0) &&
            ( gameObject.transform.position.x <  bound || dh < 0))
        {
            gameObject.transform.position += Vector3.right * dh * speed * Time.deltaTime;
        }


        timer += Time.deltaTime;
        if (timer > wait && Input.GetButton("Fire1"))
        {   
            SoundManager.PlaySound("laser");
            timer = 0;
            Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
        }

       
    }

    public void loseLife() {
        lifes = lifes - 1;
    }

    public int getLifes() {
        return lifes;
    }


}

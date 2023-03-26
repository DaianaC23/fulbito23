using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb_player;
    public bool canShoot;
    public GameObject _ball;
    
    



    // Start is called before the first frame update
    void Start()
    {
        rb_player = GetComponent<Rigidbody2D>();
        _ball = GameObject.FindGameObjectWithTag("Ball1");        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        if (canShoot)
        {
            _ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(400, 500));
        }
    }

 



    
}

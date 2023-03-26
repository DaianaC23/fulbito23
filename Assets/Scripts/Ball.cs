using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    private GameObject _player;
    



    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _player.GetComponent<Player>().canShoot = true;
        }

        if (collision.gameObject.tag == "Ground")
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }

        if (collision.gameObject.tag == "Goals")
        {
            if (GameController.instance.isScore == false && GameController.instance.endMatch == false)
            {
                GameController.instance.numberGol++;
                GameController.instance.isScore = true;                
                StartCoroutine(ContinueMatch());
            }          

        }


    }

  

    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _player.GetComponent<Player>().canShoot = false;
        }
      
    }


    IEnumerator ContinueMatch()
    {
        yield return new WaitForSeconds(1f);
        GameController.instance.isScore = false;
        if (GameController.instance.endMatch == false)
        {
            transform.position = new Vector3(-7, 0, 0);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }     
    }


}

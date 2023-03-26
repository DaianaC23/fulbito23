using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSwipe : MonoBehaviour
{
    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;
    


    [Range(0.05f, 1f)]
    public float trowForse = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchTimeFinish = Time.time;
            timeInterval = touchTimeFinish - touchTimeStart;
            endPos = Input.GetTouch(0).position;
            direction = startPos - endPos;
            GetComponent<Rigidbody2D>().AddForce(-direction / timeInterval * trowForse);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
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

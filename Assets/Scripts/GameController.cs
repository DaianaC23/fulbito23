using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Text text;
    public Text lifeText;
    public int numberGol;
    public int lifes;
    public float holyKickCharge;
    public bool isScore, endMatch;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public GameController GetInstance
    {
        get
        {
            return instance;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = numberGol.ToString();
        lifeText.text = lifes.ToString();
    }
}

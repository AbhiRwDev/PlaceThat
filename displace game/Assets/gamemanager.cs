using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    public int gamestate,finalstate;
    public GameObject winpanel;

    // Start is called before the first frame update
    void Start()
    {
        winpanel = GameObject.FindGameObjectWithTag("winpanel");
        GameObject.FindGameObjectWithTag("winpanel").SetActive(false);
        gamestate = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(gamestate==finalstate)
        {
           
            Invoke("win", 0);
        }
    }
    public void win()
    {
        winpanel.SetActive(true);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainchanger : MonoBehaviour
{
    public Sprite[] states=new Sprite[4];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = states[FindObjectOfType<gamemanager>().gamestate];
    }
}

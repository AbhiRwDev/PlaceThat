using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragobjectscript : MonoBehaviour
{
    public Vector3 finalpos, startpos;
    public float dist,range;
    public bool shoulddisable;
    public int optionno;
    // Start is called before the first frame update
   
    void OnMouseDrag()
    {
        if (optionno == 1 && FindObjectOfType<gamemanager>().gamestate == 0)
        {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2f);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
        }
        if (optionno==2&&FindObjectOfType<gamemanager>().gamestate==1)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2f);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            transform.position = objPosition;
        }
        if (optionno == 3 && FindObjectOfType<gamemanager>().gamestate == 2)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2f);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            transform.position = objPosition;
        }

       
    }

    private void Update()
    {
       dist= Vector2.Distance(transform.position,finalpos);
        
    }
    private void OnMouseUp()
    {
       if(dist<range)
        {
            transform.position = finalpos;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            if(shoulddisable==true)
            {
                gameObject.SetActive(false);
            } 
            FindObjectOfType<gamemanager>().gamestate += 1;
        }
        else
        {
            transform.position = startpos;
        }
    }

}

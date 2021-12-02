using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class leveltextchanger : MonoBehaviour
{
    public string[] texts = new string[5];
    public int one;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       gameObject.GetComponent<TextMeshProUGUI>().text = texts[SceneManager.GetActiveScene().buildIndex];
    }
}

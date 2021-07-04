using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Controller : MonoBehaviour
{
    
    public int apple;
    public TextMeshProUGUI appleText;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("apple"))
        {
            apple=PlayerPrefs.GetInt("apple");
            appleText.text = "Apple :" + apple.ToString();
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        appleText.text = "Apple :" + apple.ToString();


    }
    public void AppleUp()
    {
        apple++;
        PlayerPrefs.SetInt("apple", apple);
    }
    public void AppleDown()
    {
        apple--;
        PlayerPrefs.SetInt("apple", apple);
    }
 
}

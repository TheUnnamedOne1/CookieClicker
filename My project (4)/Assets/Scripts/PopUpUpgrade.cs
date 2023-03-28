using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopUpUpgrade : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void popUp1()
    {
        if (GameManager.upgrades1 >= 4)
        {
            button.gameObject.SetActive(true);
        } 
    }
}

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


    public void popUp1()
    {   
        if (((GameManager.upgrades1 == 5) && GameManager.upgrades1 <= 6) && GameManager.currentScore >= 0)
        {
            button.gameObject.SetActive(true);
        } 
    }

    public void popbuy1(){
        if(GameManager.currentScore>= 500){

        
        button.gameObject.SetActive(false);
        GameManager.ClickPower++;
        GameManager.currentScore -= 500;
        }
    }
}

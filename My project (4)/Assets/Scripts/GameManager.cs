using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    //Click
    public Text scoreText;
    public static double currentScore;
    public static float ClickPower;
    public float scorepersecond;
    public float x;

    //Upgrade1
    public Text Cost1;
    public double cost1 = 15;
    public Text Upgrade1;
    public static double upgrades1;
    //Upgrade2
    public Text Cost2;
    public double cost2 = 45;
    public Text Upgrade2;
    public double upgrades2;
    //Upgrade3
    public Text Cost3;
    public double cost3 = 125;
    public Text Upgrade3;
    public double upgrades3;

    public double testupgrades =upgrades1;

    // Randome Upgrade
    public Text randup1;
    public int randCost;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 725;
        ClickPower = 1;
        scorepersecond = 0;
        x = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)currentScore + "";
        scorepersecond = x * Time.deltaTime;
        currentScore = currentScore + scorepersecond;
        Cost1.text = cost1 + "";
        Upgrade1.text = upgrades1 + "";
        Cost2.text = cost2 + "";
        Upgrade2.text = upgrades2 + "";
        Cost3.text = cost3 + "";
        Upgrade3.text = upgrades3 + "";

    }

    public void click()
    {
        currentScore += ClickPower;
    }

    public void Buy1()
    {  
        if (currentScore >= cost1)
        {
            upgrades1 += 1;
            currentScore -= cost1;
            x += 1;
            cost1 += 15;
        }
    }

    public void Buy2()
    {
        if (currentScore >= cost2)
        {
            upgrades2++;
            currentScore -= cost2;
            x += 5;
            cost2 += 45;
        }
    }

    public void Buy3()
    {
        
        if (currentScore >= cost3)
        {
            upgrades3++;
            currentScore -= cost3;
            x += 10;
            cost3 += 125;
        }
    }

    











}


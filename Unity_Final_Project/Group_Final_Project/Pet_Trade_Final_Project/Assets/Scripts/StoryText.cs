using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StoryText : MonoBehaviour
{
    public double money;
    public int food = 100;
    public int water = 100;
    public int clean = 100;
    public int health = 100;
    public int bored = 100;

    public int foodNeo = 100;
    public int waterNeo = 100;
    public int cleanNeo = 100;
    public int healthNeo = 100;
    public int boredNeo = 100;

    public int foodRico = 100;
    public int waterRico = 100;
    public int cleanRico = 100;
    public int healthRico = 100;
    public int boredRico = 100;

    public int foodNed = 100;
    public int waterNed = 100;
    public int cleanNed = 100;
    public int healthNed = 100;
    public int boredNed = 100;

    public int fooTed = 100;
    public int waterTed = 100;
    public int cleanTed = 100;
    public int healthTed = 100;
    public int boredTed = 100;

    public int foodShred = 100;
    public int waterShred = 100;
    public int cleanShred = 100;
    public int healthShred = 100;
    public int boredShred = 100;

    public int decreaseStat = 0; 

    public int decreaseFood = 0;
    public int decreaseWater = 0;
    public int decreaseClean = 0;
    public int decreaseBored = 0;

    public Text textComponent;
    public State StartingState;
    public State Situation1;
    public State Situation2;
    public State Situation3;
    public State Situation4;
    public State Situation5;
    public State Situation6;

    public State StartingStateLeo;
    public State SituationLeo1;
    public State SituationLeo2;
    public State SituationLeo3;
    public State SituationLeo4;
    public State SituationLeo5;
    public State SituationLeo6;

    public State StartingStateRico;
    public State SituationRico1;
    public State SituationRico2;
    public State SituationRico3;
    public State SituationRico4;
    public State SituationRico5;
    public State SituationRico6;

    public State StartingStateNed;
    public State SituationNed1;
    public State SituationNed2;
    public State SituationNed3;
    public State SituationNed4;
    public State SituationNed5;
    public State SituationNed6;

    public State StartingStateTed;
    public State SituationTed1;
    public State SituationTed2;
    public State SituationTed3;
    public State SituationTed4;
    public State SituationTed5;
    public State SituationTed6;

    public State StartingStateShred;
    public State SituationShred1;
    public State SituationShred2;
    public State SituationShred3;
    public State SituationShred4;
    public State SituationShred5;
    public State SituationShred6;

    public Text MoneyText;
    public Text FoodText;
    public Text WaterText;
    public Text CleanText;
    public Text BoredText;
    public Text HealthText;

    State state;

   

    void Start()
    {
        //starts the game with the starting state
        state = StartingState;
        //gets the states and the text
        textComponent.text = state.GetStateStory();
        money = UnityEngine.Random.Range(1000, 2000);
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = state.GetStateStory();
        ManageState();
     
        if (money <= 0)
        {
            money = 0;
        }
        if (food >= 100)
        {
            food = 100;
        }
        if (food <= 0)
        {
            food = 0;
        }
        if (water >= 100)
        {
            water = 100;
        }
        if (water <= 0)
        {
            water = 0;
        }
        if (clean >= 100)
        {
            clean = 100;
        }
        if (clean <= 0)
        {
            clean = 0;
        }
        if (bored >= 100)
        {
            bored = 100;
        }
        if (bored <= 0)
        {
            bored = 0;
        }
        if (health >= 100)
        {
            health = 100;
        }
        if (health <= 0)
        {
            health = 0;
        }
    }

    public void  DisplayScores()
    {
        MoneyText.text = "Money: " + money.ToString("000");
        FoodText.text = "Food: " + food.ToString("000");
        WaterText.text = "Water: " + water.ToString("000");
        CleanText.text = "Cleaniness: " + clean.ToString("000");
        BoredText.text = "Bored: " + bored.ToString("000");
        HealthText.text = "Health: " + health.ToString("000");
    }

    public void ManageState()
    {
        var nextStates = state.GetNextStates();
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (state == StartingState && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = Situation1;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                food = food + 10;
                
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = Situation1;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                water = water + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = Situation1;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                clean = clean + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = Situation1;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                bored = bored + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }
        else if (state == Situation1 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = Situation2;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                food = food + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = Situation2;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                water = water + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = Situation2;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                clean = clean + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = Situation2;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                bored = bored + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

           
        }
        else if (state == Situation2 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = Situation3;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                food = food + 10;
                health = health - 25;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = Situation3;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                water = water + 10;
                health = health - 25;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = Situation3;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                clean = clean + 10;
                health = health - 25;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = Situation3;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                bored = bored + 10;
                health = health - 25;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }
        else if (state == Situation3 && sceneName == "Lizard")
        {

            
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = Situation4;

                decreaseFood = UnityEngine.Random.Range(5, 5);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1,1);

                food = food + 10;
                health = health - 25;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = Situation4;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                water = water + 10;
                health = health - 25;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = Situation4;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                clean = clean + 10;
                health = health - 25;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = Situation4;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                bored = bored + 10;
                health = health - 25;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }


        }
        else if (state == Situation4 && sceneName == "Lizard")
        {
           

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = Situation5;
            }
        }
        else if (state == Situation5 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                health = health + 25;
                state = Situation6;

            }


        }
        else if (state == Situation6 && sceneName == "Lizard")
        {
           
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                food = food + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                water = water + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                clean = clean + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                bored = bored + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }

        DisplayScores();
    }
}



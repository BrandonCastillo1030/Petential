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

    public Text MoneyText;
    public Text FoodText;
    public Text WaterText;
    public Text CleanText;

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
    }

    public void ManageState()
    {
        var nextStates = state.GetNextStates();
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (state == StartingState && sceneName == "BreederLeo")
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
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    food = food - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    food = food - decreaseBored;
                    Debug.Log(bored);
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

                food = water + 10;
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
                    food = food - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    food = food - decreaseBored;
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
                    food = food - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    food = food - decreaseBored;
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
                    food = food - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    food = food - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5) && health <= 100)
            {
                
                if(health <= 50)
                {
                    SceneManager.LoadScene("BadVet");
                }
                else if(health > 50)
                {
                    SceneManager.LoadScene("GetBetterVet");
                }
            }
        }
        else if (state == Situation1 && sceneName == "BreederLeo")
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
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    food = food - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    food = food - decreaseBored;
                    Debug.Log(bored);
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

                food = water + 10;
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
                    food = food - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    food = food - decreaseBored;
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
                    food = food - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    food = food - decreaseBored;
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
                    food = food - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    food = food - decreaseBored;
                    Debug.Log(bored);
                }
            }
            
            else if (state == Situation2 && sceneName == "BreederLeo")
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
                        food = food - decreaseClean;
                        Debug.Log(clean);
                    }
                    else if (decreaseStat == 4)
                    {
                        food = food - decreaseBored;
                        Debug.Log(bored);
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

                    food = water + 10;
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
                        food = food - decreaseClean;
                        Debug.Log(clean);
                    }
                    else if (decreaseStat == 4)
                    {
                        food = food - decreaseBored;
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
                        food = food - decreaseClean;
                        Debug.Log(clean);
                    }
                    else if (decreaseStat == 4)
                    {
                        food = food - decreaseBored;
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
                        food = food - decreaseClean;
                        Debug.Log(clean);
                    }
                    else if (decreaseStat == 4)
                    {
                        food = food - decreaseBored;
                        Debug.Log(bored);
                    }
                }
            }
            
        }
        DisplayScores();
    }
}

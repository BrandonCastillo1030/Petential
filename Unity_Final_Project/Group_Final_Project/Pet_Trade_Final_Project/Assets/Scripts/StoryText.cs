using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StoryText : MonoBehaviour
{

    public int food = 100;
    public int water = 100;
    public int clean = 100;
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

    State state;
    void Start()
    {
        //starts the game with the starting state
        state = StartingState;
        //gets the states and the text
        textComponent.text = state.GetStateStory();

    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (state == StartingState)
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
        }
       
    }
}

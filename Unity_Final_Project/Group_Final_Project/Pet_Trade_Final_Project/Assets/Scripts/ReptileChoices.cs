using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReptileChoices : MonoBehaviour
{
    private GameObject[] reptiles;
    public GameObject Leo; // Petco
    public GameObject Rico; // Petco
    public GameObject Neo; // Petco
    public GameObject Ted; // Bred
    public GameObject Ned; // Bred
    public GameObject Shred; // Bred
    void Start()
    {
        reptiles = new GameObject[4];
    }

    // Update is called once per frame
    void Update()
    {
        // Private Lizards = 1-3
        // Petco Lizards = 4-6

        while (reptiles.Length < 4)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                reptiles[reptiles.Length] = Leo;

            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                reptiles[reptiles.Length] = Rico;

            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                reptiles[reptiles.Length] = Neo;

            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                reptiles[reptiles.Length] = Ted;

            }

            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                reptiles[reptiles.Length] = Ned;

            }

            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                reptiles[reptiles.Length] = Shred;

            }
        }
    }
}

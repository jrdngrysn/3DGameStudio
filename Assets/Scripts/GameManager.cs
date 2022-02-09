using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // This is private, so that we can show an error if its not set up yet
    private static GameManager staticInstance;


    [SerializeField] private float points = 0;

    [SerializeField] private List<GameObject> arches;

    private GameObject[] archesArray;

    private int archIndex = 0;

    public static GameManager Instance
    {
        get
        {
            // If the static instance isn't set yet, throw an error
            if (staticInstance is null)
            {
                Debug.LogError("Game Manager is NULL");
            }

            return staticInstance;
        }
    }

    private void Awake()
    {
        // Set the static instance to this instance
        staticInstance = this;
    }

    public void addPoints()
    {
        points++;
    }

    public void addPoints (float pointsToAdd)
    {
        points += pointsToAdd;
    }

    public void OnArchEnter (GameObject archObject)
    {
        Debug.Log(arches.IndexOf(archObject));
        Debug.Log(archesArray);
    }
}

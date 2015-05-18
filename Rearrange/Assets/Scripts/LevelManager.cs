using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 * The Level class manages Levels
 * Holds scores for each level
 * Stores the words already found
 */
public class LevelManager : MonoBehaviour
{
    private List<string> _potentialWords;
    private List<int> _levelScores;
    private List<string> _wordsFound;

    public List<string> PotentialWords
    {
        get
        {
            return _potentialWords;
        }
    }

    public List<int> LevelScores
    {
        get
        {
            return _levelScores;
        }
    }

    public List<string> WordsFound
    {
        get
        {
            return _wordsFound;
        }
    }

    void Start()
    {
        if (!GameManager.Instance)
        {
            return;
        }
    }

    /**
     * Loads the level
     */
    public void load()
    {
        //call method to create game objects
    }

    void Update()
    {

    }
}
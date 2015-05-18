using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 * The GameManager class manages the game
 * Main menu and level screen
 * Achievements
 */
public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public Texture2D _livesIcon;
    public List<GameObject> levels;
    public bool isMenu = false;

    private List<string> _wordsUsed;
    private int _currentLevelIndex = 0;
    private bool _playingGame = false;
    private GameObject _currentLevelObject;
    private LevelManager _currentLevel;

    void Start()
    {
        //Implements Singleton 
        if (_instance != null)
        {
            Debug.LogError("Can't initialize more than one instance of Game Manager!");
            return;
        }

    }

    //Starts the game
    public void StartGame()
    {
        _playingGame = true;
        _currentLevelIndex--;
        loadNextLevel();
    }


    //Load the Next level
    public void loadNextLevel()
    {
        _currentLevelIndex++;
        //Loads new level
        _currentLevel = _currentLevelObject.GetComponent<LevelManager>();
        _currentLevel.load();
    }

    public void winGame()
    {
        _playingGame = false;
    }

    public void stopGame()
    {
        _playingGame = false;
    }

    public List<string> WordsUsed
    {
        get
        {
            return _wordsUsed;
        }
    }
    
    public bool PlayingGame
    {
        get
        {
            return _playingGame;
        }
    }

    public static GameManager Instance
    {
        get
        {
            return _instance;
        }
    }

    public int NumberOfLevels
    {
        get
        {
            return levels.Count;
        }
    }

    public LevelManager CurrentLevel
    {
        get
        {
            return _currentLevel;
        }
    }

    /*
     * Update function that runs every frame; Called within Unity
     */
    void Update()
    {
        //Calls to start game
        if (!_playingGame)
        {
            StartGame();
            return;
        }
        if (isMenu)
        {
            return;
        }
    }
}
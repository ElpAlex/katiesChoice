using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//script that manages the main menu features
public class MenuScript : MonoBehaviour
{
    public GameObject mainMenuScreen;
    public GameObject newGameScreen;
    public GameObject chapterSelectScreen;
    public GameObject optionsScreen;

    public RawImage logo;
    public Text header;

    public Button back;
    public Button options;

    public Button newGameButton;
    public Button LoadGameButton;

    public Button newStoryButton;
    public Button chapterSelectButton;

    public Button katieButton;
    public Button robinButton;
    public Button aminaButton;

    public Canvas warningOverlay;
    public Button yesButton;
    public Button noButton;


    void Awake()
    {
        // Resets menu to main screen
        mainMenuScreen.SetActive(true);
        newGameScreen.SetActive(false);
        chapterSelectScreen.SetActive(false);
        optionsScreen.SetActive(false);

        logo.gameObject.SetActive(true);
        header.gameObject.SetActive(true);

        back.gameObject.SetActive(false);
        options.gameObject.SetActive(true);
    }

    // Enables relevant buttons for each screen
   public void MainMenuScreen()
    {
        mainMenuScreen.SetActive(true);
        newGameScreen.SetActive(false);
        chapterSelectScreen.SetActive(false);
        optionsScreen.SetActive(false);

        logo.gameObject.SetActive(true);
        header.gameObject.SetActive(true);

        back.gameObject.SetActive(false);
        options.gameObject.SetActive(true);
    }

   public void NewGameScreen()
    { 
        // If there is a save game, the WarningOverlay canvas will display on top of the screen 
        
        mainMenuScreen.SetActive(false);
        newGameScreen.SetActive(true);
        chapterSelectScreen.SetActive(false);
        optionsScreen.SetActive(false);

        logo.gameObject.SetActive(true);
        header.gameObject.SetActive(false);

        back.gameObject.SetActive(true);
        options.gameObject.SetActive(true);
    }

//starting a new game
    public void NewStory()
    {
        SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
    }

//chapter selection
   public void ChapterSelectScreen()
    {
        mainMenuScreen.SetActive(false);
        newGameScreen.SetActive(false);
        chapterSelectScreen.SetActive(true);
        optionsScreen.SetActive(false);

        logo.gameObject.SetActive(false);
        header.gameObject.SetActive(false);

        back.gameObject.SetActive(true);
        options.gameObject.SetActive(false);
    }
//first chapter
    public void Katie()
    {
        SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
    }
//seconf chapter
    public void Robin()
    {
        SceneManager.LoadScene("Chapter 2.1", LoadSceneMode.Single);
    }
//third chapter
    public void Amina()
    {
        float randomScene = Random.value;
        if (randomScene <= 0.5f)
        {
            SceneManager.LoadScene("BadEnding", LoadSceneMode.Single);
            Debug.Log("Bad Ending Loaded");
        }
        else
        {
            SceneManager.LoadScene("GoodEnding", LoadSceneMode.Single);
            Debug.Log("Good Ending Loaded");
        }
    }
//options
   public void OptionsScreen()
    {
        mainMenuScreen.SetActive(false);
        newGameScreen.SetActive(false);
        chapterSelectScreen.SetActive(false);
        optionsScreen.SetActive(true);

        logo.gameObject.SetActive(false);
        header.gameObject.SetActive(false);

        back.gameObject.SetActive(true);
        options.gameObject.SetActive(false);
    }
}

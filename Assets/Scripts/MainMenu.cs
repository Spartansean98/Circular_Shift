using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelMenu;
    public void StartGame()
    {
        LoadGame(1);
    } 
    public void LoadGame(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void LevelSelect()
    {
        mainMenu.SetActive(false);
        levelMenu.SetActive(true);
    } 

    public void BackToMainMenu()
    {
        levelMenu.SetActive(false);
        mainMenu.SetActive(true); 
    }

    public void QuitGame()
    {
        Application.Quit();
    } 
}

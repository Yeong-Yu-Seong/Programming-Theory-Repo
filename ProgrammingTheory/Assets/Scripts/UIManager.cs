using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Canvas startMenuUI;
    public Canvas gameUI;
    public void StartGame()
    {
        startMenuUI.enabled = false; // Disable the UI
        gameUI.enabled = true; // Enable the game UI
    }
}

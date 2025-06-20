using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Canvas startMenuUI;
    public Canvas gameUI;
    public void StartGame()
    {
        startMenuUI.gameObject.SetActive(false);
        gameUI.gameObject.SetActive(true);
    }
}

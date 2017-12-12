using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    [SerializeField] private string startingLevel;

    private Animator animator;

    private void Awake()
    {
        animator = mainCamera.GetComponent<Animator>();
    }

    public void startGame()
    {
        SceneManager.LoadScene(startingLevel);
    }

    public void playAnimation(string name)
    {
        animator.Play(name);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void enableButton(GameObject button)
    {
        button.SetActive(true);
    }

    public void disableButton(GameObject button)
    {
        button.SetActive(false);
    }
}

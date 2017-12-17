using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelClick : MonoBehaviour
{
    public void LoadLevel(string scene)
    {
            SceneManager.LoadScene(scene);
    }
}

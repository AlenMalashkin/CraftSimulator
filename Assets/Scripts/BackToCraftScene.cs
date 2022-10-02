using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToCraftScene : MonoBehaviour
{
    public void ToCraftScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMenuScene()
    {
        SceneManager.LoadScene(0);
    }
}

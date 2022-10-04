using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveItemNameToPlayerPrefs : MonoBehaviour
{
    public void Save(string name)
    {
        PlayerPrefs.SetString("currentCraftItemName", name);
        SceneManager.LoadScene(1);
    }
}

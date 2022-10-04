using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemColorChanger : MonoBehaviour
{
    [SerializeField] private string itemName;

    private void Awake()
    {
        if (PlayerPrefs.HasKey(itemName + "Color"))
        {
            gameObject.GetComponent<Image>().color = JsonUtility.FromJson<Color32>(PlayerPrefs.GetString(itemName + "Color"));
        }
        else
        {
            gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 150);
        }
    }
}

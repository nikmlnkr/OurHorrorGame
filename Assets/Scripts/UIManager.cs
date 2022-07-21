using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<UIManager>();
            }

            return _instance;
        }
    }

    public Text promptText;

    public void SetPromptText(string textToSet)
    {
        promptText.text = textToSet;
    }
}

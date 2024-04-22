using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveName : MonoBehaviour
{
    public TMP_InputField _InputField;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            DataManager.Instance.playerName = _InputField.text;
        }
    }
}

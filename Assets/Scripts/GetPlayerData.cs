using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerData : MonoBehaviour
{

    private InputField inputFieldName;
    // Start is called before the first frame update
    void Start()
    {
        inputFieldName = GameObject.Find("InputField").GetComponent<InputField>();
        inputFieldName.onEndEdit.AddListener(delegate { LockInput(inputFieldName); });
    }

  
    void LockInput(InputField input)
    {
        if (input.text.Length > 0)
        {
          PlayerData.Instance.CurrentplayerName = inputFieldName.text;
        }
    }
}

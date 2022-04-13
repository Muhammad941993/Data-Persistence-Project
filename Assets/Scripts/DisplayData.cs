using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayData : MonoBehaviour
{

    public Text bestScoreLabel;
   

    // Start is called before the first frame update
    void Start()
    {
        DisplayBestPlayerData();
    }

   

    public void DisplayBestPlayerData()
    {
        bestScoreLabel.text = "Best Score : " + PlayerData.Instance.BestplayerName + " : " + PlayerData.Instance.BestplayerScore;

    }

}

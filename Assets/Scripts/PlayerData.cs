using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerData : MonoBehaviour
{

    public static PlayerData Instance;
    
    
    public string CurrentplayerName="";
    public string BestplayerName ="";
    public int BestplayerScore = 0;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code
       
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    
}

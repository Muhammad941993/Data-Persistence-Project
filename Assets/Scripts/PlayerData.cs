using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



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
        LoadFromDataBase();
    }

    [System.Serializable]
    public class SaveData
    {
        public int playerScore = 0;
        public string playerName = "";

    }

    public void SaveToDataBase()
    {
        SaveData data = new SaveData();
        data.playerScore = BestplayerScore;
        data.playerName = BestplayerName;


        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadFromDataBase()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json =  File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            BestplayerName = data.playerName;
            BestplayerScore = data.playerScore;
        }
    }


}

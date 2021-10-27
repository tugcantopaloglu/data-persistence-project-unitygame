using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Loader : MonoBehaviour
{

    public static Loader Instance;
    public TMP_InputField NameFieldText;

    public string playerName;
    public string playerNameBest;
    public int best;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        Load();
    }

    [System.Serializable]
    class SaveData
    {
        public string playerName;
        public string playerNameBest;
        public int best;
    }


    public void Save()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        data.playerNameBest = playerNameBest;
        data.best = best;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.playerName;
            playerNameBest = data.playerNameBest;
            best = data.best;
            NameFieldText.text = playerName;
        }
    }

    public void StartGame()
    {
        playerName = NameFieldText.text;
        Save();
        SceneManager.LoadScene(1);
    }
}


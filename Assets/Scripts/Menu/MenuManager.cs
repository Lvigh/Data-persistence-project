using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public string UserName;
    public static InputField nameField;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        if (!UserName.Equals(""))
        {
            SceneManager.LoadScene(1);
            SaveLastUser();
        } else
        {
            Debug.Log("Set your username!");
        }
    }


    public void SaveLastUser()
    {
        SaveData data = new SaveData();
        data.LastUserName = UserName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/appdata.json", json);
    }

    [System.Serializable]
    class SaveData
    {
        public string LastUserName;
    }
}

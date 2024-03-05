using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuUIHandler : MonoBehaviour
{
    public void StartGame()
    {
        MenuManager.Instance.StartGame();        
    }

    public void UpdateUserName(string value)
    {
       MenuManager.Instance.UserName = value;
    }
    public void DeleteHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }
}

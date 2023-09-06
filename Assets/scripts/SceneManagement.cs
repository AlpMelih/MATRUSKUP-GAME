using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public int NextLevelNumber;
    private int Level;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Level = SceneManager.GetActiveScene().buildIndex + 1;
        Debug.Log(Level);
        PlayerPrefs.SetInt("Level", Level);
        PlayerPrefs.Save();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void LoadGame()
    {
        
        Level=PlayerPrefs.GetInt("Level");
        SceneManager.LoadScene(Level);
        Debug.Log(Level);
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
}

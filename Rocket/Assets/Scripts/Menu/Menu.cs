using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void Replay()
    {

    }
    public void LoadNewLevel(string name)
    {
        LoadNewLevelStatic(name);
    }
    public void LoadNewLevel(int num)
    {
        Time.timeScale = 1;
    }

    public static void LoadNewLevelStatic(string name)
    {
        Time.timeScale = 1;
    }

    public static void LoadLevel(int index)
    {
        //LoadNewLevelStatic();
    }

    public static void LoadNewLevelStatic(int index)
    {
        Time.timeScale = 1;
    }

    public void LoadNextLevel()
    {

    }
}

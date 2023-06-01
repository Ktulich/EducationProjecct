using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalLevelController : MonoBehaviour
{
    public static GlobalLevelController Instance;

    [SerializeField]
    List<SceneField> _levels;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    public SceneField Next()
    {
        return _levels[_levels.FindIndex((x) => SceneManager.GetActiveScene().name.Equals(x.SceneName)) + 1];

        /*for (int level = 0; level < _levels.Count; level++)
        {
            if (_levels[level].SceneName == SceneManager.GetActiveScene().name)
            {
                return _levels[level + 1];
            }
        }

        return null;*/
    }

    public int GetIndex()
    {
        return _levels.FindIndex((x) => SceneManager.GetActiveScene().name.Equals(x.SceneName));
    }

    public SceneField GetScene(int index)
    {
        return _levels[index];
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioSource _buttonSound;
    public static bool playSound
    {
        get
        {
            return PlayerPrefs.GetInt("sound") == 0;
        }

        set
        {
            PlayerPrefs.SetInt("sound", value ? 0: 1);
        }
    }

    public static bool PlayMusic
    {
        get
        {
            return PlayerPrefs.GetInt("music") == 0;
        }

        private set
        {
            PlayerPrefs.SetInt("music", value ? 0 : 1);
        }
    }

    private void Awake()
    {
        Instance = this;
        AddButtonSound();
        ApplySounds();
    }
    public void SwitchSoundPlaying()
    {
        playSound = !playSound;
        ApplySounds();
    }

    public void SwitchMusicPlaying()
    {
        PlayMusic = !PlayMusic;
        ApplySounds();
    }
    void ApplySounds()
    {
        var music = FindObjectsOfType<AudioSource>();
        foreach (var m in music)
        {
            if (m.tag == "Sound")
                m.mute = !playSound;
            else
                m.mute = !PlayMusic;
        }
    }

    void AddButtonSound()
    {
        var buttons = FindObjectsOfType<Button>();
        var buttonsSound = Instantiate(_buttonSound) as AudioSource;
        foreach (var b in buttons)
        {
            if (b.tag != "Power")
                b.onClick.AddListener(buttonsSound.Play);
        }
    }
}

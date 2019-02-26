using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SettingsManager : MonoBehaviour
{

    public Slider BrightnessSlider;
    public Slider musicVolumeSlider;
    public Toggle colorBlindToggle;

    private AudioSource musicSource;
    public GameSettings gameSettings;

    public Button applyButton;


    private void OnEnable()
    {
        gameSettings = new GameSettings();

        musicVolumeSlider.onValueChanged.AddListener(delegate { OnMusicVolumeChange(); });
        BrightnessSlider.onValueChanged.AddListener(delegate { OnBrightnessChange(); });
        colorBlindToggle.onValueChanged.AddListener(delegate { OnColorBlindToggle(); });
        applyButton.onClick.AddListener(delegate { OnApply(); });

        LoadSettings();
    }



    void OnColorBlindToggle()
    {
        gameSettings.colorblind = gameSettings.colorblind = colorBlindToggle.isOn;
    }


    void OnMusicVolumeChange()
    {
        AudioListener.volume = gameSettings.musicVolume = musicVolumeSlider.value;

    }
    void OnBrightnessChange()
    {

    }


    public void OnApply()
    {
        SaveSettings();
    }

    public void SaveSettings()
    {
        string jsonData = JsonUtility.ToJson(gameSettings, true);
        File.WriteAllText(Application.persistentDataPath + "/gamesettings.json", jsonData);

    }

    public void LoadSettings()
    {
        gameSettings = JsonUtility.FromJson<GameSettings>(File.ReadAllText(Application.persistentDataPath + "/gamesettings.json"));

        musicVolumeSlider.value = gameSettings.musicVolume;
        colorBlindToggle.isOn = gameSettings.colorblind;

    }
}

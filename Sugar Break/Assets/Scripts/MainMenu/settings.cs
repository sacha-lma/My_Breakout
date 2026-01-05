using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    public AudioMixer masterMixer;
    public TMP_Dropdown resolutionDropdown;
    
    bool MasterToggle = true;
    bool SfxToggle = true;
    bool MusicToggle = true;
    float MasterVolume;
    Resolution[] resolutions;
    private void Start()
    {
        List<String> options = new List<string>();
        int currentResolutionIndex = 0;
        
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    private void Update()
    {
        if (!MasterToggle)
        {
            masterMixer.SetFloat("Master-Volume", -80f);
        }
        if (!SfxToggle)
        {
            masterMixer.SetFloat("FX-Volume", -80f);
        }
        if (!MusicToggle)
        {
            masterMixer.SetFloat("Music-Volume", -80f);
        }
    }

    public void setToggleMaster(bool isOn)
    {
        MasterToggle = isOn == true;
        if (isOn)
        {
            masterMixer.SetFloat("Master-Volume", 0f);
        }
    }
    
    public void setToggleSfx(bool isOn)
    {
        SfxToggle = isOn == true;
        if (isOn)
        {
            masterMixer.SetFloat("FX-Volume", 0f);
        }
    }
    
    public void setToggleMusic(bool isOn)
    {
        MusicToggle = isOn == true;
        if (isOn)
        {
            masterMixer.SetFloat("Music-Volume", 0f);
        }
    }
    
    public void SetMasterVolume(float volume)
    {
        MasterVolume = volume;
        masterMixer.SetFloat("Master-Volume", volume);
    }
    
    public void SetSfxVolume(float volume)
    {
        masterMixer.SetFloat("FX-Volume", volume > MasterVolume ? MasterVolume : volume);
    }
    
    public void SetMusicVolume(float volume)
    {
        masterMixer.SetFloat("Music-Volume", volume > MasterVolume ? MasterVolume : volume);
    }
    
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}

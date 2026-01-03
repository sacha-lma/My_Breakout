using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class settings : MonoBehaviour
{
    public AudioMixer masterMixer;
    
    bool MasterToggle = true;
    bool SfxToggle = true;
    bool MusicToggle = true;
    float MasterVolume;
    
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
}

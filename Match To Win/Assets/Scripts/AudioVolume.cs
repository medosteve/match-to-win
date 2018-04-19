using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioVolume : MonoBehaviour
{

    public float musicVolume;

    public UIElements uiElements = new UIElements();
    [System.Serializable]

    public class UIElements
    {
        public Slider musicSlider;    //Drag a reference to the slider which will control the music.
    }

    void Awake()
    {
        musicVolume = PlayerPrefs.GetFloat("MusicVolume");
        SetSliders();    //Calls function to set slider level to PlayerPrefs
    }

    public void GetSliders()
    {
        PlayerPrefs.SetFloat("MusicVolume", uiElements.musicSlider.value);  //Sets Music volume when slider changes
     
        SavePlayerPrefs();
    }

    public void SetSliders()
    {
      
        uiElements.musicSlider.value = musicVolume;      //Sets Music slider position to MusicVolume PlayerPrefs setting
    }

    public void SavePlayerPrefs()
    {
        PlayerPrefs.Save();  //Saves PlayerPrefs levels
    }
}
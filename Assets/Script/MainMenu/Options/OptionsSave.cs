using UnityEngine;
using UnityEngine.UI;
public class OptionsSave : MonoBehaviour
{
    [SerializeField] private Slider _musicslider, _audioslider;
    private float _musicvalue => _musicslider.value;
    private float _audiovalue => _audioslider.value;
    private void Awake()
    {
        _musicslider.value = PlayerPrefs.GetFloat("Music");
        _audioslider.value = PlayerPrefs.GetFloat("Audio");
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("Music", _musicvalue);
        PlayerPrefs.SetFloat("Audio", _audiovalue);
        PlayerPrefs.Save();
        print($"Save: music = {_musicvalue} audio = {_audiovalue}");
    }
}
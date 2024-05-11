using UnityEngine;
using UnityEngine.UI;
public class OptionsSave : MonoBehaviour
{
    [SerializeField] private Slider _musicslider, _audioslider;
    private float _musicvalue => _musicslider.value;
    private float _audiovalue => _audioslider.value;
    public void Save()
    {
        PlayerPrefs.SetFloat("Music", _musicvalue);
        PlayerPrefs.SetFloat("Music", _audiovalue);
    }
}
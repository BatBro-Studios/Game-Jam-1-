using UnityEngine;
public class CheckingSettings : MonoBehaviour
{
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Music") && !PlayerPrefs.HasKey("Audio"))
        {
            PlayerPrefs.SetFloat("Music", 1f);
            PlayerPrefs.SetFloat("Audio", 1f);
            PlayerPrefs.Save();
        }
    }
}
using UnityEngine;
using UnityEngine.UI;

public class PlayAudio : MonoBehaviour
{

    [SerializeField] Text buttonText;
    [SerializeField] AudioClip audioClip;

    [SerializeField] AudioClip clip0001;
    [SerializeField] AudioClip clip0002;
    [SerializeField] AudioClip clip0003;
    [SerializeField] AudioClip clip0004;
    [SerializeField] AudioClip clip0005;
    [SerializeField] AudioClip clip0006;
    [SerializeField] AudioClip clip0007;
    [SerializeField] AudioClip clip0008;

    private AudioSource audioSource;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            buttonText.text = "Play Audio";
        }
    }

    public void PlayAudioClip()
    {
        if (audioSource == null) return;

        if (audioSource.isPlaying)
        {
            audioSource.Stop();
            buttonText.text = "Play Audio";
        }
        else
        {
            audioSource.PlayOneShot(audioClip);
            buttonText.text = "Stop Audio";
        }
    }

    public void SetAudioClip(string audio)
    {
        switch(audio)
        {
            case "0001": 
                audioClip = clip0001;
                break;
            case "0002":
                audioClip = clip0002;
                break;
            case "0003":
                audioClip = clip0003;
                break;
            case "0004":
                audioClip = clip0004;
                break;
            case "0005":
                audioClip = clip0005;
                break;
            case "0006":
                audioClip = clip0006;
                break;
            case "0007":
                audioClip = clip0007;
                break;
            case "0008":
                audioClip = clip0008;
                break;
        }
    }


}

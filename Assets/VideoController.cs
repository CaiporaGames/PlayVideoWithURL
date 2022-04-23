using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class VideoController : MonoBehaviour
{
    [SerializeField] GameObject text;
    VideoPlayer videoPlayer;
    bool canPlay = false;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

   
    void Update()
    {
        if (canPlay)
        {
            text.GetComponent<TextMeshProUGUI>().gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && canPlay)
        {
            Play();
        }
    }

    void Play()
    {
        videoPlayer.Play();
        videoPlayer.isLooping = true;
    }

    public void SetURL(TMP_InputField input)
    {
        videoPlayer.url = input.text;
        canPlay = true;
    }
}

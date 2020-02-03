using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    VideoPlayer vPlayer;
    // Start is called before the first frame update
    void Start()
    {
        vPlayer = GetComponent<VideoPlayer>();
    }

    private char c;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            //play
            VideoControll('p');
        }
        if (Input.GetKey(KeyCode.S))
        {
            //stop
            VideoControll('s');
        }
        if (Input.GetKey(KeyCode.A))
        {
            //pause
            VideoControll('a');
        }
    }
    void VideoControll(char c)
    {
        //p stands for play
        if (c == 'p')
        {
            vPlayer.Play();
            return;
        }

        //s stands for stop
        if (c == 's')
        {
            vPlayer.Stop();
            return;
        }
        //a stands for pause
        if (c == 'a')
        {
            vPlayer.Pause();
            return;
        }
    }
}

//このコードはコピペしてもらう
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    VideoPlayer vPlayer;
    MeshRenderer mRenderer;

    void Start()
    {
        vPlayer = GetComponent<VideoPlayer>();
        mRenderer = GetComponent<MeshRenderer>();
        vPlayer.enabled = true;
        mRenderer.enabled = true;
        Play();Pause();
        Debug.Log("Start");
    }

    void Update()
    {
        ////表示・非表示
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SwitchDisplay();
        //}


        ////再生停止
        //if (Input.GetKey(KeyCode.P))
        //{
        //    Play();
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    Stop();
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    Pause();
        //}
    }

    public void Play(){ vPlayer.Play(); }
    public void Stop(){ vPlayer.Stop(); }
    public void Pause(){ vPlayer.Pause(); }

    public void SwitchDisplay()
    {
        mRenderer.enabled ^= true;
        vPlayer.enabled ^= true;
        if (vPlayer.enabled) { Play();Pause(); }
    }
}

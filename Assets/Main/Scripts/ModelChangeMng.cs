using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelChangeMng : MonoBehaviour
{
    //modelsには、同時に出現させたいやつをまとめて空オブジェクトの子とかにしてその空オブジェクトをいれる
    [SerializeField]
    private GameObject[] models;

    [SerializeField]
    private int init_model;

    private int now_model;


    // Start is called before the first frame update
    void Start()
    {
        now_model = init_model;
    }

    // Update is called once per frame
    // テスト用なので実際に使うときは変更してね
    void Update()
    {
        int next = (now_model + 1) % models.Length;

        if (Input.GetMouseButtonDown(0))
        {
            ChangeModel(next);
        }
        if (Input.GetMouseButtonUp(0))
        {
            ChangeModel(next);
        }
        
    }

    //boolにしてもいいけど意味なさげ
    public void ChangeModel(int model_num)
    {
        //いらんかった
        if (models[now_model].GetComponent<ModelBhv>().Hide())
        {
            
        }

        
        if (models[model_num].GetComponent<ModelBhv>().Show())
        {
            now_model = model_num;
        }
    }
}

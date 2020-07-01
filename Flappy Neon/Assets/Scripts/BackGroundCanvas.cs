using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundCanvas : MonoBehaviour
{
    public float speed = 0; //эта публичная переменная отобразится в инспекторе, там же мы ее можем и менять. Это очень удобно, чтобы настроить скорость разным слоям картинки

    float pos = 0; //переменная для позиции картинки

    private RawImage image; //создаем объект нашей картинки

    public Texture[] Backgrounds;

    void Start()
    {
        GetComponent<RawImage>().texture = Backgrounds[Random.Range(0, Backgrounds.Length)];

        image = GetComponent<RawImage>();//в старте получаем ссылку на картинку

    }



    void Update()
    {

        //в апдейте прописываем как, с какой скоростью и куда мы будем двигать нашу картинку

        pos += speed;

        if (pos > 1.0F)

            pos -= 1.0F;

        image.uvRect = new Rect(pos, 0, 1, 1);

    }



}


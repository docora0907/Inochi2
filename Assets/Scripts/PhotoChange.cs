using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoChange : MonoBehaviour
{
    private Image img;
    private int count = 1;

    void Start()
    {
        img = GameObject.Find("Image").GetComponent<Image>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (count < 3)
                count++;
            //else
            //    count = 1;

            img.sprite = Resources.Load<Sprite>("Image/photo" + count.ToString());
        }
    }
}
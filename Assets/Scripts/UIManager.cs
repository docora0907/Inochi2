using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    Text timeText;
    float timer;
    void Start()
    {
      timeText=transform.Find("Text").GetComponent<Text>();  
    }

    void Update()
    {
        timer+=Time.deltaTime;
        timeText.text=timer.ToString("F2")+" •b";
    }
}

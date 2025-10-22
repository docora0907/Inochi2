using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timeTexts;
    public Text CountText;
    float totalTime = 10;
    int retime;
    float countdown = 3f;
    int count;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown >= 0)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
            CountText.text = count.ToString();
        }
        if(countdown <= 0)
        {
            CountText.text = "";
            totalTime -= Time.deltaTime;
            retime = (int)totalTime;
            timeTexts.text = retime.ToString();
            if(retime == 0)
            {
                SceneManager.LoadScene("result");
            }
        }
        
    }
}

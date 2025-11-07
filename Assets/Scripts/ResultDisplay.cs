using UnityEngine;
using TMPro;

public class ResultDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;

    void Start()
    {
        // 記録された経過時間（秒）を分と秒に変換
        float totalTime = TimeManager.elapsedTime;
        int minutes = (int)(totalTime / 60);           // 分
        float seconds = totalTime % 60f;               // 残りの秒

        // 00:00.00 の形式に整形
        string formattedTime = string.Format("{0:00}:{1:00.00}", minutes, seconds);

        // 画面に表示
        timeText.text = formattedTime;
    }
}
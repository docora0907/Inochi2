using UnityEngine;
using TMPro;

public class ResultDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;

    void Start()
    {
        timeText.text = "Œo‰ßŽžŠÔ: " + TimeManager.elapsedTime.ToString("F2") + " •b";
    }
}
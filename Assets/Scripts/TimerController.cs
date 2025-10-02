using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //public float speed = 5f; // プレイヤーの移動速度
    private float currentTime = 0f; // 現在のタイム
    private bool isTiming = true; // タイマーのオン/オフ
    public TextMeshProUGUI currentTimeText; // 現在のタイム表示用UI
    public TextMeshProUGUI bestTimeText; // ベストタイム表示用UI

    void Start()
    {
        DisplayBestTime(); // ベストタイムを画面に表示
    }

    void Update()
    {
        // タイマーの更新
        if (isTiming)
        {
            currentTime += Time.deltaTime;
            currentTimeText.text = "Time: " + currentTime.ToString("F2") + "s";
        }

        // プレイヤーの移動
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //transform.Translate(movement * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            isTiming = false;
            SaveBestTime(); // ベストタイムを保存
        }
    }

    // ベストタイムを表示
    private void DisplayBestTime()
    {
        if (PlayerPrefs.HasKey("BestTime"))
        {
            float bestTime = PlayerPrefs.GetFloat("BestTime");
            bestTimeText.text = "Best Time: " + bestTime.ToString("F2") + "s";
        }
        else
        {
            bestTimeText.text = "Best Time: --";
        }
    }

    // ベストタイムを保存
    private void SaveBestTime()
    {
        if (!PlayerPrefs.HasKey("BestTime") || currentTime < PlayerPrefs.GetFloat("BestTime"))
        {
            PlayerPrefs.SetFloat("BestTime", currentTime);
            PlayerPrefs.Save();
            DisplayBestTime();
        }
    }

    // ベストタイムをリセット
    public void ResetBestTime()
    {
        PlayerPrefs.DeleteKey("BestTime");
        PlayerPrefs.Save();
        DisplayBestTime();
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public static float elapsedTime; // シーン間で共有される経過時間

    private bool isRunning = true; // タイマーが動作中かどうか

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime; // フレームごとに加算
        }
    }

    // ボタンから呼び出すメソッド
    public void GoToResultScene()
    {
        isRunning = false; // 計測停止
        SceneManager.LoadScene("GameEndScene"); // 結果シーンに移動（シーン名はプロジェクトに合わせて変更）
    }
}
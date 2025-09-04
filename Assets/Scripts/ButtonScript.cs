using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    //シーンの名前
    public string SceneName;

    //クリックされた時に実行
    public void Clicked()
    {
        SceneManager.LoadScene(SceneName);
    }
}

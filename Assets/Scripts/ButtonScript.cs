using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    //�V�[���̖��O
    public string SceneName;

    //�N���b�N���ꂽ���Ɏ��s
    public void Clicked()
    {
        SceneManager.LoadScene(SceneName);
    }
}

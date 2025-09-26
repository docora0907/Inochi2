using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSwichScript : MonoBehaviour
{

    public string sceneName;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }

}

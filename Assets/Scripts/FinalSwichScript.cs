using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSwichScript : MonoBehaviour
{

    public GameObject darkRoom;
    public GameObject end;

    public string sceneName;

    void Start()
    {
        darkRoom.SetActive(false);
        end.SetActive(false);
    }

    private void OnMouseDown()
    {
        darkRoom.SetActive(true);
        end.SetActive(true);
        SceneManager.LoadScene(sceneName);
    }

}

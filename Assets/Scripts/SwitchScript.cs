using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SwichScene : MonoBehaviour
{

    public string sceneName;
    public string objectName1;
    public string objectName2;
    GameObject showObject;
    GameObject swich;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        swich = GameObject.Find(objectName2);
        showObject = GameObject.Find(objectName1);
        showObject.SetActive(false);
    }

    void OnMouseDown()
    {
        this.swich.SetActive(false);
        this.showObject.SetActive(true);
        SceneManager.LoadScene(sceneName);
    }

}

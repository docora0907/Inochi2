using UnityEngine;

public class FristSwichScript : MonoBehaviour
{

    public GameObject darkRoom;

    public GameObject ok;

    public float y;
    public GameObject ca;

    void Start()    
    {
        darkRoom.SetActive(false);
        ok.SetActive(false);
    }

    void OnMouseDown()
    {
        darkRoom.SetActive(true);
        ok.SetActive(true);

        ca.transform.position = new Vector3(transform.position.x,y,-10);
    }

}

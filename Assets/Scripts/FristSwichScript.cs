using UnityEngine;

public class FristSwichScript : MonoBehaviour
{

    public GameObject nextRoom;

    public float y;
    public GameObject ca;

    void Start()    
    {
        nextRoom.SetActive(false);
    }

    void OnMouseDown()
    {
        nextRoom.SetActive(true);
        ca.transform.position = new Vector3(transform.position.x,y,-10);
    }

}

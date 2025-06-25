using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private GameObject player;
    GameObject mainCamObj;
    void Start()
    {
        this.player = GameObject.Find("Player");
        mainCamObj = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camPos = mainCamObj.transform.position;
        camPos.y = player.transform.position.y;
        mainCamObj.transform.position = camPos;
    }
}



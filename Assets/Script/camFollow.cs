using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{

    public GameObject cameraFollowPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(cameraFollowPlayer.transform.position.x, cameraFollowPlayer.transform.position.y, cameraFollowPlayer.transform.position.z -10);
    }
}

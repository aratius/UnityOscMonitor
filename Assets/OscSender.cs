using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OscJack;

public class OscSender : MonoBehaviour
{

    private OscClient _client;

    // Start is called before the first frame update
    void Start()
    {
        this._client = new OscClient("192.168.43.101", 8000);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)) this._client.Send("/scanner", 1);
    }
}

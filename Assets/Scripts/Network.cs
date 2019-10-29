using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Network : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); // connect to master server
        Debug.Log("Connected to the " + PhotonNetwork.CloudRegion + " server");
    }

   

    void Update()
    {
        Debug.Log("Connected to the " + PhotonNetwork.CloudRegion + " server");
    }
}

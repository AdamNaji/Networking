using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
public class GameController : MonoBehaviour
{
    void Start()
    {
        CreatePlayer();
    }
    private void CreatePlayer()
    {
        Debug.Log("Creating Player");
        PhotonNetwork.Instantiate( "Player1", Vector3.zero , Quaternion.identity);
        
    }

}

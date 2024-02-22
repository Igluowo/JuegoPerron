using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform playerPosition;
    public Transform respawnPosition;


    public void DeadPlayer() {
        playerPosition.position = respawnPosition.position;
    }
}

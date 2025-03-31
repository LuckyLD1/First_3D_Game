using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player_Movement : MonoBehaviour
{
    public GameObject player;
    Vector3 thisPos;
    private void Start()
    {
        thisPos = transform.position;
    }
    void Update()
    {
        gameObject.transform.position = player.transform.position + thisPos;
    }
}

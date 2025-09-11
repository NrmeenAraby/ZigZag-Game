﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour {

    public GameObject roadPrefab;
    public Vector3 lastPosition;
    public float offset=0.712f;

    public int roadCount = 0;   
    public void StartBuilding()
    {
        InvokeRepeating("CreateNewRoadPart", 1f, 0.5f);
    }
    public void CreateNewRoadPart()
    {
        Vector3 spawnPos= Vector3.zero;
        float chance = Random.Range(0, 100);
        if (chance < 50)
        {
            spawnPos = new Vector3(lastPosition.x+offset , lastPosition.y , lastPosition.z +  offset);
        }
        else
        {
            spawnPos = new Vector3(lastPosition.x - offset, lastPosition.y, lastPosition.z + offset);
        }
        GameObject lastCreatedPart = Instantiate(roadPrefab, spawnPos , Quaternion.Euler(0,45,0));
        lastPosition = lastCreatedPart.transform.position;
        roadCount++;
        if (roadCount % 5 == 0)
        {
            lastCreatedPart.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}

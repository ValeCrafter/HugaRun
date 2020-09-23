using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class LevelGenrator : MonoBehaviour
{
    [SerializeField] private Transform Platforms;
    [SerializeField] private List<Transform> PlatformList;
    [SerializeField] private Transform EndPlatform;

    private Vector3 lastEndPos;


    private void Start()
    {
        
    }

    private void Awake()
    {
        lastEndPos = Platforms.Find("PlatformEndPos").position;
        for (int i = 1; i <= 20; i++)
        {
            SpawnPlatform();
        }
        SpawnEndPlatform();
        // sowas für ziel einfügen -> Instantiate(Endpaltform, Vector3(x, y, z), Quaternion.identity);



    }

    private void SpawnPlatform()
    {
        Transform chosenPlatform = PlatformList[Random.Range(0, PlatformList.Count)];
        Transform lastPlatformTransform = SpawnPlatform(chosenPlatform, lastEndPos);
        lastEndPos = lastPlatformTransform.Find("PlatformEndPos").position;
    }
    

    private Transform SpawnPlatform(Transform Platform, Vector3 spawnPosition)
    {
        Transform PlatfromTransform = Instantiate(Platform, spawnPosition, Quaternion.identity);
        return PlatfromTransform;
    }
    private void SpawnEndPlatform()
    {

        Transform lastPlatformTransform = Instantiate(EndPlatform, lastEndPos, Quaternion.identity);
        lastEndPos = lastPlatformTransform.Find("PlatformEndPos").position;
    }

    private Transform SpawnEndPlatform(Transform Platform, Vector3 spawnPosition)
    {
        Transform PlatfromTransform = Instantiate(Platform, spawnPosition, Quaternion.identity);
        return PlatfromTransform;
    }



}

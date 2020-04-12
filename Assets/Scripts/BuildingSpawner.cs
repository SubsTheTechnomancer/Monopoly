using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    
    public Transform parent;
    public Transform spawnArea;

    public Transform house;
    public Transform hotel;

    public void AddHouse()
    {
        Instantiate(house,spawnArea.position,Quaternion.identity,parent);
    }

    public void AddHotel()
    {
        Instantiate(hotel,spawnArea.position,Quaternion.identity,parent);
    }

}

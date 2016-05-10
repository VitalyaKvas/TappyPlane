using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public List<GameObject> rocks;
    public Transform ParentRocks;

    void Start()
    {
        InvokeRepeating("GenerateObstacles", 2.5f, 2.5f);
    }

    void GenerateObstacles()
    {
        var randomIndex = Random.Range(0, rocks.Count);
        var rock = rocks[randomIndex];

        var newRock = Instantiate(rock, new Vector3(45, 0, 0), Quaternion.identity) as GameObject;
        newRock.transform.parent = ParentRocks;
    }
}
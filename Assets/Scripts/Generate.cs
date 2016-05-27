using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public List<GameObject> rocks;
    public Transform ParentRocks;
    int score = 0;

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

        score++;
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label(" Score: " + score.ToString());
    }
}
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public List<GameObject> rocks;
    public Transform ParentRocks;
    public Vector3 PossitionRocks = new Vector3(45, 0, 0);
    public float StartRepeating = 2.5f;
    public float RateRepeating = 2.5f;
    public bool CountingScore;
    public int Score = 0;

    void Start()
    {
        InvokeRepeating("GenerateObstacles", StartRepeating, RateRepeating);
    }

    void GenerateObstacles()
    {
        var randomIndex = Random.Range(0, rocks.Count);
        var rock = rocks[randomIndex];

        var newRock = Instantiate(rock, PossitionRocks, Quaternion.identity) as GameObject;
        newRock.transform.parent = ParentRocks;
        newRock.transform.localPosition = PossitionRocks;

        if (CountingScore) Score++;
    }

    // Update is called once per frame
    void OnGUI()
    {
        if (CountingScore)
        {
            GUI.color = Color.black;
            GUILayout.Label(" Score: " + Score.ToString());
        }
    }
}
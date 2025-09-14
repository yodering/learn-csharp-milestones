using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Single-line: Demonstrates different C# comment types in this script.
/// <summary>
/// Demonstrates single-line, multi-line, and XML summary comments.
/// </summary>
public class LearningCurve : MonoBehaviour
{
    /*
     Multi-line: Example fields below are simple data types used
     for learning purposes and do not affect runtime behavior.
    */
    
    public int level = 1;
    public float speed = 3.5f;
    private string playerName = "Ada";
    private bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("--- Variables and Logging ---");

        string infoConcat = "Player: " + playerName + " | Level: " + level;
        Debug.Log(infoConcat);

        Debug.Log($"Speed: {speed} | Active: {isActive}");

        Debug.LogFormat("Player {0} at level {1} running {2} m/s (active: {3})", playerName, level, speed, isActive);

        int newLevel = Add(level, 2);
        Debug.Log($"Level + bonus = {newLevel}");

        string status = BuildStatus(playerName, newLevel, speed);
        Debug.Log(status);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Simple method: takes parameters and returns an int
    private int Add(int a, int b)
    {
        return a + b;
    }

    // Method returning a string and using interpolation
    private string BuildStatus(string name, int lvl, float spd)
    {
        return $"[Status] {name} L{lvl} @ {spd:0.0} m/s";
    }
}

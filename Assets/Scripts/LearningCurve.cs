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

        // Conditionals
        Debug.Log("--- Conditionals ---");
        if (level < 1)
        {
            Debug.Log("Level is below 1.");
        }
        else if (level == 1)
        {
            Debug.Log("Level is exactly 1.");
        }
        else
        {
            Debug.Log("Level is above 1.");
        }

        // Testing true and !true
        if (isActive == true)
        {
            Debug.Log("isActive is true");
        }
        if (!isActive)
        {
            Debug.Log("isActive is not true");
        }

        // Nested if
        if (level > 1)
        {
            if (speed > 3f)
            {
                Debug.Log("High level and fast!");
            }
        }

        // Switch
        switch (level)
        {
            case 0:
                Debug.Log("Switch: level is 0");
                break;
            case 1:
                Debug.Log("Switch: level is 1");
                break;
            default:
                Debug.Log("Switch: level is something else");
                break;
        }

        // Collections
        Debug.Log("--- Collections ---");

        
        string[] arr = new string[] { "red", "green", "blue" };
        Debug.Log($"arr[1] = {arr[1]}"); // expected: green

        int[] scores = new int[] { 10, 20, 30 };
        List<string> colors = new List<string> { "red", "green", "blue" };
        Dictionary<string, int> inventory = new Dictionary<string, int>
        {
            {"potion", 3},
            {"elixir", 1}
        };

        // Loops
        Debug.Log("--- Loops ---");

        // for loop: print a specific index from List<string>
        int targetIndex = 2;
        for (int i = 0; i < colors.Count; i++)
        {
            if (i == targetIndex)
            {
                Debug.Log($"for: colors[{i}] = {colors[i]}");
            }
        }

        // foreach: print all indexes and values of List<string>
        int idx = 0;
        foreach (var c in colors)
        {
            Debug.Log($"foreach list index {idx}: {c}");
            idx++;
        }

        // foreach: print Key and Value for Dictionary<string, int>
        foreach (KeyValuePair<string, int> kvp in inventory)
        {
            Debug.Log($"dict {kvp.Key} => {kvp.Value}");
        }
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Tooltip("The doors in the maze")]
    public DoorController[] doors;

    /// <summary>
    /// Resets every game element to its starting state so that a fresh game can be started again
    /// </summary>
    public void ResetGame()
    {
        foreach (DoorController door in doors)
        {
            door.DoorOpen = false;
        }
    }
}

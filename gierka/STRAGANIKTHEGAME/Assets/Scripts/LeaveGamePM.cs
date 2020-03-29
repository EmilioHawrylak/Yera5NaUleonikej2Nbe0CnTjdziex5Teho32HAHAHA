using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveGamePM : MonoBehaviour
{
    // Start is called before the first frame update
    public void leaveGame()
    {
        Application.LoadLevel("test");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stargamers : MonoBehaviour
{
    public Transform Gamestart;

    public void Start()
    {
        Time.timeScale = 1;
        Gamestart.gameObject.SetActive(false);
    }
}

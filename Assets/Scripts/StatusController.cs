using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusController : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] GameObject startPanel;

    [Header("Panels")]
    [SerializeField] AudioClip startSFX;

    [Header("Config")]
    [SerializeField] BlocksDriver blocksDriver;

    public void StartButton()
    {
        AudioSource.PlayClipAtPoint(startSFX, Camera.main.transform.position);
        startPanel.SetActive(false);
        blocksDriver.SetIsRunning(true);
    }
}

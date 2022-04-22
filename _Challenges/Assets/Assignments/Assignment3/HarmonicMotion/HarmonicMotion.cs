using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmonicMotion : MonoBehaviour
{
    [Header("Amplitude A")]
    public int amplitude;
    [Header("DrehWinkel Phi")]
    public int schwingungsPhase;
    [Header("WinkelGeschwindigkeit Omega")]
    public float winkelGeschwindigkeit;
    [Header("PeriodenDauer T")]
    public float periodenDauer;
    [Header("Frequence f")]
    public float frequence;
    [Header("Elongation s")]
    public float elongation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elongation = amplitude * Mathf.Sin(winkelGeschwindigkeit * Time.time);     
        transform.position = new Vector3(elongation, 0, -1);     
    }
}
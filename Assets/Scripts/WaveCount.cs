using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveCount : MonoBehaviour
{
    public int newWave;
    public int currentWave;

    [SerializeField] private Text waveText;

    public void Start()
    {
        InitVariables();
    }

    private void InitVariables()
    {
        currentWave = 0;
        newWave = 1;
    }


    public void AddOneWave()
    {
        currentWave += newWave;
        waveText.text = currentWave.ToString();
    }
}

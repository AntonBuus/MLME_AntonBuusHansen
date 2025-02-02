using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;

public class ExpertDetect : MonoBehaviour
{

    [PullFromIMLController]
    public int _userPerformance;

    private int _expertValue = 1;
    private int _beginnerValue = 0;
    public GameObject expertCheckSymbol;


    private void Update()
    {
        if (_userPerformance == _expertValue)
        {
            expertCheckSymbol.SetActive(false);
        }
        else if (_userPerformance == _beginnerValue)
        {
            expertCheckSymbol.SetActive(true);
        }

    }
}

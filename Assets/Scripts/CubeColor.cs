using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    [SerializeField] private Material cubeMaterial;

    [SerializeField] private Color[] colors;

    private int colorIndex = 0;

    [SerializeField] private float lerpValue;

    [SerializeField] private float time;

    private float currentTime;


    private void Update()
    {
        SetColorChangeTime();
        SetCubeMaterialSmoothColorChange();
    }

    private void SetColorChangeTime()
    {
        if (currentTime <= 0)
        {
            CheckColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndexValue()
    {
        colorIndex++;

        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void SetCubeMaterialSmoothColorChange()
    {
        cubeMaterial.color = Color.Lerp(cubeMaterial.color, colors[colorIndex], lerpValue * Time.deltaTime);
    }

    private void OnDestroy()
    {
        cubeMaterial.color = colors[1];
    }
}

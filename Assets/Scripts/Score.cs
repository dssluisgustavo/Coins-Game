using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMesh;
    public void RefreshUI(int points)
    {
        textMesh.text = points.ToString();
    }
}

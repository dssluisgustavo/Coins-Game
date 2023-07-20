using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }

    [SerializeField] TextMeshProUGUI textMesh;
    int points;
    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else { Destroy(gameObject); }

        points = GameObject.FindObjectsOfType<CoinPickup>().Length;
        textMesh.text = points.ToString();
    }

    public void ReduceCoin()
    {
        points--;
        textMesh.text = points.ToString();
    }
}

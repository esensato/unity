using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileClick : MonoBehaviour
{

    [SerializeField] private GameObject Tile;


    public void OnMouseDown() {

            Debug.Log("Clicked: " + Tile.name);

    }

    void Start()
    {
        Debug.Log("Hello World.");
    }

    void Update()
    {
        
    }
}

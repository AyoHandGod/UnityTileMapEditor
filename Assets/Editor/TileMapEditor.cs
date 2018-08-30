using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TileMapEditor {
    
    [MenuItem("GameObject/TileMap")]
    public static void CreateTileMap()
    {
        GameObject go = new GameObject("TileMap");
        go.AddComponent<TileMap>();
        Debug.Log("Added Tilemap");
    }
}

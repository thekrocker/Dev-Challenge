using System;
using System.Collections;
using System.Collections.Generic;
using Project.OnInspectorGUI.Scripts;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

public class CubeSpawner : MonoBehaviour
{
    public void InstantiatePrimitive()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}


#if UNITY_EDITOR

[CustomEditor(typeof(CubeSpawner))]
public class ButtonEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var cubeSpawner = (CubeSpawner)target;

        if (cubeSpawner == null) return;

        // Undo.RecordObject(cubeSpawner, "Button Click");

        if (GUILayout.Button("Spawn Primitive"))
        {
            cubeSpawner.InstantiatePrimitive();
        }
    }
}
#endif
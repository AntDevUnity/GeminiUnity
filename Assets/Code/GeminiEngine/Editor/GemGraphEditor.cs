using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class GemGraphEditor : EditorWindow
{


    [MenuItem("Gemini/Graph Editor")]
    public static void ShowWindow()
    {
        var win = GetWindow<GemGraphEditor>(false, "Gemini Graph Editor", true);
        win.position = new Rect(20, 20, 800, 600);
    }


    void OnGUI()
    {

        EditorGUILayout.BeginVertical();

      

        EditorGUILayout.EndVertical();

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

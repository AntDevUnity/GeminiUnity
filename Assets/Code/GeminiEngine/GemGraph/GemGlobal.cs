using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GemGlobal : MonoBehaviour
{

    public GemGlobal Main = null;
    public List<GemNode> Nodes = new List<GemNode>();
    public List<GemPort> Ports = new List<GemPort>();

    // Start is called before the first frame update
    void Start()
    {
        Main = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

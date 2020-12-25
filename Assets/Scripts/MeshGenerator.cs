using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MeshGenerator : MonoBehaviour
{
    Mesh mesh;
    [ContextMenu("Generate Mesh")]
    private void generate() {
        mesh = new Mesh();
        mesh.Clear();

        var vertices = (
            from y in new[] { -1, 1 }
            from x in new[] { -1, 1 }
            select new Vector3(x, y, 0)
        ).ToArray();

        Debug.Log(string.Join(", ", vertices));
        mesh.vertices = vertices;

        mesh.triangles = new[] { 0, 1, 2, 2, 1, 3 };

        mesh.RecalculateBounds();
        mesh.RecalculateNormals();

        GetComponent<MeshFilter>().sharedMesh = mesh;
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

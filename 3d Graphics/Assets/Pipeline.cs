/*
 * Fill values into the model class for your letter.
You will need to change the accessibility of the lists in model to internal or public
Call the method, passing your model into it, (in start)
Import the texture you wish to use
Run unity, while running attach the texture to the newly created gameobject in the scene hierarchy
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipeline : MonoBehaviour
{
    Matrix4x4 translation, rotation, scale, viewing, projection;
    // Start is called before the first frame update
    void Start()
    {
        Model cube = new Model(Model.default_primitives.Cube);

        CreateUnityGameObject(cube);

        Model k = new Model(Model.Letter.K);
        CreateUnityGameObject(K);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public GameObject CreateUnityGameObject(Model model)
    {
        Mesh mesh = new Mesh();
        GameObject newGO = new GameObject();
        MeshFilter mesh_filter = newGO.AddComponent<MeshFilter>();
        MeshRenderer mesh_renderer = newGO.AddComponent<MeshRenderer>();




        List<Vector3> coords = new List<Vector3>();
        List<int> dummy_indices = new List<int>();
        List<Vector2> text_coords = new List<Vector2>();
        List<Vector3> normals = new List<Vector3>();

        for (int i = 0; i <= model._index_list.Count - 3; i = i + 3)
        {
            Vector3 normal_for_face = model._face_normals[i / 3];
            normal_for_face = new Vector3(normal_for_face.x, normal_for_face.y, -normal_for_face.z);
            coords.Add(model._vertices[model._index_list[i]]); dummy_indices.Add(i); text_coords.Add(model._texture_coordinates[model._texture_index_list[i]]); normals.Add(normal_for_face);
            coords.Add(model._vertices[model._index_list[i + 1]]); dummy_indices.Add(i + 1); text_coords.Add(model._texture_coordinates[model._texture_index_list[i + 1]]); normals.Add(normal_for_face);
            coords.Add(model._vertices[model._index_list[i + 2]]); dummy_indices.Add(i + 2); text_coords.Add(model._texture_coordinates[model._texture_index_list[i + 2]]); normals.Add(normal_for_face);
        }

        mesh.vertices = coords.ToArray();
        mesh.triangles = dummy_indices.ToArray();
        mesh.uv = text_coords.ToArray();
        mesh.normals = normals.ToArray(); ;

        mesh_filter.mesh = mesh;
        return newGO;

    }
}

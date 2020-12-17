/*
 * Fill values into the model class for your letter.
You will need to change the accessibility of the lists in model to internal or public
Call the method, passing your model into it, (in start)
Import the texture you wish to use
Run unity, while running attach the texture to the newly created gameobject in the scene hierarchy
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipeline : MonoBehaviour
{
    Matrix4x4 translation, rotation, scale, viewing, projection;
    // Start is called before the first frame update
    void Start()
    {
        //Model cube = new Model(Model.default_primitives.Cube);

        //CreateUnityGameObject(cube);

        Model k = new Model(Model.letter.K);
        CreateUnityGameObject(k);

        Outcode a = new Outcode(new Vector2(2f, -2f));
        print(a.ToString());
            
        Vector2 start = new Vector2(2,2), end = new Vector2(-3,0); 
        if (line_clip(ref start, ref end)) draw(start, end); //if true, rasterize

        Vector2 test1 = new Vector2(1, 1);
        Vector2 test2 = new Vector2(3, 1);
        bool boolLineclip = line_clip(ref test1, ref test2);
        print(boolLineclip);

       // Vector2 testVec = new Vector2(2, 2);
       // Vector2Int newVec = convertToInts(testVec);

    }

    //Convert vector 2 to int
    /*public static Vector2Int convertToInts(this Vector2 v)
    {
        return new Vector2Int((int)v.x, (int)v.y);
    }*/
    
    

    private void bresenhamsAlgorithm(int x1, int y1, int x2, int y2) {
        int dx = x2 - x1;
        int dy = y2 - y1;

        int gradient = dx / dy;

        int i = 2*(dy);
    }

    private bool line_clip(ref Vector2 start, ref Vector2 end) //Testing of acceptance, each rejection and various others
    {
        Outcode startOutcode = new Outcode(start), endOutcode = new Outcode(end), inViewPortOutcode = new Outcode();

        //Both points inside viewport
        if ((startOutcode == inViewPortOutcode) && (endOutcode == inViewPortOutcode)) {
            print("Trivial Acceptance");
            return true;
        }
        //Not in viewport
        if ((startOutcode * endOutcode) != inViewPortOutcode) {
            print("Trivial reject");
            return false;
        }

        if (startOutcode == inViewPortOutcode) {
            return line_clip(ref end, ref start);
        }

        if (startOutcode.up) {
            start = intercept(start, end, 0);
            return line_clip(ref start, ref end);
        }
        if (startOutcode.down)
        {
            start = intercept(start, end, 1);
            return line_clip(ref start, ref end);
        }
        if (startOutcode.left)
        {
            start = intercept(start, end, 2);
            return line_clip(ref start, ref end);
        }
        if (startOutcode.right)
        {
            start = intercept(start, end, 3);
            return line_clip(ref start, ref end);
        }

        //Return if start doesnt clip to valid point. Clip end only if start clips to valid point.
        return line_clip(ref end, ref start);
    }

    Vector2 intercept(Vector2 start, Vector2 end, int edge) {
        float slope = (end.y - start.y) - (end.x - start.x);
        switch (edge) {

            //Up
            case 0:
                return new Vector2(start.x + (1 / slope) * (1 - start.y), 1);
                
            //Down
            case 1:
                return new Vector2(start.x + (1 /slope) * (-1 - start.y), -1);
                
            //Left
            case 2:
                return new Vector2(-1, start.y + slope * (-1 - start.x));
            //Right
            default:
                return new Vector2(1, start.y + slope * (1 - start.x));

        }
    }

    private void draw(Vector2 start, Vector2 end)
    {
        throw new NotImplementedException();
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

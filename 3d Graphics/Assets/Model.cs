using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model 
{
    public enum default_primitives {  Cube }
    public enum letter { K }

    public List<Vector3> _vertices;
    public List<int> _index_list;
    public List<Vector2> _texture_coordinates;
    public List<int> _texture_index_list;
    public List<Vector3> _face_normals;

    public Model(default_primitives shape)
    {
        switch (shape)
        {
            case default_primitives.Cube:
                initialize_lists();
                add_cube_vertices();
                add_texture_coordinates();
                add_indices_and_normals();


                break;
        }    }

    public Model(letter K)
    {
        switch (shape)
        {
            case letter.K:
                initialize_lists();
                add_letter_K_vertices();
                add_letter_K_texture_coordinates();
                add_letter_K-indices_and_normals();


                break;
        }
    }

    //Add in sides
    private void add_texture_coordinates()
    {
        _texture_coordinates.Add(new Vector2(0.4f, 0));//Bottom
        _texture_coordinates.Add(new Vector2(0.5f, 0));
        _texture_coordinates.Add(new Vector2(0.6f, 0));
        _texture_coordinates.Add(new Vector2(0.7f, 0));

        _texture_coordinates.Add(new Vector2(0.0f, 0.1f));//Lower section
        _texture_coordinates.Add(new Vector2(0.1f, 0.1f));
        _texture_coordinates.Add(new Vector2(0.2f, 0.1f));
        _texture_coordinates.Add(new Vector2(0.3f, 0.1f));
        _texture_coordinates.Add(new Vector2(0.4f, 0.1f));
        _texture_coordinates.Add(new Vector2(0.5f, 0.1f));
        _texture_coordinates.Add(new Vector2(0.6f, 0.1f));
        _texture_coordinates.Add(new Vector2(0.7f, 0.1f));
        _texture_coordinates.Add(new Vector2(0.8f, 0.1f));

        _texture_coordinates.Add(new Vector2(0.2f, 0.3f));
        _texture_coordinates.Add(new Vector2(0.3f, 0.3f));
        _texture_coordinates.Add(new Vector2(0.4f, 0.3f));
        _texture_coordinates.Add(new Vector2(0.5f, 0.3f));
        _texture_coordinates.Add(new Vector2(0.6f, 0.3f));
        _texture_coordinates.Add(new Vector2(0.7f, 0.3f));

        _texture_coordinates.Add(new Vector2(0.2f, 0.4f));//Centre
        _texture_coordinates.Add(new Vector2(0.3f, 0.4f));
        _texture_coordinates.Add(new Vector2(0.4f, 0.4f));
        _texture_coordinates.Add(new Vector2(0.5f, 0.4f));
        _texture_coordinates.Add(new Vector2(0.6f, 0.4f));
        _texture_coordinates.Add(new Vector2(0.7f, 0.4f));

        _texture_coordinates.Add(new Vector2(0.0f, 0.6f));
        _texture_coordinates.Add(new Vector2(0.1f, 0.6f));
        _texture_coordinates.Add(new Vector2(0.2f, 0.6f));
        _texture_coordinates.Add(new Vector2(0.3f, 0.6f));
        _texture_coordinates.Add(new Vector2(0.4f, 0.6f));
        _texture_coordinates.Add(new Vector2(0.5f, 0.6f));
        _texture_coordinates.Add(new Vector2(0.6f, 0.6f));
        _texture_coordinates.Add(new Vector2(0.7f, 0.6f));
        _texture_coordinates.Add(new Vector2(0.8f, 0.6f)); 
    }

    private void add_indices_and_normals()
    {
        //
        _index_list.Add(0);     _texture_index_list.Add(32);
        _index_list.Add(1);     _texture_index_list.Add(31);   _face_normals.Add(new Vector3(0,0,-1));
        _index_list.Add(2);     _texture_index_list.Add(23); // 
        _index_list.Add(0);     _texture_index_list.Add(32);
        _index_list.Add(2);     _texture_index_list.Add(23);    _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(3);     _texture_index_list.Add(24); // 

        _index_list.Add(2);     _texture_index_list.Add(24);
        _index_list.Add(3);     _texture_index_list.Add(23); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(8);     _texture_index_list.Add(17); // 
        _index_list.Add(2);     _texture_index_list.Add(24);
        _index_list.Add(7);     _texture_index_list.Add(18); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(8);     _texture_index_list.Add(17); // 

        _index_list.Add(7);     _texture_index_list.Add(18);
        _index_list.Add(8);     _texture_index_list.Add(17); _face_normals.Add(new Vector3(0,0, -1));
        _index_list.Add(9);     _texture_index_list.Add(12); // 
        _index_list.Add(8);     _texture_index_list.Add(17);
        _index_list.Add(9);     _texture_index_list.Add(12); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(10);     _texture_index_list.Add(11); // 

        //
        _index_list.Add(4);     _texture_index_list.Add(30);
        _index_list.Add(5);     _texture_index_list.Add(29); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(3);     _texture_index_list.Add(23); // 
        _index_list.Add(5);     _texture_index_list.Add(29);
        _index_list.Add(6);     _texture_index_list.Add(22); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(3);     _texture_index_list.Add(23);// 

        _index_list.Add(3);     _texture_index_list.Add(23);
        _index_list.Add(6);     _texture_index_list.Add(22); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(11);     _texture_index_list.Add(16); //
        _index_list.Add(3);     _texture_index_list.Add(23);
        _index_list.Add(11);     _texture_index_list.Add(16); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(8);     _texture_index_list.Add(17); // 

        _index_list.Add(8);     _texture_index_list.Add(17);
        _index_list.Add(11);     _texture_index_list.Add(16); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(13);     _texture_index_list.Add(9); 
        _index_list.Add(8);     _texture_index_list.Add(17);
        _index_list.Add(13);     _texture_index_list.Add(9); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(12);     _texture_index_list.Add(10);

        //TOPS 
        _index_list.Add(0); _texture_index_list.Add(32); 
        _index_list.Add(1); _texture_index_list.Add(31); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(14); _texture_index_list.Add(36); 
        _index_list.Add(0); _texture_index_list.Add(32);
        _index_list.Add(14); _texture_index_list.Add(36); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(15); _texture_index_list.Add(35);

        _index_list.Add(4); _texture_index_list.Add(30);
        _index_list.Add(5); _texture_index_list.Add(29); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(19); _texture_index_list.Add(33);
        _index_list.Add(4); _texture_index_list.Add(30);
        _index_list.Add(19); _texture_index_list.Add(33); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(18); _texture_index_list.Add(34);

        //BOTTOMS                                             
        _index_list.Add(9); _texture_index_list.Add(12);
        _index_list.Add(10); _texture_index_list.Add(11); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(24); _texture_index_list.Add(3);
        _index_list.Add(9); _texture_index_list.Add(12);
        _index_list.Add(23); _texture_index_list.Add(3); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(24); _texture_index_list.Add(4);

        _index_list.Add(12); _texture_index_list.Add(10);
        _index_list.Add(13); _texture_index_list.Add(9); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(27); _texture_index_list.Add(1);
        _index_list.Add(12); _texture_index_list.Add(10);
        _index_list.Add(27); _texture_index_list.Add(1); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(28); _texture_index_list.Add(2);

        //LEFT SIDE
        _index_list.Add(5); _texture_index_list.Add(29);
        _index_list.Add(19); _texture_index_list.Add(28); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(20); _texture_index_list.Add(21);
        _index_list.Add(5); _texture_index_list.Add(29);
        _index_list.Add(20); _texture_index_list.Add(21); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(6); _texture_index_list.Add(22);

        _index_list.Add(6); _texture_index_list.Add(22);
        _index_list.Add(20); _texture_index_list.Add(21); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(25); _texture_index_list.Add(16);
        _index_list.Add(6); _texture_index_list.Add(22);
        _index_list.Add(25); _texture_index_list.Add(15); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(11); _texture_index_list.Add(16);

        _index_list.Add(11); _texture_index_list.Add(16);
        _index_list.Add(25); _texture_index_list.Add(15); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(27); _texture_index_list.Add(8);
        _index_list.Add(11); _texture_index_list.Add(16);
        _index_list.Add(27); _texture_index_list.Add(8); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(13); _texture_index_list.Add(9);

        //RIGHT SIDE
        _index_list.Add(4); _texture_index_list.Add(30);
        _index_list.Add(18); _texture_index_list.Add(27); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(17); _texture_index_list.Add(20);
        _index_list.Add(4); _texture_index_list.Add(30);
        _index_list.Add(17); _texture_index_list.Add(20); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(3); _texture_index_list.Add(23);

        _index_list.Add(8); _texture_index_list.Add(17);
        _index_list.Add(22); _texture_index_list.Add(14); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(26); _texture_index_list.Add(7);
        _index_list.Add(8); _texture_index_list.Add(17);
        _index_list.Add(26); _texture_index_list.Add(7); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(12); _texture_index_list.Add(10);

        //Inside diagonal-----------------------------------
        _index_list.Add(1); _texture_index_list.Add(31);
        _index_list.Add(15); _texture_index_list.Add(27); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(17); _texture_index_list.Add(20);
        _index_list.Add(1); _texture_index_list.Add(31);
        _index_list.Add(17); _texture_index_list.Add(20); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(3); _texture_index_list.Add(23);

        _index_list.Add(8); _texture_index_list.Add(17);//Wrong section?
        _index_list.Add(22); _texture_index_list.Add(14); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(24); _texture_index_list.Add(6);
        _index_list.Add(8); _texture_index_list.Add(17);
        _index_list.Add(24); _texture_index_list.Add(6); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(10); _texture_index_list.Add(11);

        //Outside diagonal top
        _index_list.Add(0); _texture_index_list.Add(32);
        _index_list.Add(14); _texture_index_list.Add(25); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(16); _texture_index_list.Add(19);
        _index_list.Add(0); _texture_index_list.Add(32);
        _index_list.Add(16); _texture_index_list.Add(19); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(2); _texture_index_list.Add(16);

        //Right centre
        _index_list.Add(2); _texture_index_list.Add(24);
        _index_list.Add(7); _texture_index_list.Add(18); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(21); _texture_index_list.Add(13);
        _index_list.Add(2); _texture_index_list.Add(24);
        _index_list.Add(21); _texture_index_list.Add(13); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(7); _texture_index_list.Add(19);

        //Outside diagonal bottom
        _index_list.Add(7); _texture_index_list.Add(18);
        _index_list.Add(21); _texture_index_list.Add(13); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(23); _texture_index_list.Add(5);
        _index_list.Add(7); _texture_index_list.Add(18);
        _index_list.Add(23); _texture_index_list.Add(5); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(9); _texture_index_list.Add(12);
    }

    private void initialize_lists()
    {
        _vertices = new List<Vector3>();
        _index_list = new List<int>();
        _texture_coordinates = new List<Vector2>();
        _texture_index_list = new List<int>();
        _face_normals = new List<Vector3>();
    }

        //indices
    private void add_letter_K_indices()
    {
        //Right
        _index_list.Add(0); 
        _index_list.Add(1);
        _index_list.Add(2);
        _index_list.Add(0); 
        _index_list.Add(2); 
        _index_list.Add(3); 

        _index_list.Add(2); 
        _index_list.Add(3); 
        _index_list.Add(7); 
        _index_list.Add(2);
        _index_list.Add(7); 
        _index_list.Add(8); 

        _index_list.Add(7); 
        _index_list.Add(8); 
        _index_list.Add(9); 
        _index_list.Add(8);
        _index_list.Add(9); 
        _index_list.Add(10); 
    
        //Left
        _index_list.Add(4); 
        _index_list.Add(5);
        _index_list.Add(3); 
        _index_list.Add(5); 
        _index_list.Add(6); 
        _index_list.Add(3);

        _index_list.Add(3); 
        _index_list.Add(6); 
        _index_list.Add(11); 
        _index_list.Add(3); 
        _index_list.Add(11); 
        _index_list.Add(8); 

        _index_list.Add(8); 
        _index_list.Add(11); 
        _index_list.Add(13); 
        _index_list.Add(8); 
        _index_list.Add(13);
        _index_list.Add(12); 






    }
}
    private void add_letter_K_vertices() {
    _vertices.Add(new Vector3(0, 0, -1));//bottom left front
    _vertices.Add(new Vector3(1, 0, -1));
    _vertices.Add(new Vector3(0, 2, -1));//centre left front
    _vertices.Add(new Vector3(1, 2, -1));
    _vertices.Add(new Vector3(0, 3, -1));//centre left front
    _vertices.Add(new Vector3(1, 3, -1));
    _vertices.Add(new Vector3(0, 5, -1));//top left front
    _vertices.Add(new Vector3(1, 5, -1));

    _vertices.Add(new Vector3(2, 0, -1));//bottom right front
    _vertices.Add(new Vector3(2, 5, -1));//top right front
    _vertices.Add(new Vector3(3, 0, -1));//bottom right front
    _vertices.Add(new Vector3(3, 5, -1));//top right front
    _vertices.Add(new Vector3(2, 2, -1));//centre right front
    _vertices.Add(new Vector3(2, 3, -1));//centre right front

    _vertices.Add(new Vector3(0, 0, 1));//bottom left back
    _vertices.Add(new Vector3(1, 0, 1));
    _vertices.Add(new Vector3(0, 2, 1));//centre left back
    _vertices.Add(new Vector3(1, 2, 1));
    _vertices.Add(new Vector3(0, 3, 1));//centre left back
    _vertices.Add(new Vector3(1, 3, 1));
    _vertices.Add(new Vector3(0, 5, 1));//top left back
    _vertices.Add(new Vector3(1, 5, 1));

    _vertices.Add(new Vector3(2, 0, 1));//bottom right back
    _vertices.Add(new Vector3(2, 5, 1));//top right back
    _vertices.Add(new Vector3(3, 0, 1));//bottom right back
    _vertices.Add(new Vector3(3, 5, 1));//top right back
    _vertices.Add(new Vector3(2, 2, 1));//centre right back
    _vertices.Add(new Vector3(2, 3, 1));//centre right back



}

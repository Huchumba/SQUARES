using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateMap : MonoBehaviour
{
    public int num;

    public GameObject platform_ground;
    public GameObject cube_ground;
    public GameObject cube_phys;
    public GameObject cube_not_phys;
    public GameObject big_cube_not_phys;

    List<float> coords_x;
    List<float> coords_y;

    public float redp;
    public float bluep;

    public Rigidbody2D redm;
    public Rigidbody2D bluem;

    private void Start()
    {
        num = Random.Range(0, 12);
        coords_x = new List<float>(100);
        coords_y = new List<float>(100);
        switch(num){
            case 0:
                coords_x.Add(-8f); coords_y.Add(-4f);
                coords_x.Add(-4f); coords_y.Add(-2f);
                coords_x.Add(4f); coords_y.Add(-2f);
                coords_x.Add(8f); coords_y.Add(-4f);

                coords_x.Add(-12f); coords_y.Add(-4f);
                coords_x.Add(-16f); coords_y.Add(-2f);
                coords_x.Add(16f); coords_y.Add(-2f);
                coords_x.Add(12f); coords_y.Add(-4f);
                for (int i = 0; i < 8; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(platform_ground, posGround, Quaternion.identity);
                }
                bluem.position = new Vector2(4, -1f);
                redm.position = new Vector2(-4, -1f);
                break;

            case 1:
                
                coords_x.Add(-4f); coords_y.Add(0f);
                coords_x.Add(4f); coords_y.Add(0f);
                coords_x.Add(-16f); coords_y.Add(0f);
                coords_x.Add(16f); coords_y.Add(0f);
                

                coords_x.Add(-8f); coords_y.Add(-3f);
                coords_x.Add(8f); coords_y.Add(-3f);
                coords_x.Add(-8f); coords_y.Add(3f);
                coords_x.Add(8f); coords_y.Add(3f);
                coords_x.Add(-12f); coords_y.Add(-3f);
                coords_x.Add(12f); coords_y.Add(-3f);
                coords_x.Add(-12f); coords_y.Add(3f);
                coords_x.Add(12f); coords_y.Add(3f);


                for (int i = 0; i < 4; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(platform_ground, posGround, Quaternion.identity);
                }

                for (int i = 4; i < 12; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(cube_ground, posGround, Quaternion.identity);
                }
                bluem.position = new Vector2(4, 1.5f);
                redm.position = new Vector2(-4, 1.5f);
                break;

            case 2:
                coords_x.Add(-8); coords_y.Add(-3);
                coords_x.Add(-4); coords_y.Add(1);
                coords_x.Add(4); coords_y.Add(1);
                coords_x.Add(8); coords_y.Add(-3);
                coords_x.Add(-8); coords_y.Add(3);
                coords_x.Add(8); coords_y.Add(3);

                coords_x.Add(-6); coords_y.Add(-1.5f);
                coords_x.Add(-2); coords_y.Add(0.5f);
                coords_x.Add(2); coords_y.Add(0.5f);
                coords_x.Add(6); coords_y.Add(-1.5f);

                coords_x.Add(-16); coords_y.Add(-6f);
                coords_x.Add(16); coords_y.Add(-6f);

                coords_x.Add(0); coords_y.Add(-2f);
                coords_x.Add(14); coords_y.Add(-2f);
                coords_x.Add(-14); coords_y.Add(-2f);
                coords_x.Add(0); coords_y.Add(6f);

                for (int i = 0; i < 12; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(cube_ground, posGround, Quaternion.identity);
                }
                for (int i = 12; i < 16; i++)
                {
                    Vector2 posGround2 = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround2 = Instantiate(platform_ground, posGround2, Quaternion.identity);
                }
                bluem.position = new Vector2(4, 2f);
                redm.position = new Vector2(-4, 2f);
                break;

            case 3:
                coords_x.Add(6); coords_y.Add(0f);
                coords_x.Add(0); coords_y.Add(6f);
                coords_x.Add(0); coords_y.Add(-6f);
                coords_x.Add(-6); coords_y.Add(0f);

                coords_x.Add(0); coords_y.Add(0f);
                coords_x.Add(-6); coords_y.Add(-6f);
                coords_x.Add(-6); coords_y.Add(6f);
                coords_x.Add(6); coords_y.Add(-6f);
                coords_x.Add(6); coords_y.Add(6f);

                for (int i = 0; i < 4; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(cube_ground, posGround, Quaternion.identity);
                }
                for (int i = 4; i < 9; i++)
                {
                    Vector2 posGround2 = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround2 = Instantiate(platform_ground, posGround2, Quaternion.identity);
                }
                bluem.position = new Vector2(6, 1f);
                redm.position = new Vector2(-6, 1f);
                break;

            case 4:
                coords_x.Add(9); coords_y.Add(1.5f);
                coords_x.Add(-9); coords_y.Add(-1.5f);
                coords_x.Add(6); coords_y.Add(1f);
                coords_x.Add(-6); coords_y.Add(-1f);
                coords_x.Add(3); coords_y.Add(0.5f);
                coords_x.Add(-3); coords_y.Add(-0.5f);
                coords_x.Add(12); coords_y.Add(1f);
                coords_x.Add(-12); coords_y.Add(-1f);
                coords_x.Add(15); coords_y.Add(0.5f);
                coords_x.Add(-15); coords_y.Add(-0.5f);
            
                
                for (int i = 0; i < 10; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(cube_ground, posGround, Quaternion.identity);
                }
                bluem.position = new Vector2(3, 1.5f);
                redm.position = new Vector2(-3, 0.5f);
                break;


            case 5:
                coords_x.Add(9); coords_y.Add(1.5f);
                coords_x.Add(-9); coords_y.Add(-1.5f);
                coords_x.Add(6); coords_y.Add(1f);
                coords_x.Add(-6); coords_y.Add(-1f);
                coords_x.Add(3); coords_y.Add(0.5f);
                coords_x.Add(-3); coords_y.Add(-0.5f);
                coords_x.Add(12); coords_y.Add(1f);
                coords_x.Add(-12); coords_y.Add(-1f);
                coords_x.Add(15); coords_y.Add(0.5f);
                coords_x.Add(-15); coords_y.Add(-0.5f);
                

                for (int i = 0; i < 10; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(platform_ground, posGround, Quaternion.identity);
                }
                break;

            case 6:
                coords_x.Add(0); coords_y.Add(1);
                coords_x.Add(0); coords_y.Add(2);
                coords_x.Add(0); coords_y.Add(3);
                coords_x.Add(0); coords_y.Add(4);
                coords_x.Add(0); coords_y.Add(5);
                coords_x.Add(-3); coords_y.Add(1);
                coords_x.Add(-3); coords_y.Add(2);
                coords_x.Add(-3); coords_y.Add(3);
                coords_x.Add(-3); coords_y.Add(4);
                coords_x.Add(-3); coords_y.Add(5);
                coords_x.Add(3); coords_y.Add(1);
                coords_x.Add(3); coords_y.Add(2);
                coords_x.Add(3); coords_y.Add(3);
                coords_x.Add(3); coords_y.Add(4);
                coords_x.Add(3); coords_y.Add(5);

                coords_x.Add(0); coords_y.Add(0);
                coords_x.Add(-4); coords_y.Add(0);
                coords_x.Add(-8); coords_y.Add(0);
                coords_x.Add(4); coords_y.Add(0);
                coords_x.Add(8); coords_y.Add(0);

                for (int i = 0; i < 15; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(cube_phys, posGround, Quaternion.identity);
                }

                for (int i = 15; i < 20; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(platform_ground, posGround, Quaternion.identity);
                }
                bluem.position = new Vector2(6, 1f);
                redm.position = new Vector2(-6, 1f);
                break;

            case 7:
                coords_x.Add(0); coords_y.Add(0);
                coords_x.Add(-6); coords_y.Add(0);
                coords_x.Add(-10); coords_y.Add(-3);
                coords_x.Add(6); coords_y.Add(0);
                coords_x.Add(10); coords_y.Add(-3);

                for (int i = 0; i < 5; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(platform_ground, posGround, Quaternion.identity);
                }
                for (int i = 0; i < 5; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i] + 0.5f);
                    GameObject newGround = Instantiate(cube_phys, posGround, Quaternion.identity);
                }
                for (int i = 0; i < 5; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i] + 0.5f, coords_y[i] + 1.5f);
                    GameObject newGround = Instantiate(cube_phys, posGround, Quaternion.identity);
                }
                for (int i = 0; i < 5; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i] - 0.5f, coords_y[i] + 1.5f);
                    GameObject newGround = Instantiate(cube_phys, posGround, Quaternion.identity);
                }
                for (int i = 0; i < 5; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i] + 2.5f);
                    GameObject newGround = Instantiate(cube_phys, posGround, Quaternion.identity);
                }

                bluem.position = new Vector2(6, 3.5f);
                redm.position = new Vector2(-6, 3.5f);
                break;

            case 8:
                coords_x.Add(0); coords_y.Add(2);
                coords_x.Add(-6); coords_y.Add(-1);
                coords_x.Add(6); coords_y.Add(-1);
                coords_x.Add(-10); coords_y.Add(-4);
                coords_x.Add(-2); coords_y.Add(-4);
                coords_x.Add(2); coords_y.Add(-4);
                coords_x.Add(10); coords_y.Add(-4);

                for (int i = 0; i < 7; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(platform_ground, posGround, Quaternion.identity);
                }

                break;

            case 9:
                coords_x.Add(0); coords_y.Add(6);
                coords_x.Add(0); coords_y.Add(-6);
                coords_x.Add(1.5f); coords_y.Add(5);
                coords_x.Add(1.5f); coords_y.Add(-5);
                coords_x.Add(-1.5f); coords_y.Add(5);
                coords_x.Add(-1.5f); coords_y.Add(-5);
                coords_x.Add(3); coords_y.Add(3.5f);
                coords_x.Add(3); coords_y.Add(-3.5f);
                coords_x.Add(-3); coords_y.Add(3.5f);
                coords_x.Add(-3); coords_y.Add(-3.5f);
                coords_x.Add(4.5f); coords_y.Add(2);
                coords_x.Add(4.5f); coords_y.Add(-2);
                coords_x.Add(-4.5f); coords_y.Add(2);
                coords_x.Add(-4.5f); coords_y.Add(-2);
                coords_x.Add(6); coords_y.Add(0);
                coords_x.Add(-6); coords_y.Add(0);

                for (int i = 0; i < 16; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(cube_not_phys, posGround, Quaternion.identity);
                }
                bluem.position = new Vector2(1.5f, 7);
                redm.position = new Vector2(-1.5f, 7);
                break;

            case 10:
                coords_x.Add(-10); coords_y.Add(7);
                coords_x.Add(10); coords_y.Add(7);
                coords_x.Add(-6); coords_y.Add(0);
                coords_x.Add(6); coords_y.Add(0);

                for (int i = 0; i < 4; i++)
                {
                    Vector2 posGround = new Vector2(coords_x[i], coords_y[i]);
                    GameObject newGround = Instantiate(big_cube_not_phys, posGround, Quaternion.identity);
                }
                bluem.position = new Vector2(10, 8);
                redm.position = new Vector2(-10, 8);
                break;

            case 11:
                coords_x.Add(0); coords_y.Add(9);
                coords_x.Add(0); coords_y.Add(-9);
                coords_x.Add(0); coords_y.Add(6);
                coords_x.Add(0); coords_y.Add(-6);
                coords_x.Add(0); coords_y.Add(3);
                coords_x.Add(0); coords_y.Add(-3);
                coords_x.Add(0); coords_y.Add(0);
                for (int j = 1; j < 5; j++)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        Vector2 posGround = new Vector2(coords_x[i] + (j*3), coords_y[i]);
                        GameObject newGround = Instantiate(cube_not_phys, posGround, Quaternion.identity);
                    }
                    for (int i = 0; i < 7; i++)
                    {
                        Vector2 posGround = new Vector2(coords_x[i] - (j*3), coords_y[i]);
                        GameObject newGround = Instantiate(cube_not_phys, posGround, Quaternion.identity);
                    }
                }
                bluem.position = new Vector2(2, 7);
                redm.position = new Vector2(-2, 7);
                break;
        }
    }
}

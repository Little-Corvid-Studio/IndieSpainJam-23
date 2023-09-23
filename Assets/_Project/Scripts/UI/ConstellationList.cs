using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ConstellationNames
{
    ARIES,
    TAURUS,
    GEMINI,
    VIRGO,
    LIBRA,
    CANCER,
    SCORPIO,
    SAGITARIO,
    CAPRICORNIO,
    AQUARIUS,
    PISCIS,

    MAYOR,
    MINOR,

    NUM_CONSTELLATIONS
}

public struct ConstellationData
{
    public int numEstrellas;
    public bool[,] conexiones; //matriz bidimensional de conexiones[indice estrella,nºconexion por estrella]
}
public class ConstellationList
{
    public ConstellationData getConstellationData(ConstellationNames names)
    {
        ConstellationData data = new ConstellationData();
        switch (names)
        {
            case ConstellationNames.ARIES:
                data.numEstrellas = 3;
                data.conexiones= new bool[3,3];
                for(int i=0; i<3; i++)
                {
                    for(int j=0; j < 3; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }
                data.conexiones[0,1] = true;
                data.conexiones[1,0] = true;
                data.conexiones[1,2]= true;
                data.conexiones[2,1] = true;
                
                break;
            case ConstellationNames.TAURUS:
                data.numEstrellas = 6;
                data.conexiones = new bool[6, 6];
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }

                data.conexiones[0, 1] = false;
                data.conexiones[1, 0] = false;

                data.conexiones[0, 2] = true;
                data.conexiones[2, 0] = true;
              
                data.conexiones[3, 2] = false;
                data.conexiones[2, 3] = false;

                data.conexiones[1, 3] = true;
                data.conexiones[3, 1] = true;
                
                data.conexiones[4, 3] = true;
                data.conexiones[3, 4] = true;
                
                data.conexiones[4, 2] = true;
                data.conexiones[2, 4] = true;
                
                data.conexiones[5, 4] = true;
                data.conexiones[4, 5] = true;


                break;
            case ConstellationNames.GEMINI:
                data.numEstrellas = 9;
                data.conexiones = new bool[9, 9];
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }

                data.conexiones[0, 1] = true;
                data.conexiones[1, 0] = true;
                data.conexiones[0, 2] = true;
                data.conexiones[2, 0] = true;
                data.conexiones[8, 2] = true;
                data.conexiones[2, 8] = true;
                data.conexiones[3, 1] = true;
                data.conexiones[1, 3] = true;
                data.conexiones[3, 7] = true;
                data.conexiones[7, 3] = true;
                data.conexiones[5, 4] = true;
                data.conexiones[4, 5] = true;
                data.conexiones[6, 4] = true;
                data.conexiones[4, 6] = true;
                data.conexiones[4, 7] = true;
                data.conexiones[7, 4] = true;
                data.conexiones[4, 8] = true;
                data.conexiones[7, 8] = true;

                break;
            case ConstellationNames.VIRGO:
                data.numEstrellas = 8;
                data.conexiones = new bool[8, 8];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }


                data.conexiones[0, 1] = true;
                data.conexiones[1, 0] = true;

                data.conexiones[2, 1] = true;
                data.conexiones[1, 2] = true;

                data.conexiones[2, 3] = true;
                data.conexiones[3, 2] = true;

                data.conexiones[3, 4] = true;
                data.conexiones[4, 3] = true;
                data.conexiones[1, 4] = true;
                data.conexiones[4, 1] = true;

                data.conexiones[7, 4] = true;
                data.conexiones[4, 7] = true;

                data.conexiones[3, 6] = true;
                data.conexiones[6, 3] = true;
                break;
            case ConstellationNames.CANCER:
                data.numEstrellas = 5;
                data.conexiones = new bool[5, 5];
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }

                data.conexiones[0, 2] = true;
                data.conexiones[2, 0] = true;


                data.conexiones[0, 1] = true;
                data.conexiones[1, 0] = true;

                data.conexiones[3, 2] = true;
                data.conexiones[2, 3] = true;

                data.conexiones[2, 4] = true;
                data.conexiones[4, 2] = true;

                break;
            case ConstellationNames.LIBRA:
                data.numEstrellas = 5;
                data.conexiones = new bool[5, 5];
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }

                data.conexiones[0, 1] = true;
                data.conexiones[1, 0] = true;

                data.conexiones[0, 2] = true;
                data.conexiones[2, 0] = true;

                data.conexiones[2, 1] = true;
                data.conexiones[1, 2] = true;


                data.conexiones[3, 2] = true;
                data.conexiones[2, 3] = true;

                data.conexiones[4, 1] = true;
                data.conexiones[1, 4] = true;

                break;

            case ConstellationNames.SCORPIO:
                data.numEstrellas = 7;
                data.conexiones = new bool[7, 7];
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }

                data.conexiones[0, 1] = true;
                data.conexiones[1, 0] = true;

                data.conexiones[2, 1] = true;
                data.conexiones[1, 2] = true;

                data.conexiones[2, 3] = true;
                data.conexiones[3, 2] = true;

                data.conexiones[4, 3] = true;
                data.conexiones[3, 4] = true;

                data.conexiones[5, 3] = true;
                data.conexiones[3, 5] = true;

                data.conexiones[6, 3] = true;
                data.conexiones[3, 6] = true;
                break;

            case ConstellationNames.SAGITARIO:
                data.numEstrellas = 7;
                data.conexiones = new bool[7, 7];
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }
                data.conexiones[0, 1] = true;
                data.conexiones[1, 0] = true;

                data.conexiones[0, 3] = true;
                data.conexiones[3, 0] = true;

                data.conexiones[0, 4] = true;
                data.conexiones[4, 0] = true;

                data.conexiones[0, 6] = true;
                data.conexiones[6, 0] = true;

                data.conexiones[1, 6] = true;
                data.conexiones[6, 1] = true;

                data.conexiones[1, 5] = true;
                data.conexiones[5, 1] = true;

                data.conexiones[2, 5] = true;
                data.conexiones[5, 2] = true;

                data.conexiones[2, 1] = true;
                data.conexiones[1, 2] = true;

                data.conexiones[3, 2] = true;
                data.conexiones[2, 3] = true;


                break;


            case ConstellationNames.AQUARIUS:
                data.numEstrellas = 9;
                data.conexiones = new bool[9, 9];
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }

                data.conexiones[0, 1] = true;
                data.conexiones[1, 0] = true;
                data.conexiones[0, 6] = true;
                data.conexiones[6, 0] = true;
                data.conexiones[2, 1] = true;
                data.conexiones[1, 2] = true;
                data.conexiones[0, 3] = true;
                data.conexiones[3, 0] = true;
                data.conexiones[3, 5] = true;
                data.conexiones[5, 3] = true;
                data.conexiones[5, 4] = true;
                data.conexiones[4, 5] = true;
                data.conexiones[5, 7] = true;
                data.conexiones[7, 5] = true;
                data.conexiones[8, 4] = true;
                data.conexiones[4, 8] = true;
                break;
            case ConstellationNames.CAPRICORNIO:
                data.numEstrellas = 5;
                data.conexiones = new bool[5, 5];
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }

                data.conexiones[0, 1] = true;
                data.conexiones[1, 0] = true;

                data.conexiones[2, 1] = true;
                data.conexiones[1, 2] = true;

                data.conexiones[2, 3] = true;
                data.conexiones[3, 2] = true;

                data.conexiones[4, 3] = true;
                data.conexiones[3, 4] = true;


                data.conexiones[4, 0] = true;
                data.conexiones[0, 4] = true;



                break;

            case ConstellationNames.PISCIS:
                data.numEstrellas = 6;
                data.conexiones = new bool[6, 6];
                for (int i = 0; i <6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }

                data.conexiones[0, 1] = true;
                data.conexiones[1, 0] = true;

                data.conexiones[2, 1] = true;
                data.conexiones[1, 2] = true;

                data.conexiones[2, 3] = true;
                data.conexiones[3, 2] = true;

                data.conexiones[1, 3] = true;
                data.conexiones[3, 1] = true;

                data.conexiones[4, 5] = true;
                data.conexiones[5, 4] = true;


                data.conexiones[4, 0] = true;
                data.conexiones[0, 4] = true;

                break;

            case ConstellationNames.MAYOR:
                data.numEstrellas = 6;
                data.conexiones = new bool[6, 6];
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }

                data.conexiones[0, 2] = true;
                data.conexiones[2, 0] = true;

                data.conexiones[1, 2] = true;
                data.conexiones[2, 1] = true;
                
                data.conexiones[1, 3] = true;
                data.conexiones[3, 1] = true;

                data.conexiones[4, 3] = true;
                data.conexiones[3, 4] = true;

                data.conexiones[1,5] = true;
                data.conexiones[5, 1] = true;

                data.conexiones[4, 5] = true;
                data.conexiones[5, 4] = true;

                break;

            case ConstellationNames.MINOR:
                data.numEstrellas = 6;
                data.conexiones = new bool[6, 6];
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }

                data.conexiones[0, 2] = true;
                data.conexiones[2, 0] = true;

                data.conexiones[1, 2] = true;
                data.conexiones[2, 1] = true;

                data.conexiones[1, 3] = true;
                data.conexiones[3, 1] = true;

                data.conexiones[4, 3] = true;
                data.conexiones[3, 4] = true;

                data.conexiones[1, 5] = true;
                data.conexiones[5, 1] = true;

                data.conexiones[4, 5] = true;
                data.conexiones[5, 4] = true;

                break;
        }

        return data;
    }

}

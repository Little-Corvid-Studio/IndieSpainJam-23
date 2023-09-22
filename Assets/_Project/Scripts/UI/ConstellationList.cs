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

    NUM_CONSTELLATIONS
}

public struct ConstellationData
{
    public int numEstrellas;
    public bool[,] conexiones; //matriz bidimensional de conexiones[indice estrella,n�conexion por estrella]
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
                data.numEstrellas = 9;
                data.conexiones = new bool[12, 12];
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        data.conexiones[i, j] = false;
                    }
                }

                break;
            case ConstellationNames.CANCER:
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
                break;
             
        }

        return data;
    }

}

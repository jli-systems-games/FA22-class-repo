using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  Simon.Project3.Scripts
{
    public class TerrainGenerator : MonoBehaviour
    {
    
        public int width = 20;
        public int height = 20;
        public int depth = 5;
    
        public float scale = 10f;
    
        public float offsetX = 0;
        public float offsetY = 0;
    
        private void Start()
        {
            
        }
    
        void Update()
        {
            Terrain terrain = GetComponent<Terrain>();
            terrain.terrainData = GenerateTerrain(terrain.terrainData);
        }
    
        TerrainData GenerateTerrain(TerrainData terrainData)
        {
            terrainData.heightmapResolution = width + 1;
            
            terrainData.size = new Vector3(width, depth, height);
            
            
            terrainData.SetHeights(0, 0, GenerateHeights());
    
            return terrainData;
        }
    
        float[,] GenerateHeights()
        {
            float[,] heights = new float[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    heights[x, y] = CalculateHeight(x, y);
                }
            }
    
            return heights;
        }
    
        float CalculateHeight(int x, int y)
        {
            float xCoord = (float)x / width * scale;
            float yCoord = (float)y / height * scale;
    
            return Mathf.PerlinNoise(xCoord, yCoord);
        }
        
       
    }

}

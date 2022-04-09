using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SafaProjects.Project.Grids.Scripts
{
    public class GridSpawner : MonoBehaviour
    {
        
        [Header("Prefabs")]
        public GameObject gridCubePrefab;
        public GameObject exampleCube;
        
        [Header("Grid Sizes")]
        public int width;
        public int depth;
        public Vector3 gridOrigin;
        public float gridOffset = 1f;

        [Header("Grid Cube List")]
        public List<Vector3> gridPositions;

        private void Start()
        {
            SpawnGrid();
        }

        private void SpawnGrid()
        {
            for (var x = 0; x < width; x++)
            {
                for (var z = 0; z < depth; z++)
                {
                    Vector3 spawnPos = new Vector3(x * gridOffset, 1f, z * gridOffset) + gridOrigin;
                    SpawnGridCube(spawnPos, x, z);
                    gridPositions.Add(spawnPos);
                }
            }
        }

        private void SpawnGridCube(Vector3 spawnPos, int x, int z)
        {
            GameObject spawnedCube = Instantiate(gridCubePrefab, spawnPos, Quaternion.identity);
            spawnedCube.GetComponent<GridTile>().SetCoordinates(x, z);
            spawnedCube.transform.SetParent(transform);
        }


        private int _currentIndex;
        private GameObject _example;
        private Vector3 _yOffset = new Vector3(0, -1, 0);

        private readonly Stack<GameObject> _cubeStacks = new Stack<GameObject>();
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_cubeStacks.Count % gridPositions.Count == 0) _yOffset += Vector3.up;
                _example = Instantiate(exampleCube, gridPositions[_cubeStacks.Count % gridPositions.Count] + _yOffset, Quaternion.identity);
                _cubeStacks.Push(_example);
            }

            if (Input.GetMouseButtonDown(1))
            {

                StartCoroutine(StartWithdraw());
                
                IEnumerator StartWithdraw()
                {
                    while (_cubeStacks.Count > 0)
                    {
                        _cubeStacks.Peek().SetActive(false);
                        _cubeStacks.Pop();
                        if (_cubeStacks.Count % gridPositions.Count == 0) _yOffset -= Vector3.up;
                        yield return new WaitForSeconds(0.05f);
                    }
                }
      


            }
        }
    }
}
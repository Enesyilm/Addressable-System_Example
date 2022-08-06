using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class DefaultAssetManager : MonoBehaviour
    {
        #region Self Variables
        [SerializeField]
        private List<GameObject> ObjectList;
        [SerializeField]
        private Transform TargetLocation;
        private GameObject Tree; 
        private GameObject Terrain; 
        private GameObject Miscellaneous; 
        private GameObject Water; 

        #endregion

        public void CreateWater()
        {
            Water=Instantiate(ObjectList[3],TargetLocation);
        }
        public void DeleteWater()
        {
            Destroy(Water);
        }
        public void CreateTree()
        {
            Tree=Instantiate(ObjectList[0],TargetLocation);
        }
        public void DeleteTree()
        {
            Destroy(Tree);
        }
        public void CreateTerrain()
        {
            Terrain=Instantiate(ObjectList[1],TargetLocation);
        }
        public void DeleteTerrain()
        {
            Destroy(Terrain);
        }
        public void CreateMiscellaneous()
        {
            Miscellaneous=Instantiate(ObjectList[2],TargetLocation);
        }
        public void DeleteMiscellaneous()
        {
            Destroy(Miscellaneous);
        }
    }
}
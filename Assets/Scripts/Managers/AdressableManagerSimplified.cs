using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Managers
{
    public class AdressableManagerSimplified : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField]
        private Transform targetLocation;
        [SerializeField]
        private List<AssetReference> assetReferenceList; 
        private AsyncOperationHandle Tree; 
        private AsyncOperationHandle Terrain; 
        private AsyncOperationHandle Miscellaneous; 
        private AsyncOperationHandle Water; 
        
        

        #endregion

        #region Private Variables

        private Logger Logger;

        #endregion
        

        #endregion
        private void Awake()
        {
            Addressables.InitializeAsync().Completed+=OnAdressibleSystemInit;
        }
        private void OnAdressibleSystemInit(AsyncOperationHandle<IResourceLocator> obj)
        {
            // for (int i = 0; i < 3; i++)
            // {
            //     assetReferenceList[i].InstantiateAsync(targetLocation);//The main purpose of the AsyncOperationHandle is to allow access to the status 
            //    // and result of an operation.The result of the operation will be vaild until you call AsyncOperationHandle.Release on the operation.
            //   
            // }
            
        }

        public void CreateMiscellaneousButton()
        {
            assetReferenceList[2].InstantiateAsync(targetLocation).Completed+= (asyncHandle) =>
            {
                Miscellaneous = asyncHandle;
            };
        }

        public void CreateTerrainButton()
        {
            assetReferenceList[1].InstantiateAsync(targetLocation).Completed+= (asyncHandle) =>
            {
                Terrain = asyncHandle;
            };;
        }

        public void CreateTreesButton()
        {
           assetReferenceList[0].InstantiateAsync(targetLocation).Completed+= (asyncHandle) =>
           {
               Tree = asyncHandle;
               GameObject go = asyncHandle.Result;
               bool istrue =asyncHandle.IsDone;
               //asyncHandle.
           };
        }
        public void CreateWaterButton()
        {
            assetReferenceList[3].InstantiateAsync(targetLocation).Completed+= (asyncHandle) =>
            {
                Water = asyncHandle;
            };
        }
        public void DeleteTreesButton()
        {
            Addressables.Release(Tree);
        }
        public void DeleteTerrainsButton()
        {
            Addressables.Release(Terrain);
            //assetReferenceList[1].ReleaseInstance(Terrain);
            //Addressables.Release(assetReferenceList[0]);
        }public void DeleteMiscellaneousButton()
        {
            Addressables.Release(Miscellaneous);
            //assetReferenceList[2].ReleaseInstance(Miscellaneous);
            //Addressables.Release(assetReferenceList[0]);
        }
        public void DeleteWaterButton()
        {
            Addressables.Release(Water);
            // assetReferenceList[3].ReleaseInstance(Water);
            //Addressables.Release(assetReferenceList[0]);
        }
    }
}
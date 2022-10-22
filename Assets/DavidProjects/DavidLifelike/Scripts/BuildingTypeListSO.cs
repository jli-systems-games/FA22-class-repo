using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DavidLifelike {
[CreateAssetMenu(menuName = "ScriptableObjects/BuildingTypeList")]
public class BuildingTypeListSO : ScriptableObject {

    public List<BuildingTypeSO> list;
 }
}
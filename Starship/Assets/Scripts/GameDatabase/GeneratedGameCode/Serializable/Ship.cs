//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System;
using GameDatabase.Enums;
using GameDatabase.Model;

namespace GameDatabase.Serializable
{
	[Serializable]
	public class ShipSerializable : SerializableItem
	{
		public ShipCategory ShipCategory;
		public string Name;
		public int Faction;
		public SizeClass SizeClass;
		public string IconImage;
		public float IconScale;
		public string ModelImage;
		public float ModelScale;
		public UnityEngine.Vector2 EnginePosition;
		public string EngineColor;
		public float EngineSize;
		public EngineSerializable[] Engines;
		public float EnergyResistance;
		public float KineticResistance;
		public float HeatResistance;
		public float QuantumResistance;
		public float ShieldEnergyResistance;
		public float ShieldKineticResistance;
		public float ShieldHeatResistance;
		public float ShieldQuantumResistance;
		public float EnergyShieldEnergyResistance;
		public float EnergyShieldKineticResistance;
		public float EnergyShieldHeatResistance;
		public float EnergyShieldQuantumResistance;
		public float ArmorPointsAttenuatableRate;
		public float ArmorRepairAttenuatableRate;
		public float EnergyPointsAttenuatableRate;
		public float EnergyRechargeAttenuatableRate;
		public float ShieldPointsAttenuatableRate;
		public float ShieldRechargeAttenuatableRate;
		public float EnergyShieldPointsAttenuatableRate;
		public float EnergyShieldRechargeAttenuatableRate;
		public bool Regeneration;
		public float BaseWeightModifier;
		public int[] BuiltinDevices;
		public string Layout;
		public string SecondLayout;
		public UAVLaunchPlatformSerializable[] UAVLaunchPlatforms;
		public BarrelSerializable[] Barrels;
	}
}
